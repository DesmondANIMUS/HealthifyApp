using Healthify.Models;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Healthify.Managers
{
    class UserCall
    {        
        private const string URI = Constants.GETUSER;
        internal static async Task<UserResponse> GetUserAsync(string username)
        {            
            var http = new HttpClient();            
            var parameters = new FormUrlEncodedContent(new[] { new KeyValuePair<string, string>("uid", username) });            

            var response = await http.PostAsync(URI, parameters);
            var result = await response.Content.ReadAsStringAsync();
            var serializer = new DataContractJsonSerializer(typeof(UserResponse));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));

            var datax = (UserResponse)serializer.ReadObject(ms);

            return datax;            
        }
    }
}
