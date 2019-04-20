using SOAAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Mocks
{
    public static class CarMock
    {

        public static List<Car> ListCars() {

            List<Car> Cars = new List<Car>();

            Car Car;

            Car = new Car
            {
                Brand = "Mercedes",
                Model = "CLS 300",
                LicenceAge = 3,
                DriverAge = 25,
                CurrentKm = 78000,
                DailyMaxKm = 250,
                HasAirBag = true,
                LuggageVolume = 550,
                NumSeats = 4,
                RentPrice = 250
            };
            Cars.Add(Car);

            Car = new Car
            {
                Brand = "BMW",
                Model = "315",
                LicenceAge = 2,
                DriverAge = 23,
                CurrentKm = 90000,
                DailyMaxKm = 240,
                HasAirBag = true,
                LuggageVolume = 350,
                NumSeats = 5,
                RentPrice = 220
            };
            Cars.Add(Car);

            return Cars;
        }

    }
}