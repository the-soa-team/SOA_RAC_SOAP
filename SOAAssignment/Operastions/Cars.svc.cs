using SOAAssignment.Mocks;
using SOAAssignment.Models;
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

        public List<Car> ListCars()
        {
            return CarMock.ListCars();
        }

        public Car CreateCar()
        {
            throw new NotImplementedException();
        }

        public Car DeleteCar()
        {
            throw new NotImplementedException();
        }

        public Car GetCar()
        {
            throw new NotImplementedException();
        }

        public Car UpdateCar()
        {
            throw new NotImplementedException();
        }
    }
}
