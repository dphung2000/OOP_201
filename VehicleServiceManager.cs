using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    class VehicleServiceManager : IVehicleService

    {
        public RentSystem _rentSys;
        public VehicleServiceManager(RentSystem rentSys)
        {
            _rentSys = rentSys;
        }
        public bool addVehicleInsurance(int ID, int inFee, string inCompany, DateTime efDay, DateTime exDay)
        {
            return true;
        }

        public bool printServiceFleet()
        {
            /* 
             console.writeline("ServiceFleet:{0}",)
             */
            Console.WriteLine("printServiceFleet call, Servicefleet will print");
            return false;
        }

        public void serviceFleet()
        {
            Console.WriteLine("them vao danh sach bao duong");
           /* LinkedListNode<Vehicle> node = listOfVehicle.First;
            while (node != null)
            {
                node.Value.serviceEngine();
                node.Value.serviceTransmission();
                node.Value.serviceTires(); 
             }   
             */           
        }
    }
}
