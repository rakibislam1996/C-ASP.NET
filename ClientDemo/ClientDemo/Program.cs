using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace ClientDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var customers = new List<Customer>()
            {
                new Customer() { Id = 101, Name = "Rakib", UserName = "rakib", Email = "r@mail.com" },
                new Customer() { Id = 102, Name = "Sakib", UserName = "sakib", Email = "s@mail.com" }
            };
            
            var customerJson = JsonConvert.SerializeObject(customers);
            Console.WriteLine("After Serialization:\n\n" + customerJson + "\n");

            string URL = "https://jsonplaceholder.typicode.com/users";
            await ReadFileFromURL(URL);
            

            //var tasks = new List<Task> { ReadFileFromLocal(), ReadFileFromURL2(URL) };
            //await Task.WhenAll(tasks);
        }
        
        private static async Task ReadFileFromURL(string URL)
        {
            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage responseMessage = await httpClient.GetAsync(URL))
                {
                    if(responseMessage.IsSuccessStatusCode)
                    {
                        var statusCode = responseMessage.StatusCode;
                        var status = statusCode.ToString();
                        //Console.WriteLine($"The status code : {status}\n");

                        //HttpResponseHeaders responseHeaders = responseMessage.Headers;
                        //Console.WriteLine("The response headers:\n" + responseHeaders.ToString());

                        using (HttpContent content = responseMessage.Content)
                        {
                            //var contentHeaders = content.Headers;
                            //Console.WriteLine("The response content headers: \n" + contentHeaders.ToString()+ "\n");

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                var customers = JsonConvert.DeserializeObject<List<Customer>>(data);
                                Console.WriteLine("After Deserialization:\n");
                                PrintCustomer(customers);
                            }
                            else
                                Console.WriteLine("Requested data not found.");
                        }
                    }
                    else
                        Console.WriteLine($"The request is not succeeded.\nWith the message : {responseMessage.StatusCode.ToString()}");
                }
            }
        }

        private static void PrintCustomer(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Id : " + customer.Id);
                Console.WriteLine("Name : " + customer.Name);
                Console.WriteLine("UserName : " + customer.UserName);
                Console.WriteLine("Email : " + customer.Email);
                Console.WriteLine("Address :" + 
                    "\nCity: " + customer.Address.City + 
                    "\nStreet: " + customer.Address.Street +
                    "\nZip Code: " + customer.Address.ZipCode + 
                    "\nLatitude: " + customer.Address.Geo.Latitude + 
                    "\nLongitude: " + customer.Address.Geo.Longitude + "\n");
            }
        }
        private static async Task ReadFileFromURL2(string URL)
        {
            Console.WriteLine("\nReading file from URL: ");

            using (var httpClient = new HttpClient())
            {

                string result = await httpClient.GetStringAsync(URL);
                Console.WriteLine($"Result : {result}");
            }
        }

        private static async Task ReadFileFromLocal()
        {
            Console.WriteLine("Reading file from local directory:");
            string name = await File.ReadAllTextAsync("Name.txt");
            Console.WriteLine($"My name is : {name}");
        }
        
    }
}
