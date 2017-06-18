using Healthify.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Healthify.Managers
{
    class BloodCall
    {
        private const string URI = Constants.BLOOD;
        private static async Task<BloodResponse> GetBloodAsync()
        {
            var http = new HttpClient();           

            var response = await http.GetAsync(URI);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(BloodResponse));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));

            var datax = (BloodResponse)serializer.ReadObject(ms);

            return datax;
        }

        internal static async Task GettingActualBloodAsync(ObservableCollection<Response> searchResults)
        {
            var datawrapper = await GetBloodAsync();
            var actual = datawrapper.response;
            foreach (var a in actual)
                searchResults.Add(a);
        }
    }
}
