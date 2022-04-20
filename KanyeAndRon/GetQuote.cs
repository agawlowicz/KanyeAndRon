using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
    public class GetQuote
    {
        public static void Kanye()
        {
            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            Console.WriteLine($"Kanye: {JObject.Parse(kanyeResponse).GetValue("quote").ToString()}");
            Console.WriteLine();

        }

        public static void Ron()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            Console.WriteLine($"Ron: {JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim()}");
            Console.WriteLine();
        }
    }
}
