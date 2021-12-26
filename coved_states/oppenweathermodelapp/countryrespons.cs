using coved_states.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coved_states.oppenweathermodelapp
{
    public class countryrespons
    {
        
        public string messages { get; set; }

        //public globl NewConfirmed { get; set; }
        //public globl TotalConfirmed { get; set; }
        //public globl NewDeaths { get; set; }
        //public globl TotalDeaths { get; set; }
        //public globl NewRecovered { get; set; }
        //public globl TotalRecovered { get; set; }
        



        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }
        public string date { get; set; }
        public string id { get; set; }
        public List<globl> globels { get; set; }
        public  List< Countrys >countries { get; set; }
       

    }
}
