using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LLWS.Models;
using System.Configuration;

namespace LLWS.Core
{
    /// <summary>
    /// Cette classe statique est accessible tout au long du cycle de vie de l'application sans avoir besoins d'être instanciée
    /// Cette classe ne contient que des strings définissant les différentes routes de l'API accessible.
    /// Utilité : Eviter la répétition, et si le lien de l'API change il n'y a que la variable API_BASE_URL à changer
    /// </summary>
    public static class APIManager
    {
        public static string API_BASE_URL = ConfigurationManager.AppSettings["lienApi"];
        public static HttpClient httpClient;


        //Authentification
        public static string API_ROUTE_LOGIN = API_BASE_URL + "/login";
        public static string API_ROUTE_REGISTER = API_BASE_URL + "/register";


        //Cotations
        public static string API_ROUTES_GET_ALL_COTATIONS = API_BASE_URL + "/cotations/get";
        public static string API_ROUTES_GET_HISTORIQUE = API_BASE_URL + "/cotations/historique/";

        //Utilisateur
        public static string API_ROUTES_GET_USER_PORTEFEUILLE = API_BASE_URL + "/users/portefeuille/";
        public static string API_ROUTES_POST_SELL = API_BASE_URL + "/cotations/sell";
        public static string API_ROUTES_POST_BUY = API_BASE_URL + "/cotations/buy";
        public static string API_ROUTES_GET_MOUVEMENT_BUY = API_BASE_URL + "/users/" + User.id.ToString() + "/mouvements/1";
        public static string API_ROUTES_GET_MOUVEMENT_SELL = API_BASE_URL + "/users/" + User.id.ToString() + "/mouvements/2";

        //Admin & responsable
        public static string API_ROUTES_GET_USERS = API_BASE_URL + "/admin/users";
        public static string API_ROUTES_GET_SPECIFIC_USER = API_BASE_URL + "/admin/user/"; // L'appel devra se faire avec une valeur d'id


        public static string API_ROUTES_ADD_ROLE = API_BASE_URL + "/responsable/user/addRole";
        public static string API_ROUTES_REMOVE_ROLE = API_BASE_URL + "/responsable/user/removeRole";


        public static string API_ROUTES_POST_ADDBUDGET = API_BASE_URL + "/responsable/user/addBudget";
        public static string API_ROUTES_POST_EDITUSER = API_BASE_URL + "/responsable/user/edit";

        public static string API_ROUTES_POST_COTATIONS = API_BASE_URL + "/admin/cotations/post";
        public static string API_ROUTES_UPDATE_COTATIONS = API_BASE_URL + "/admin/cotations/update";

        /// <summary>
        /// Poste des données en JSON sur une route de l'Api
        /// </summary>
        /// <param name="route">Route de l'API à appeler (POST uniquement)</param>
        /// <param name="json">Objet JSON à poster</param>
        /// <returns></returns>
        public static async Task<JToken> posterData(string route, object json)
        {

            //Les informations sont postéee
            var responseString = await route
            .PostUrlEncodedAsync(json)
            .ReceiveString();

            //On naviague à travers la réponse Json
            JToken token = JToken.Parse(responseString);

            return token;

        }


        /// <summary>
        /// Appelle une route de l'Api et récupère la réponse retournée.
        /// </summary>
        /// <param name="route">Route de l'API à appeler (GET uniquement)</param>
        /// <returns></returns>
        public static async Task<JToken> recevoirData(string route)
        {

            var responseString = await route
            .GetStringAsync();

            //On naviague à travers la réponse Json
            JToken token = JToken.Parse(responseString);
            return token;

        }

    }
}
