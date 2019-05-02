using RentACar.Bll.Concretes;
using SOAAssignment.Mocks;
using SOAAssignment.Models;
using BLLModels = RentACar.Model.EntityModels;
using SOAAssignment.RequestObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SOAAssignment.Operastions
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Cars" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Cars.svc or Cars.svc.cs at the Solution Explorer and start debugging.
    public class Cars : ICars
    {

        public Car[] ListCars(CarRequest Request = null)
        {
            try
            {
                using (var CarManager = new CarManager())
                {
                    List<BLLModels.Cars> newEntities = CarManager.SelectAll();

                    List<Car> ReturnCars = new List<Car>();
                    foreach(BLLModels.Cars newEntity in newEntities)
                    {
                        ReturnCars.Add(new Car()
                        {
                            ID = newEntity.CarID,
                            CompanyId = newEntity.CompanyID.Value,
                            Brand = newEntity.Brand,
                            Model = newEntity.Model,
                            CurrentKm = newEntity.CurrentKm.Value,
                            DailyMaxKm = newEntity.DailyKm.Value,
                            DriverAge = newEntity.CarDriverAge.Value,
                            LicenceAge = newEntity.CarLicenceAge.Value,
                            HasAirBag = newEntity.HasAirbag.Value ? Enums.AirgBagEnum.Yes : Enums.AirgBagEnum.No,
                            LuggageVolume = newEntity.LuggageValume.Value,
                            NumSeats = newEntity.NumSeats.Value,
                            RentPrice = newEntity.RentPrice.Value
                        });
                    }

                    return ReturnCars.ToArray();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Car CreateCar(Car Entity)
        {

            try
            {
                using (var CarManager = new CarManager())
                {
                    BLLModels.Cars entity = new BLLModels.Cars();
                    var newEntity = CarManager.Insert(entity);
                    
                    return new Car()
                    {
                        ID = newEntity.CarID,
                        CompanyId = newEntity.CompanyID.Value,
                        Brand = newEntity.Brand,
                        Model = newEntity.Model,
                        CurrentKm = newEntity.CurrentKm.Value,
                        DailyMaxKm = newEntity.DailyKm.Value,
                        DriverAge = newEntity.CarDriverAge.Value,
                        LicenceAge = newEntity.CarLicenceAge.Value,
                        HasAirBag = newEntity.HasAirbag.Value ? Enums.AirgBagEnum.Yes : Enums.AirgBagEnum.No,
                        LuggageVolume = newEntity.LuggageValume.Value,
                        NumSeats = newEntity.NumSeats.Value,
                        RentPrice = newEntity.RentPrice.Value
                    };
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Car DeleteCar(int CardId)
        {
            return CarMock.SingleCar();
        }

        public Car GetCar(int CardId)
        {
            return CarMock.SingleCar();
        }

        public Car UpdateCar(Car Entity)
        {
            return Entity;
        }

        public Car[] ListAvailableCars(AviableCarRequest Request = null)
        {
            return CarMock.MultipleCars().ToArray();
        }
    }
}
