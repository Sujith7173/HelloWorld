using BusinessObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
 


namespace SampleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMessage();
            Console.ReadLine();
        }

        public async static void GetMessage()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:59663/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.GetAsync("api/values");
                if (response.IsSuccessStatusCode)
                {
                    var responseAsString = await response.Content.ReadAsStringAsync();
                    //var helloWorldBO = JsonConvert.DeserializeObject<HelloWorldBO>(responseAsString);
                    Console.WriteLine("Message From Service {0}", responseAsString);
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
        }
    }
}
