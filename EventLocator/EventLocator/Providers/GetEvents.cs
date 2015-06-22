using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Web;
using EventLocator.Models;
using Newtonsoft.Json;

namespace EventLocator.Providers
{
    public class GetEvents
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public async void GetEventsList()
        {
            HttpClient httpClient = new HttpClient();

            // Assign the authentication headers

            httpClient.DefaultRequestHeaders.Authorization =
                CreateBasicHeader("httplocalhost", "g9s67bx9qvtj");

            HttpResponseMessage response =
                httpClient.GetAsync("http://api.eventfinder.co.nz/v2/events.json?").Result;
            if (response.IsSuccessStatusCode)

            {
                string content = response.Content.ReadAsStringAsync().Result;
              
               EventListing.Rootobject rootObject = new EventListing.Rootobject();

               JsonConvert.PopulateObject(content, rootObject);
                //var image = rootObject.
               foreach (var eventItem in rootObject.events)
               {
                   eventItem.images.ToString();
                   db.Events.Add(eventItem);
               }
               db.SaveChanges();
            }
        }

        public AuthenticationHeaderValue CreateBasicHeader(string username, string password)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(username + ":" + password);
            return new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
        }
    }
}

 