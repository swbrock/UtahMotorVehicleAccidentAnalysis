using Microsoft.EntityFrameworkCore.Migrations;

namespace UtahMotorVehicleAccidentAnalysis.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accidents",
                columns: table => new
                {
                    crash_id = table.Column<int>(nullable: false),
                    crash_datetime = table.Column<string>(nullable: true),
                    route = table.Column<string>(nullable: true),
                    milepoint = table.Column<double>(nullable: false),
                    lat_utm_y = table.Column<double>(nullable: false),
                    long_utm_x = table.Column<double>(nullable: false),
                    main_road_name = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    county_name = table.Column<string>(nullable: true),
                    crash_severity_id = table.Column<int>(nullable: false),
                    work_zone_related = table.Column<string>(nullable: true),
                    pedestrian_involved = table.Column<string>(nullable: true),
                    bicyclist_involved = table.Column<string>(nullable: true),
                    motorcycle_involved = table.Column<string>(nullable: true),
                    improper_restraint = table.Column<string>(nullable: true),
                    unrestrained = table.Column<string>(nullable: true),
                    dui = table.Column<string>(nullable: true),
                    intersection_related = table.Column<string>(nullable: true),
                    wild_animal_related = table.Column<string>(nullable: true),
                    domestic_animal_related = table.Column<string>(nullable: true),
                    overturn_rollover = table.Column<string>(nullable: true),
                    commercial_motor_veh_involved = table.Column<string>(nullable: true),
                    teenage_driver_involved = table.Column<string>(nullable: true),
                    older_driver_involved = table.Column<string>(nullable: true),
                    night_dark_condition = table.Column<string>(nullable: true),
                    single_vehicle = table.Column<string>(nullable: true),
                    distracted_driving = table.Column<string>(nullable: true),
                    drowsy_driving = table.Column<string>(nullable: true),
                    roadway_departure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accidents");
        }
    }
}
