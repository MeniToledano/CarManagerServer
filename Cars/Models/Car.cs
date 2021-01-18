using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        public string InternalId { get; set; }
        [Required]
        public string PlateNumber { get; set; }
        [Required]
        public int CarTypeId { get; set; }
        //public CarType CarType { get; set; }
        [Required]
        public bool FourOnFour { get; set; }
        public int EngineVolume { get; set; }
        [Required]
        public int YearOfManufacture { get; set; }
        public string Comments { get; set; }
        public int EmployeeIdentifier { get; set; }
     //   public Employee Employee { get; set; }
        [Required]
        public DateTime CarCareDate { get; set; }
        [Required]
        public DateTime LastModified { get; set; }

    }
}
