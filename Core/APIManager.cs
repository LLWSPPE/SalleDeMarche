﻿using System;
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

        //Admin & responsable
        public static string API_ROUTES_GET_USERS = API_BASE_URL + "/admin/users";
        public static string API_ROUTES_GET_SPECIFIC_USER = API_BASE_URL + "/admin/user/"; // L'appel devra se faire avec une valeur d'id

        public static string API_ROUTES_POST_PROMOTE = API_BASE_URL + "/responsable/user/promote";
        public static string API_ROUTES_POST_REVOKE = API_BASE_URL + "/responsable/user/revoke";

        public static string API_ROUTES_POST_SUSPENSION = API_BASE_URL + "/responsable/user/suspension";
        public static string API_ROUTES_POST_REHABILITATE = API_BASE_URL + "/responsable/user/rehabilitate";

        public static string API_ROUTES_POST_ADDBUDGET = API_BASE_URL + "/responsable/user/addBudget";
        public static string API_ROUTES_POST_EDITUSER = API_BASE_URL + "/responsable/user/edit";

    }
}
