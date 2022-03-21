using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WebApplicationClient
{

    public static class GlobaleVariables
    {
        public static HttpClient httpClient = new HttpClient();
        //constructeur
        static GlobaleVariables() 
        {
            httpClient.BaseAddress = new Uri("https://localhost:44303/api/");
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

    }
}
