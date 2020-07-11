using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using System.Net.Http.Json;
using System.IO;

namespace ChartJs.Blazor.Sample.Shared.Services
{
    public class ResultsTableServices
    {
        public ResultsTable[] Results { get; set; }
        public async Task GetResultFromJsonAsync()
        {
            var Http = new HttpClient();
            string directory = Directory.GetCurrentDirectory().Replace("Services", "JsonFolder");
            string path = directory + "sample-data/results.json";
            Results = await Http.GetFromJsonAsync<ResultsTable[]>(path);
        }
    }
}
