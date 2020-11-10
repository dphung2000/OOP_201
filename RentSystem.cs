using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    class RentSystem : IRent
    {

        public void serviceFleet() { 
        /*
        runs through 3 functions
         */
        }
        public int AddCar(string type, int rentCost, bool insurance)
        {
            int id = 0;
            Console.WriteLine("AddCar called, returns car id");
            return id;
        }

        public int AddContract(string name)
        {
            int id = 0;
            Console.WriteLine("AddContract called, return contract id");
            return id;
        }
        public bool AddCarToContract(int carID, int contractID)
        {
            Console.WriteLine("AddCarToContract called, Car added to a contract");
            return false;
        }
        public bool RemoveCar(int carID)
        {
            Console.WriteLine("RemoveCar called, Car found and is not under any contract, so it is removed");
            return true;
        }
        public bool EndContract(int contractID)
        {
            Console.WriteLine("EndContract called");
            return true;
        }
    }
}
