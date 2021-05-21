using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutomationPractice.Base
{
    public static class Utils
    {
        private static Random random = new Random();
        public static string GetJsonToken(this string fileName, string token)
        {
            try
            {
                return JObject.Parse(File.ReadAllText(fileName)).Value<string>(token);
            }
            catch
            {
                return "";
            }
        }

        public static void Log(this string report, string message)
        {
            using (StreamWriter sw = new StreamWriter(report, true))
            {
                sw.WriteLine($"<h4>{message}</h4>");
            }
        }
        public static string RandomEmail()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
             var email =new string(Enumerable.Repeat(chars, 10)
            .Select(s => s[random.Next(s.Length)]).ToArray()) + "@gmail.com";
            return email;
        }
    }
}
