using Healthify.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Healthify.Managers
{
    class HistoricalCall
    {
        private const string URI = Constants.PATHIS;
        private static async Task<HistoricalResponse> GetHistoryAsync(string username)
        {

            var http = new HttpClient();
            var parameters = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("uid", username) });

            var response = await http.PostAsync(URI, parameters);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(HistoricalResponse));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));

            var datax = (HistoricalResponse)serializer.ReadObject(ms);

            return datax;
        }

        internal static async Task GettingActual(ObservableCollection<hissResponse> searchResults, string u)
        {               
            var datawrapper = await GetHistoryAsync(u);
            var actual = datawrapper.response;
            foreach (var a in actual)
            {
                a.Date = DataSecurity.DecryptThisCipher(a.Date, Constants.PRIVPASS);
                a.Duration = DataSecurity.DecryptThisCipher(a.Duration, Constants.PRIVPASS);
                a.Disease = DataSecurity.DecryptThisCipher(a.Disease, Constants.PRIVPASS);
                a.Medicine = DataSecurity.DecryptThisCipher(a.Medicine, Constants.PRIVPASS);                
                searchResults.Add(a);
            }
        }
    }
}
