using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    class Program
    {
        static void Main(string[] args)
        {
            var kanyeURL = "https://api.kanye.rest/";

            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            for (int i = 0; i < 5; i++)
            {
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

                Console.WriteLine(JObject.Parse(kanyeResponse).GetValue("quote").ToString());
                Console.WriteLine();

                var ronResponse = client.GetStringAsync(ronURL).Result;

                Console.WriteLine(JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim());
                Console.WriteLine();
            }
        }
    }
}
