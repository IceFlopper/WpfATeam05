using System.Collections.Generic;
using ClassLibTeam05.Business.Entities;
using ClassLibTeam05.Data.Repositories;

namespace ClassLibTeam05.Business
{
    public class Cars
    {
        private readonly CarRepository _carRepository;

        public Cars(CarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> List()
        {
            return _carRepository.GetAll();
        }

        public void Add(string make, string model, int year, decimal price)
        {
            Car car = new Car(make, model, year, price);
            _carRepository.Add(car);
        }
    }
}
