using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GetPostApp
{
    public class Get
    {
        public async static void RetrieveUser(string url)
        {
            //authorization
            var credentials = Encoding.ASCII.GetBytes("TomaszSp:rGDSIyRBro");
            Program.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Authorization.credentials));

            using (HttpResponseMessage response = await Program.client.GetAsync(url))
            {
                using (HttpContent content = response.Content)
                {
                    string mycontent = await content.ReadAsStringAsync();
                    Console.WriteLine(mycontent);
                }
            }
        }
    }
}
