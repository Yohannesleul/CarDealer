using CarDealership.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealership.Data
{
    public class SampleData
    {
        public static void Intialize(IApplicationBuilder app)
        {
            using (var service = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = service.ServiceProvider.GetService<CarContext>();
                context.Database.EnsureCreated();

                //Check if Car is already created
                if (context.cars != null && context.cars.Any())
                {
                    return;
                }

                var cars = GetCars().ToArray();
                context.cars.AddRange(cars);
                context.SaveChanges();
            }
        }
        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>()
            {
                new Car {
    _id= "59d2698c2eaefb1268b69ee5",
    Make= "Chevy",
    Year= 2016,
    Color= "Gray",
    Price= 16106,
    HasSunRoof= false,
    IsFourWheelDrive= true,
    HasLowMiles= true,
    HasPowerWindws= false,
    HasNavigation= true,
    HasHeatedSeat= false},
                new Car {
    _id= "59d2698c05889e0b23959106",
    Make= "Toyota",
    Year= 2012,
    Color= "Silver",
    Price= 18696,
    HasSunRoof= true,
    IsFourWheelDrive= true,
    HasLowMiles= false,
    HasPowerWindws= true,
    HasNavigation= false,
    HasHeatedSeat= true},
            new Car
            {
                _id = "59d2698c6f1dc2cbec89c413",
                Make = "Mercedes",
                Year = 2016,
                Color = "Black",
                Price = 18390,
                HasSunRoof = true,
                IsFourWheelDrive = false,
                HasLowMiles = false,
                HasPowerWindws = true,
                HasNavigation = true,
                HasHeatedSeat = false
            },
            new Car
            {
                _id = "59d2698c340f2728382c0a73",
                Make = "Toyota",
                Year = 2015,
                Color = "White",
                Price = 15895,
                HasSunRoof = true,
                IsFourWheelDrive = false,
                HasLowMiles = true,
                HasPowerWindws = true,
                HasNavigation = false,
                HasHeatedSeat = true
            },
            new Car
            {
                _id = "59d2698cba9b82c2347cd13a",
                Make = "Ford",
                Year = 2014,
                Color = "Gray",
                Price = 19710,
                HasSunRoof = false,
                IsFourWheelDrive = true,
                HasLowMiles = false,
                HasPowerWindws = false,
                HasNavigation = true,
                HasHeatedSeat = true
            },
            new Car
            {
                _id = "59d2698ce2e7eeeb4f109001",
                Make = "Toyota",
                Year = 2014,
                Color = "Red",
                Price = 19248,
                HasSunRoof = true,
                IsFourWheelDrive = false,
                HasLowMiles = true,
                HasPowerWindws = true,
                HasNavigation = true,
                HasHeatedSeat = true
            },
            new Car
            {
                _id = "59d2698cd6a3b8f0dd994c9d",
                Make = "Toyota",
                Year = 2015,
                Color = "Black",
                Price = 13170,
                HasSunRoof = true,
                IsFourWheelDrive = false,
                HasLowMiles = true,
                HasPowerWindws = true,
                HasNavigation = false,
                HasHeatedSeat = false
            },
            new Car
            {
                _id = "59d2698c86ab54cee8acdc7b",
                Make = "Mercedes",
                Year = 2013,
                Color = "Gray",
                Price = 15669,
                HasSunRoof = false,
                IsFourWheelDrive = false,
                HasLowMiles = true,
                HasPowerWindws = false,
                HasNavigation = false,
                HasHeatedSeat = false
            },
             new Car
            {
                _id = "59d2698cda9e8d39476c678a",
                Make = "Toyota",
                Year = 2015,
                Color = "White",
                Price = 16629,
                HasSunRoof = false,
                IsFourWheelDrive = false,
                HasLowMiles = true,
                HasPowerWindws = false,
                HasNavigation = false,
                HasHeatedSeat = true
            },
        };

            return cars;
        }
    }
}
