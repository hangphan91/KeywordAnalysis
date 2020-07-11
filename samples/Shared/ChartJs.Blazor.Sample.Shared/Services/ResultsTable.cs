using System;
using System.Collections.Generic;

namespace ChartJs.Blazor.Sample.Shared.Services
{
    public class ResultsTable
    {
        public string WordGroup { get; set; }
        public double Count { get; set; }
        public bool IsInList { get; set; }
        public string IncludedInGroup { get; set; }
    }
}
