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
        public WebRequestHandler() { }


        public void POST(T obj, string path)
        {
            string URL = "https://localhost:9000/"+path;
            string urlParameters = "?"+new Serializer<T>().Serialize(obj);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
            
            }
            else
            {
                
            }
        }

        
        public string GET()
        {
            string responseString = string.Empty;
            string URL = "https://sub.domain.com/objects.json";
            string urlParameters = string.Empty;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                //var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;
                //foreach (var d in dataObjects)
                //{
                //    Console.WriteLine("{0}", d.Name);
                //}
                responseString = "response here";
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return responseString;
        }



        
    }
}