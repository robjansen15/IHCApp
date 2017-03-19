using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace UserWebApp
{
    public class WebRequestHandler<T>
    {
        public void POST(T obj, string path)
        {
            string URL = System.Configuration.ConfigurationManager.AppSettings["server"] + path;
            string urlParameters = "?serializedObject=" + new Serializer<T>().Serialize(obj);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {

            }
            else
            {

            }
        }


        public string GET(string path, string parameters)
        {
            string responseString = string.Empty;
            string URL = System.Configuration.ConfigurationManager.AppSettings["server"] + path;
            string urlParameters = parameters;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {
                //lets grab the response
                responseString = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return responseString;
        }
    }
}