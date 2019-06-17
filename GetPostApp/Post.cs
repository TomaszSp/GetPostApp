using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GetPostApp
{
    public class Post
    {
        public async static void PostUser(string url, User user)
        {
            Program.client.DefaultRequestHeaders.Accept.Clear();
            Program.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //authorization
            var credentials = Encoding.ASCII.GetBytes("TomaszSp:rGDSIyRBro");
            Program.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(credentials));

            using (var response = await Program.client.PostAsJsonAsync(url, user))
            {

                using (HttpContent content = response.Content)
                {
                    string myContent = await content.ReadAsStringAsync();
                    Console.WriteLine(myContent);
                }

            }

        }
        public async static void PostSkills(string url, Skill skill)
        {


            Program.client.DefaultRequestHeaders.Accept.Clear();
            Program.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //authorization
            Program.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Authorization.credentials));

            var response = await Program.client.PostAsJsonAsync(url, skill);
            Console.WriteLine(response);
        }
    }
}
