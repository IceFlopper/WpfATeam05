using Microsoft.AspNetCore.Mvc;
using ClassLibTeam05.Business.Entities;
using ClassLibTeam05.Data.Repositories;
using System.Collections.Generic;
using ClassLibTeam05.Data;
using ClassLibRentStrumentTeam05.Data.Framework;
using ClassLibTeam05.Business;
using Newtonsoft.Json;

namespace WebApiTeam05.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetCars()
        {
            Cars cars = new Cars();
            return Ok(JsonConvert.SerializeObject(cars.Get()));
        }

        [HttpPost]
        public ActionResult AddCar([FromBody] Car car)
        {

            Cars cars = new Cars();
            return Ok(cars.Add(car.Make, car.Model, car.Year, car.Price));
        }
    }
}
