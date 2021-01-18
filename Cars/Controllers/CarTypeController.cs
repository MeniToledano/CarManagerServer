using Cars.Data;
using Cars.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarTypeController : Controller
    {
        private readonly CarManagerContext _carManagerContext;

        public CarTypeController(CarManagerContext carManagerContext)
        {
            _carManagerContext = carManagerContext;
        }

        // GET: local/cartype
        [HttpGet]
        public IEnumerable<CarType> GetAllTypes()
        {
            return _carManagerContext.CarTypes;
        }

        // GET: local/cartype/2
        [HttpGet("{id}")]
        public CarType GetTypeById(int id)
        {
            return _carManagerContext.CarTypes.SingleOrDefault(x => x.TypeId == id);
        }


    }
}
