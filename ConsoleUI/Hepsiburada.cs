using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Hepsiburada
    {
        HttpClient httpClient;
        public async Task<string> GetXmlResult(string baseUrl)
        {
            string userName = "yeditepesoft_dev";
            string passwd = "rg6vzMJ!";
            httpClient = new HttpClient();
            var authToken = Encoding.ASCII.GetBytes($"{userName}:{passwd}");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/Xml"));
            var result = await httpClient.GetAsync(baseUrl);
            var content = await result.Content.ReadAsStringAsync();
            return content;
        }
    }
}
