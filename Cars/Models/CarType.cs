using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class CarType
    {
        [Key]
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        //public int CarTypeForeignKey { get; set; }
       // public Car Car { get; set; }
    }
}
