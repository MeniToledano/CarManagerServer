using Cars.Data;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        private readonly CarManagerContext _carManagerContext;

        public CarController(CarManagerContext carManagerContext)
        {
            _carManagerContext = carManagerContext;
        }

        [HttpGet]
        public IEnumerable<Car> GetFiltteredCars([FromQuery] string platenumber = null, [FromQuery] bool fouronfour = false, [FromQuery] int cartype = -1)
        {
            if (platenumber != null)
            {

                return this._carManagerContext.Cars
                    .Where(c => c.PlateNumber == platenumber)
                    .ToArray();
            }
            if (fouronfour == true)
            {
                return _carManagerContext.Cars
                    .Where(e => e.FourOnFour == true)
                    .ToArray();
            }

            if (cartype != -1)
            {
                return _carManagerContext.Cars
                    .Where(e => e.CarTypeId == cartype)
                    .ToArray();
            }

            return _carManagerContext.Cars.ToArray();


        }

        [HttpDelete("{id}")]
        public IEnumerable<Car> DeleteCarById(int id)
        {
            Car car = _carManagerContext.Cars.Find(id);
            _carManagerContext.Cars.Remove(car);
            _carManagerContext.SaveChanges();
            return _carManagerContext.Cars;

        }

        [HttpPost]
        public IEnumerable<Car> PostNewCar(Car car)

        {

            _carManagerContext.Cars.Add(car);
            _carManagerContext.SaveChanges();
            return _carManagerContext.Cars;

        }


        [HttpPut("{id}")]
        public IEnumerable<Car> ModifyCar(Car car)
        {
            _carManagerContext.Entry(car).State = EntityState.Modified;
            _carManagerContext.SaveChanges();
            return _carManagerContext.Cars;

        }
    }
}
