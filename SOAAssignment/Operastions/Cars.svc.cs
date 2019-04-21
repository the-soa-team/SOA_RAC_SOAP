using SOAAssignment.Mocks;
using SOAAssignment.Models;
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
            return CarMock.MultipleCars().ToArray();
        }

        public Car CreateCar(Car Entity)
        {
            return Entity;
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
    }
}
