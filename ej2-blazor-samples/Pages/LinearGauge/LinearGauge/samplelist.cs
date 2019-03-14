﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> LinearGauge { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Container",
                Category = "LinearGauge",
                Directory = "LinearGauge/LinearGauge",
                Url = "LinearGauge/Container",
                FileName = "Container.cshtml",
                Type = SampleType.New
            }

         };
    }
}
