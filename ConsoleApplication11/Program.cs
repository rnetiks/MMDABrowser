using System;
using System.Net;
using System.Windows.Forms;
using Fizzler.Systems.HtmlAgilityPack;
using System.Security.Cryptography;
using System.Net.Http;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApplication11
{
    class Program
    {

        static string ComputeMD5(string rawData)
        {
            using (MD5 hashing = MD5.Create())
            {
                byte[] bytes = hashing.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        [STAThread]
        static void Main(string[] args)
        {
            string p1 = "441a2867e31fb0ac2879b1e69ff23897", p2 = string.Empty;
            HttpResponseMessage req;
            HttpClient httpClient = new HttpClient();
            do
            {
                string u, p;
                Console.Write("Username: ");
                u = Console.ReadLine();
                Console.Write("Password: ");
                p = Console.ReadLine();
                var fuec = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("user", u),
                    new KeyValuePair<string, string>("pass", p)
                });
                req = httpClient.PostAsync("https://mmda.booru.org/index.php?page=login&code=00", fuec).Result;
                if (req.IsSuccessStatusCode) {
                    p2 = ComputeMD5(req.Content.ReadAsStringAsync().Result);
                    if (p1 == p2) {
                        Console.Clear();
                        Console.WriteLine("Wrong Username/Password");
                    }
                } else 
                    Console.WriteLine($"An Error occurred, please give the following message to a Web Admin:\n\n{req.StatusCode}{req.Version}{req.ReasonPhrase}");
            } while (p2 == p1);
        }
    }

}
