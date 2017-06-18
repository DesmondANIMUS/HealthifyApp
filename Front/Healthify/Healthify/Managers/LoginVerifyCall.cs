using Healthify.Models;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Healthify.Managers
{
    class LoginVerifyCall
    {
        private static string URI;
        static FormUrlEncodedContent parameters;

        internal static async Task<CommonResponse> LoginVerifyAsync(LoginInfo log = null, string OTP = null)
        {
            var http = new HttpClient();

            if (OTP == null)
            {
                parameters = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("uid", log.Username),                                                               
                                                               new KeyValuePair<string, string>("type", log.TypeLogin)});
                URI = Constants.LOGIN;
            }

            else
            {
                parameters = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string> ("otp", OTP) });
                URI = Constants.VERIF;
            }

            var response = await http.PostAsync(URI, parameters);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(CommonResponse));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));

            var datax = (CommonResponse)serializer.ReadObject(ms);

            return datax;            
        }
    }
}
