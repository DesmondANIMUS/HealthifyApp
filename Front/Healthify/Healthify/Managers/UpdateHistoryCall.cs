using Healthify.Models;
using Healthify.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Healthify.Managers
{
    class UpdateHistoryCall
    {
        private const string URI = Constants.UPHIS;
        internal static async Task<CommonResponse> UpdatPatientHistoryAsync(HitoryInfo hisinfo)
        {
            var httpClient = new HttpClient();
            var parameters = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("uid", hisinfo.PUID),
                                                               new KeyValuePair<string, string>("duid", hisinfo.DUID),
                                                               new KeyValuePair<string, string>("date", hisinfo.Date),
                                                               new KeyValuePair<string, string>("dis", hisinfo.Disease),
                                                               new KeyValuePair<string, string>("duration", hisinfo.Duration),
                                                               new KeyValuePair<string, string>("medic", hisinfo.Medicine),
                                                               new KeyValuePair<string, string>("dname", hisinfo.DName)});

            var response = await httpClient.PostAsync(URI, parameters);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(CommonResponse));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));

            var datax = (CommonResponse)serializer.ReadObject(ms);

            return datax;            
        }
    }
}
