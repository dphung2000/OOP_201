using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    interface IVehicleService
    {
        bool printServiceFleet();
        void serviceFleet();
        bool addVehicleInsurance(int ID, int inFee, string inCompany, DateTime efDay, DateTime exDay);
    }
}
