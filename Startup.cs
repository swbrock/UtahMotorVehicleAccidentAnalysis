using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.ML.OnnxRuntime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtahMotorVehicleAccidentAnalysis.Data;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace UtahMotorVehicleAccidentAnalysis
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.Cookie.Name = "YourAppCookieName";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = "/Identity/Account/Login";
                // ReturnUrlParameter requires 
                //using Microsoft.AspNetCore.Authentication.Cookies;
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;
            });

            services.Configure<IdentityOptions>(options =>
            {
                // Default Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 1;
            });

            services.AddDbContext<AccidentsDbContext>(options =>
            {
                options.UseMySql(Configuration["ConnectionStrings:AccidentsDbConnection"]);

            });
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(Configuration["ConnectionStrings:DefaultConnection"]);
            });
            services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                 .AddDefaultUI()
                 .AddEntityFrameworkStores<ApplicationDbContext>()
                 .AddDefaultTokenProviders();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddAuthorization(options => {
                options.AddPolicy("readpolicy",
                    builder => builder.RequireRole("Admin", "Manager", "User"));
                options.AddPolicy("writepolicy",
                    builder => builder.RequireRole("Admin", "Manager"));
            });


            services.AddScoped<IAccidentsRepository, EFAccidentsRepository>();

            services.AddSingleton<InferenceSession>(
                new InferenceSession("xgboost.onnx"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //This will allow us 
            //app.Use(async (context, next) =>
            //{
            //    context.Response.Headers.Add("Content-Security-Policy", "base-uri 'self'; default-src 'self'; img-src *; object-src 'none'; script-src 'self' https://stackpath.bootstrapcdn.com/; style-src 'self' https://stackpath.bootstrapcdn.com/; upgrade-insecure-requests;");
            //    await next();
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
