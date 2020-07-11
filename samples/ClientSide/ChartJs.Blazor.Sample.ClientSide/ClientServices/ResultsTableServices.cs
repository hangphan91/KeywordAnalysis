using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using System.Net.Http.Json;
using System.IO;

namespace ChartJs.Blazor.Sample.ClientSide.ClientServices
{
    public class ResultsTableServices
    {
        public ResultsTable[] Results { get; set; }
        public async Task GetResultFromJsonAsync()
        {
            string path = "JsonFolder/results.json";
            var Http = new HttpClient();
            Results = await Http.GetFromJsonAsync<ResultsTable[]>(path);
        }
    }
}
