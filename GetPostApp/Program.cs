using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace GetPostApp
{
    public class User
    {
        public string email { get; set; }
        public string name { get; set; }
        public static User user = new User() { email = "tsput14@gmail.com", name = "TomaszSp" };

    }
    public class Detail
    {
        public string fieldOfStudy { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string university { get; set; }
        public int yearOfStudy { get; set; }

        public static Detail detail = new Detail { fieldOfStudy = "Management and Production Engineering", firstName = "Tomasz", lastName = "Sput", university = "Silesian University of Technology", yearOfStudy = 5 };

    }
    public class Skill
    {
        public string skillName { get; set; }
        public static Skill skill = new Skill { skillName = "Norwegian Speaker" };
    }
    public class SkillsId
    {
        public int[] skillsIds { get; set; }
        public string userId { get; set; }

        static int[] idArray = new int[] { 2, 3, 4, 6, 7, 9, 34, 36, 40, 41, 42, 54, 53, 52, 51, 49, 48, 47, 46, 45, 44, 56, 57, 58, 59, 60 };
        public static SkillsId id = new SkillsId { skillsIds = idArray, userId = "26cc8499-790e-4697-a6bc-658107efdb7e" };

    }
    public class Authorization
    {
        public static byte[] credentials = Encoding.ASCII.GetBytes("TomaszSp:rGDSIyRBro");
    }
    class Program
    {
        private static List<string> idList = new List<string>();
        private static string createUserUrl = "users"; // Enable to create new user
        private static string retrievePassword = "users/password"; // Enable to retrieve users id and password
        private static string skillsUrl = "skills"; // Enable to get the list of skills or post new one
        private static string retrieveUser = "users/";
        private static string getUser = "users/26cc8499-790e-4697-a6bc-658107efdb7e";
        private static string getDetails = "users/details/2dc04930-e862-4d86-b4a4-3005c0e62df7";
        private static string getAllDetails = "users/alldetails/26cc8499-790e-4697-a6bc-658107efdb7e";



        public static HttpClient client = new HttpClient();

        static void AddId()
        {
            idList.Add("26cc8499-790e-4697-a6bc-658107efdb7e");
        }
    
        static void Main(string[] args)
        {
            client.BaseAddress = new Uri("http://52.211.158.241/");
            Get.RetrieveUser(getAllDetails);
            //Post.PostUser(retrievePassword, User.user);
            //Put.PutDetails();
            //Post.PostSkills();
            //Put.PutSkills();
            Console.ReadKey();
        }
    }

    
    

}
