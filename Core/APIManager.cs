using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using System.Net;
using System.Net.Http;

namespace LLWS.Core
{
    public static class APIManager
    {
        public static string API_BASE_URL = "http://localhost:9000";
        public static HttpClient httpClient;


        //Routes used thoughout the app.

        //Authentification
        public static string API_ROUTE_LOGIN = API_BASE_URL + "/login";
        public static string API_ROUTE_REGISTER = API_BASE_URL + "/register";


        //Cotations
        public static string API_ROUTES_GET_ALL_COTATIONS = API_BASE_URL + "/cotations/get";


    }
}
