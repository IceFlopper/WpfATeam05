using Microsoft.AspNetCore.Mvc;
using ClassLibTeam05.Business.Entities;
using ClassLibTeam05; 

namespace WebApiTeam05.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly CarRepository _carRepository;

        public CarController(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Car>> GetCars()
        {
            var cars = _carRepository.GetAll(); // Use the injected CarRepository to get all cars
            return Ok(cars);
        }

        [HttpPost]
        public ActionResult<Car> AddCar([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest();
            }

            _carRepository.Add(car); // Use the injected CarRepository to add a new car
            return CreatedAtAction(nameof(GetCars), car);
        }
    }
}
