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
    public class WeatherController1 : Controller
    {

        private readonly Wforcatreposa _repo;

        public WeatherController1(Wforcatreposa repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult searchbycity()
        {
            var viewmodel = new searchbycity();
            return View(viewmodel);
        }
            
        public IActionResult searchbycity(searchbycity model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("City", "WeatherController1", new { city = model.namecity });
            }
            return View(model);
            
        }

        public IActionResult City(string city)
        {
            weatherresponse wrespon = _repo.getforcast(city);
            Citys viewmodel = new Citys();
            if(wrespon != null)
            {
                viewmodel.name = wrespon.name;
                viewmodel.tempreture = wrespon.main.temp;
                viewmodel.humidity = wrespon.main.humidity;
                viewmodel.preassure = wrespon.main.pressure;
                viewmodel.weather = wrespon.weather[0].main;
                viewmodel.wind = wrespon.wind.speed;
               
            }
            return View(viewmodel);
        }
    }
}
