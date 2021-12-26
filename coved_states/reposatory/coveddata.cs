using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using coved_states.Models;
using coved_states.oppenweathermodelapp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace coved_states.reposatory
{
    public class coveddata 
    {
        public countryrespons getcovedstates()
        {
            
            var clint = new RestClient($"https://api.covid19api.com/summary");
            clint.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse resopons = clint.Execute(request);
            if (resopons.IsSuccessful)
            {
                countryrespons contant = JsonConvert.DeserializeObject<countryrespons>(resopons.Content);
                //var contant = JsonConvert.DeserializeObject<JToken>(resopons.Content);
                return contant; 
            }
            else
            {
                return null;
            }
            
        }
    }
}
