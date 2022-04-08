using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLWS.Models
{
        public static class User
        {
            public static int id { get; set; }
            public static string email { get; set; }
            public static string password { get; set; }
            public static string first_name { get; set; }
            public static string last_name { get; set; }
            public static DateTime register_date { get; set; }
            public static int responsable { get; set; }
            public static int admin { get; set; }
            public static int suspendu { get; set; }
            public static object dateDebut { get; set; }
            public static object dateFin { get; set; }
            public static double budget { get; set; }
            public static string userToken { get; set; }

        }

}
