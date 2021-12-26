using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coved_states.oppenweathermodelapp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace coved_states.reposatory
{
    public class Wforcatreposa : IWforcastrepo
    {
        public weatherresponse getforcast(string city)
        {
            string app_id = configration.values.OPPEN_WEATHER_APP_ID;
            var clint = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={app_id}");
            var request = new RestRequest(Method.GET);
            IRestResponse resopons = clint.Execute(request);
            if (resopons.IsSuccessful)
            {
                var contant = JsonConvert.DeserializeObject<JToken>(resopons.Content);
                return contant? .ToObject<weatherresponse>();
            }
            else
            {
                return null;
            }
            
        }
    }
}
