using coved_states.Models;
using coved_states.oppenweathermodelapp;
using coved_states.reposatory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coved_states.Controllers
{
    public class CovedController : Controller
    {
        private readonly coveddata _cov;

        public CovedController(coveddata cov)
        {
            _cov = cov;
        }
        public IActionResult Index()
        {
            countryrespons countryx = _cov.getcovedstates();
            countryrespons viewmodel = new countryrespons();
            globl viewmodel2 = new globl();
            // Console.WriteLine(countryx);
            //ViewBag.lenth = countryx.countries.Count(); countryx.Country="Egypt"
            //for (int i=0;i<50; i++) { 
            if (countryx != null)
            {
                viewmodel.id = countryx.id;
                //viewmodel.countryname = countryx.countries.FirstOrDefault().countryname;
                //viewmodel2.NewDeaths = countryx.globels[0].NewDeaths;
                viewmodel.Country = countryx.countries[51].Country;
                viewmodel.CountryCode = countryx.countries[51].CountryCode;
                viewmodel.Slug = countryx.countries[51].Slug;
                //viewmodel.NewConfirmed = countryx.countries.NewConfirmed;
                viewmodel.TotalConfirmed = countryx.countries[51].TotalConfirmed;
               // viewmodel.NewDeaths = countryx.countries.FirstOrDefault().NewDeaths;
                viewmodel.NewDeaths = countryx.countries[51].NewDeaths;
                viewmodel.TotalDeaths = countryx.countries[51].TotalDeaths;
                //viewmodel.NewRecovered = countryx.countries.NewRecovered;
                //viewmodel.TotalRecovered = countryx.countries.TotalRecovered;
                viewmodel.date = countryx.countries[51].date;


                 
                }

            //}
            return View(viewmodel);
            
        }
    }
}
