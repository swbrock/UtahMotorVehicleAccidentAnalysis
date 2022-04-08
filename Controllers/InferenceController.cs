using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using UtahMotorVehicleAccidentAnalysis.Models;

namespace aspnetcore.Controllers
{ 
    public class InferenceController : Controller
    {
        private InferenceSession _session;

        public InferenceController(InferenceSession session)
        {
            _session = session;
        }

        [HttpGet]
        public IActionResult EnterData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Score(CrashData data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("input", data.AsTensor())
            });
            Tensor<long> score = result.First().AsTensor<long>();
            var prediction = new Prediction { PredictedValue = score.First() };
            result.Dispose();
            return View("Score", prediction);
        }
    }
}