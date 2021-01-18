using Cars.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Data
{
    // DbContext Represents session with the DB
    public class CarManagerContext : DbContext
    {
       
        public CarManagerContext(DbContextOptions<CarManagerContext> dbContextOption) : base(dbContextOption)
        {
            //fillDb();
        }

        private void fillDb()
        {
            Employee e1 = new Employee()
            {
                FirstName = "Meni",
                LastName = "Toledano",
                EmployeeIdentifier = 12
            };
            Employee e3 = new Employee()
            {
                FirstName = "Shlomi",
                LastName = "Ifergan",
                EmployeeIdentifier = 12
            };
            Employee e2 = new Employee()
            {
                FirstName = "Tata",
                LastName = "Nicjy",
                EmployeeIdentifier = 12
            };
            CarType ct1 = new CarType
            {
                TypeName = "Truck"
            };
            CarType ct2 = new CarType
            {
                TypeName = "Car"
            };
            CarType ct3 = new CarType
            {
                TypeName = "Motorcycle"
            };
            CarType ct4 = new CarType
            {
                TypeName = "Bus"
            };
            Car c1 = new Car
            {
                InternalId = "12234345",
                PlateNumber = "1234",
                FourOnFour = true,
                EngineVolume = 2800,
                YearOfManufacture = 2020,
                Comments = "None",
                EmployeeIdentifier = 12,
                CarTypeId = 1,
                CarCareDate = DateTime.Now,
                LastModified = DateTime.Now
            };
            Car c2 = new Car
            {
                InternalId = "12234345",
                PlateNumber = "1242353245",
                FourOnFour = false,
                EngineVolume = 2800,
                YearOfManufacture = 2020,
                Comments = "None",
                EmployeeIdentifier = 12,
                CarTypeId = 2,
                CarCareDate = DateTime.Now,
                LastModified = DateTime.Now
            };
            Car c3 = new Car
            {
                InternalId = "12234345",
                PlateNumber = "1242353245",
                FourOnFour = true,
                EngineVolume = 2800,
                YearOfManufacture = 2020,
                Comments = "None",
                EmployeeIdentifier = 12,
                CarTypeId = 1,
                CarCareDate = DateTime.Now,
                LastModified = DateTime.Now
            };
            this.Cars.Add(c1);
            this.Cars.Add(c2);
            this.Cars.Add(c3);
            this.CarTypes.Add(ct1);
            this.CarTypes.Add(ct2);
            this.CarTypes.Add(ct3);
            this.CarTypes.Add(ct4);
            this.Employees.Add(e1);
            this.Employees.Add(e2);
            this.Employees.Add(e3);
            this.SaveChanges();
        }



        // each DB set represents the table we create in DB
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //            modelBuilder.Entity<Car>(cb =>
            //            {
            //                cb.OwnsOne(
            //                    c => c.Employee,
            //                    e =>
            //                    {
            //                        e.Property(p => p.FirstName).IsRequired();
            //                        e.Property(p => p.LastName).IsRequired();
            //                    });
            //            });
            //}

        }

    
    }
}

