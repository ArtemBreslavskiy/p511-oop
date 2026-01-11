using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string URL = "https://jsonplaceholder.org/posts";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            var response = client.GetAsync(URL);

            Console.WriteLine(response.Result);
        }
    }
}
