using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        //public int EmployeeForeignKey { get; set; }
        public string LastName { get; set; }
        public int EmployeeIdentifier { get; set; }
        //public Car Car { get; set; }

    }
}
