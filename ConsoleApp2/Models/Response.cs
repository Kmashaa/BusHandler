using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Models
{
    internal class Response
    {

        public class Rootobject
        {
            public string result { get; set; }
            public Stops_Start[] stops_start { get; set; }
            public Stops_Finish[] stops_finish { get; set; }
            public Schedule[] schedule { get; set; }
            public Select_Start select_start { get; set; }
            public Select_Finish select_finish { get; set; }
        }

        public class Select_Start
        {
            public string id_stop { get; set; }
            public string id_city { get; set; }
        }

        public class Select_Finish
        {
            public string id_stop { get; set; }
            public string id_city { get; set; }
        }

        public class Stops_Start
        {
            public string id_city { get; set; }
            public string city_name { get; set; }
            public string id_stop { get; set; }
            public string stop_name { get; set; }
            public string stop_is_change { get; set; }
            public string stop_change_text { get; set; }
            public Stop_Time stop_time { get; set; }
            public object id_route { get; set; }
            public string gps_coor { get; set; }
            public string stop_photo { get; set; }
        }

        public class Stop_Time
        {
            public string _10 { get; set; }
        }

        public class Stops_Finish
        {
            public string id_city { get; set; }
            public string city_name { get; set; }
            public string id_stop { get; set; }
            public string stop_name { get; set; }
            public string stop_is_change { get; set; }
            public string stop_change_text { get; set; }
            public Stop_Time1 stop_time { get; set; }
            public object id_route { get; set; }
            public string gps_coor { get; set; }
            public string stop_photo { get; set; }
        }

        public class Stop_Time1
        {
            public string _10 { get; set; }
        }

        public class Schedule
        {
            public int count { get; set; }
            public string time { get; set; }
            public string status { get; set; }
            public int booking_until { get; set; }
            public string id_route { get; set; }
            public string route_name { get; set; }
            public string cost_adult { get; set; }
            public string cost_child { get; set; }
            public string cost_transit { get; set; }
        }

    }
}
