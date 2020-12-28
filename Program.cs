using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    enum carT
    {
        PickupTruck = 0, Sedan = 1, SportsCar = 2
    }
    class Program
    {
        static void Main()
        {
            RentSystem rentsys = new RentSystem();
            IRent example = rentsys;
            IVehicleService example1 = new VehicleServiceManager(rentsys);
            ICustomer example2 = new CustomerManager(rentsys);
            example.AddCar(0 , 100, "BMW", 1000, 10);
            example.AddCar(1, 200, "KIA", 0, 20);
            example.AddCar(2, 999, "local", 0, 1000);
            example.AddContract(new DateTime(2020, 12, 31),new DateTime(1999, 01, 01));
            example.AddCarToContract(1, 0);
            example.RemoveCarFromContract(1, 0);
            example.RemoveCar(2);
            //example.AddCustomer(true, "John Dyr", 10, "173 Bui Vien"); //cái này PHẢI BỊ LỖI khi gỡ dấu //
            example2.AddCustomer(true, "John Dyr", 10, "173 Bui Vien");
            example2.AddCustomer(false, "Odinson", 59, "53 Wall Str.");
            example2.AddCustomer(true, "Imma die soon", 99, "Unknown");
            example2.RemoveCustomer(2);
            example2.AddCustomerToContract(1, 0);
            example2.AddCustomerToContract(1, 0);
            example2.RemoveCustomerFromContract(1, 0);
            example2.AddCustomerToContract(1, 0);

        }
    }
}
