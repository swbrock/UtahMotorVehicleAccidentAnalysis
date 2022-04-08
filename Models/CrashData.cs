using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtahMotorVehicleAccidentAnalysis.Models
{
    public class CrashData
    {
        public float pedestrian_involved_True { get; set; }
        public float bicyclist_involved_True { get; set; }
        public float motorcycle_involved_True { get; set; }
        public float improper_restraint_True { get; set; }
        public float unrestrained_True { get; set; }
        public float dui_True { get; set; }
        public float intersection_related_True { get; set; }
        public float overturn_rollover_True { get; set; }
        public float single_vehicle_True { get; set; }
        public float distracted_driving_True { get; set; }
        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                pedestrian_involved_True,
                bicyclist_involved_True,
                motorcycle_involved_True,
                improper_restraint_True,
                unrestrained_True,
                dui_True,
                intersection_related_True,
                overturn_rollover_True,
                single_vehicle_True,
                distracted_driving_True
            };
            int[] dimensions = new int[] { 1, 10 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
