using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GetPostApp
{
    public class Put
    {

        public async static void PutDetails(string url, Detail detail)
        {


            Program.client.DefaultRequestHeaders.Accept.Clear();
            Program.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //authorization
            var credentials = Encoding.ASCII.GetBytes("TomaszSp:rGDSIyRBro");
            Program.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

            var response = await Program.client.PutAsJsonAsync(url, detail);
            Console.WriteLine(response);
        }

        public async static void PutSkills(string url, SkillsId id)
        {

            Program.client.DefaultRequestHeaders.Accept.Clear();
            Program.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //authorization
            var credentials = Encoding.ASCII.GetBytes("TomaszSp:rGDSIyRBro");
            Program.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

            var response = await Program.client.PutAsJsonAsync(url, id);
            Console.WriteLine(response);
        }
    }
}
