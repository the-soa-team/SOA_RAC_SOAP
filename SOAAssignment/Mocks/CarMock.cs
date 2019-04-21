using SOAAssignment.Enums;
using SOAAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAAssignment.Mocks
{
    public static class CarMock
    {

        public static List<Car> MultipleCars()
        {

            List<Car> Cars = new List<Car>();

            Car Car;

            Car = new Car
            {
                ID = 1,
                Brand = "Mercedes",
                Model = "CLS 300",
                LicenceAge = 3,
                DriverAge = 25,
                CurrentKm = 78000,
                DailyMaxKm = 250,
                HasAirBag = AirgBagEnum.Yes,
                LuggageVolume = 550,
                NumSeats = 4,
                RentPrice = 250
            };
            Cars.Add(Car);

            Car = new Car
            {
                ID = 2,
                Brand = "BMW",
                Model = "315",
                LicenceAge = 2,
                DriverAge = 23,
                CurrentKm = 90000,
                DailyMaxKm = 240,
                HasAirBag = AirgBagEnum.Yes,
                LuggageVolume = 350,
                NumSeats = 5,
                RentPrice = 220
            };
            Cars.Add(Car);

            return Cars;
        }

        public static Car SingleCar()
        {
            return new Car
            {
                ID = 1,
                Brand = "BMW",
                Model = "315",
                LicenceAge = 2,
                DriverAge = 23,
                CurrentKm = 90000,
                DailyMaxKm = 240,
                HasAirBag = AirgBagEnum.Yes,
                LuggageVolume = 350,
                NumSeats = 5,
                RentPrice = 220
            }; ;
        }

    }
}