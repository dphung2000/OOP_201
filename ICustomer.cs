using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public interface ICustomer
    {
        bool AddCustomer(bool hasLicense, string customerName, int customerAge, string customerAddress);
        bool AddCustomerToContract(int customerID, int contractID);
        bool RemoveCustomer(int customerID);
        bool RemoveCustomerFromContract(int customerID, int contractID);
    }
}
