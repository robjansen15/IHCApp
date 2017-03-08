using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;

namespace UserWebApp
{
    public class WebRequestHandler
    {
        public WebRequestHandler()
        {

        }


        public void PostRequest(string requestString)
        {
            string URL = requestString.Split('?')[0];
            string urlParameters = "?" + requestString.Split('?')[1];
          
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                var x = "yay";
                
            }
            else
            {

            }

        }
        

        public string GetRequests(string requestString)
        {
            string URL = requestString;
            string urlParameters = "?api_key=123";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                //var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;
                //foreach (var d in dataObjects)
                //{
                //    Console.WriteLine("{0}", d.Name);
                //}
            }
            else
            {

            }

            return requestString;
        }

    }
}