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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICars" in both code and config file together.
    [ServiceContract]
    public interface ICars
    {
        [OperationContract]
        List<Car> ListCars(CarRequest Request);

        [OperationContract]
        Car CreateCar(Car Entyity);

        [OperationContract]
        Car GetCar(int CardId);

        [OperationContract]
        Car UpdateCar(Car Entyity);

        [OperationContract]
        Car DeleteCar(int CardId);
    }
}
