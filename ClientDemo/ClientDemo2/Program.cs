using RestSharp;
using System;
using System.Net.Http;
using System.Net;
using System.IO;

namespace ClientDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getting the data:\n");
            GetEmployeeData();

            Console.WriteLine("Creating data:\n ");
            PostEmployeeData();
        }

        private static void GetEmployeeData()
        {
            string path = "https://jsonplaceholder.typicode.com/posts/1/comments";

            WebRequest request = WebRequest.Create(path);
            request.Method = "GET";

            WebResponse response = request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                string result = sr.ReadToEnd();
                Console.WriteLine(result);
                sr.Close();
                
            }
            
        }
        private static void PostEmployeeData()
        {
            string path = "https://jsonplaceholder.typicode.com/posts";

            WebRequest request = WebRequest.Create(path);
            
            request.Method = "POST";
            request.ContentType = "application/json";

            string postData = "{\"title\":\"Testing\",\"body\":\"Testing post method\",\"userId\":\"101\"}";

            using (Stream requestStream = request.GetRequestStream())
            {
                StreamWriter sw = new StreamWriter(requestStream);

                sw.Write(postData);
                sw.Flush();
                sw.Close();

                WebResponse response = request.GetResponse();

                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(responseStream);
                    string result = sr.ReadToEnd();
                    Console.WriteLine(result);
                    sr.Close();
                }
            }
        }
    }
}
