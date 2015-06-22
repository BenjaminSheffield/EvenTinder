using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventLocator.Models
{
    public class EventListing
    {
        public class Rootobject
        {
            public Attributes attributes { get; set; }
            public Event[] events { get; set; }
        }

        public class Attributes
        {
            public int count { get; set; }
        }

        public class Event
        {
            public int id { get; set; }
            public string url { get; set; }
            public string url_slug { get; set; }
            public string name { get; set; }
            public string presented_by { get; set; }
            public string description { get; set; }
            public string datetime_start { get; set; }
            public string datetime_end { get; set; }
            public string location_summary { get; set; }
            public string address { get; set; }
            public bool is_free { get; set; }
            public bool is_featured { get; set; }
            public bool is_cancelled { get; set; }
            public string restrictions { get; set; }
            //public Point point { get; set; }
            public string username { get; set; }
            public string timezone { get; set; }
            //public Location location { get; set; }
            //public Category category { get; set; }
            public string datetime_summary { get; set; }
            //public Sessions sessions { get; set; }
            //public Ticket_Types ticket_types { get; set; }
            //public Artists artists { get; set; }
            //public Web_Sites2 web_sites { get; set; }
            //public Images images { get; set; }
        }

        public class Point
        {
            public float lat { get; set; }
            public float lng { get; set; }
        }

        public class Location
        {
            public int id { get; set; }
            public string name { get; set; }
            public string summary { get; set; }
            public bool is_venue { get; set; }
            public int count_current_events { get; set; }
            public string description { get; set; }
            public Images images { get; set; }
            public Point1 point { get; set; }
        }

        public class Images
        {
            public Attributes1 attributes { get; set; }
            public Image[] images { get; set; }
        }

        public class Attributes1
        {
            public int count { get; set; }
        }

        public class Image
        {
            public int? id { get; set; }
            public bool is_primary { get; set; }
            public Transforms transforms { get; set; }
        }

        public class Transforms
        {
            public Attributes2 attributes { get; set; }
            public Transform[] transforms { get; set; }
        }

        public class Attributes2
        {
            public int count { get; set; }
        }

        public class Transform
        {
            public int transformation_id { get; set; }
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Point1
        {
            public float lat { get; set; }
            public float lng { get; set; }
        }

        public class Category
        {
            public int id { get; set; }
            public string name { get; set; }
            public string url_slug { get; set; }
            public int parent_id { get; set; }
            public int count_current_events { get; set; }
        }

        public class Sessions
        {
            public Attributes3 attributes { get; set; }
            public Session[] sessions { get; set; }
        }

        public class Attributes3
        {
            public int count { get; set; }
        }

        public class Session
        {
            public int id { get; set; }
            public string timezone { get; set; }
            public string datetime_start { get; set; }
            public string datetime_end { get; set; }
            public bool is_cancelled { get; set; }
            public bool is_ticketed { get; set; }
            public bool is_currently_onsale { get; set; }
            public bool is_for_tickets_only { get; set; }
            public string ticketing_label { get; set; }
            public string offsale_at { get; set; }
            public Session_Tickets session_tickets { get; set; }
            public string datetime_summary { get; set; }
        }

        public class Session_Tickets
        {
            public Attributes4 attributes { get; set; }
            public Session_Tickets1[] session_tickets { get; set; }
        }

        public class Attributes4
        {
            public int count { get; set; }
        }

        public class Session_Tickets1
        {
            public int id { get; set; }
            public string name { get; set; }
            public string price { get; set; }
            public bool is_ticketed { get; set; }
            public string description { get; set; }
            public int minimum_purchase_quantity { get; set; }
            public bool is_addon { get; set; }
            public string onsale_at { get; set; }
            public object offsale_at { get; set; }
            public bool is_sold_out { get; set; }
            public bool is_limited_remaining { get; set; }
        }

        public class Ticket_Types
        {
            public Attributes5 attributes { get; set; }
            public Ticket_Types1[] ticket_types { get; set; }
        }

        public class Attributes5
        {
            public int count { get; set; }
        }

        public class Ticket_Types1
        {
            public int id { get; set; }
            public string name { get; set; }
            public string price { get; set; }
            public bool is_ticketed { get; set; }
            public string description { get; set; }
            public int minimum_purchase_quantity { get; set; }
            public bool is_addon { get; set; }
            public string onsale_at { get; set; }
            public object offsale_at { get; set; }
        }

        public class Artists
        {
            public Attributes6 attributes { get; set; }
            public Artist[] artists { get; set; }
        }

        public class Attributes6
        {
            public int count { get; set; }
        }

        public class Artist
        {
            public int id { get; set; }
            public string name { get; set; }
            public string url_slug { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public Web_Sites web_sites { get; set; }
            public Images1 images { get; set; }
            public Location1 location { get; set; }
            public Category1 category { get; set; }
        }

        public class Web_Sites
        {
            public Attributes7 attributes { get; set; }
            public Web_Sites1[] web_sites { get; set; }
        }

        public class Attributes7
        {
            public int count { get; set; }
        }

        public class Web_Sites1
        {
            public string url { get; set; }
            public string name { get; set; }
        }

        public class Images1
        {
            public Attributes8 attributes { get; set; }
            public Image1[] images { get; set; }
        }

        public class Attributes8
        {
            public int count { get; set; }
        }

        public class Image1
        {
            public int id { get; set; }
            public bool is_primary { get; set; }
            public Transforms1 transforms { get; set; }
        }

        public class Transforms1
        {
            public Attributes9 attributes { get; set; }
            public Transform1[] transforms { get; set; }
        }

        public class Attributes9
        {
            public int count { get; set; }
        }

        public class Transform1
        {
            public int transformation_id { get; set; }
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }

        public class Location1
        {
            public int id { get; set; }
            public string name { get; set; }
            public string summary { get; set; }
            public bool is_venue { get; set; }
            public int count_current_events { get; set; }
        }

        public class Category1
        {
            public int id { get; set; }
            public string name { get; set; }
            public string url_slug { get; set; }
            public int parent_id { get; set; }
            public int count_current_events { get; set; }
        }

        public class Web_Sites2
        {
            public Attributes10 attributes { get; set; }
            public Web_Sites3[] web_sites { get; set; }
        }

        public class Attributes10
        {
            public int count { get; set; }
        }

        public class Web_Sites3
        {
            public string url { get; set; }
            public string name { get; set; }
        }

        public class Images2
        {
            public Attributes11 attributes { get; set; }
            public Image2[] images { get; set; }
        }

        public class Attributes11
        {
            public int count { get; set; }
        }

        public class Image2
        {
            public int id { get; set; }
            public bool is_primary { get; set; }
            public Transforms2 transforms { get; set; }
        }

        public class Transforms2
        {
            public Attributes12 attributes { get; set; }
            public Transform2[] transforms { get; set; }
        }

        public class Attributes12
        {
            public int count { get; set; }
        }

        public class Transform2
        {
            public int transformation_id { get; set; }
            public string url { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }
    }
}