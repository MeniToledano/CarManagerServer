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
        public IEnumerable<Car> GetFiltteredCars([FromQuery] string platenumber = null, [FromQuery] Boolean fouronfour = false, [FromQuery] int cartype = -1)
        {
            if ( platenumber != null)
            {
             
                return this._carManagerContext.Cars
                    .Where(c => c.PlateNumber == platenumber)
                    .ToArray();
            }
            // 4X4 and specific car type
            if (fouronfour == true && cartype != -1)
            {
                return _carManagerContext.Cars
                    .Where(e => e.FourOnFour == true)
                    .Where(e => e.CarTypeId == cartype)
                    .ToArray(); 
                // not 4X4 specific car type
            }else if(fouronfour == false && cartype != -1) 
            {
                return _carManagerContext.Cars
                    .Where(e => e.CarTypeId == cartype)
                    .Where(e => e.FourOnFour == false)
                    .ToArray();
            }else if(fouronfour == true && cartype == -1)
            {
                return _carManagerContext.Cars
                    .Where(e => e.FourOnFour == true)
                    .ToArray();
            }else   {
                return _carManagerContext.Cars.ToArray();
            }

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
