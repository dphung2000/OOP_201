using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    interface IRent
    {
        int AddCar(string type, int rentCost, bool insurance);
        int AddContract(string name);
        bool AddCarToContract(int carID, int contractID);
        bool RemoveCar(int carID);
        bool EndContract(int contractID); 
    }
}
