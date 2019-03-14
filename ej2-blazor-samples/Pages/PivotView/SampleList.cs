﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ej2_blazor_samples;
namespace ej2_blazor_samples
{
    internal partial class SampleConfig
    {
        public List<Sample> PivotTable { get; set; } = new List<Sample>{
            new Sample
            {
                Name = "Default Functionalities",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/DefaultFunctionalities",
                FileName = "DefaultFunctionalities.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "User Interaction",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/UserInteraction",
                FileName = "UserInteraction.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Label and Value Filtering",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/AdvanceFiltering",
                FileName = "AdvanceFiltering.cshtml",
                Type = SampleType.New
            },
            new Sample
            {
                Name = "Editing",
                Category = "PivotTable",
                Directory = "PivotView/PivotTable",
                Url = "PivotView/Editing",
                FileName = "Editing.cshtml",
                Type = SampleType.New
            }
        };
    }
}