using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    class CustomerManager: ICustomer {
        public RentSystem _rentSys;

        public CustomerManager(RentSystem rentSystem) {
            _rentSys = rentSystem;
        }
        public bool AddCustomer(bool hasLicense, string customerName, int customerAge, string customerAddress) {
            _rentSys.AddCustomer(hasLicense, customerName, customerAge, customerAddress);
            return true;
        }
        public bool AddCustomerToContract(int customerID, int contractID)
        {
            return _rentSys.AddCustomerToContract(customerID, contractID);
        }
        public bool RemoveCustomer(int customerID) {
            return _rentSys.RemoveCustomer(customerID);
        }
        public bool RemoveCustomerFromContract(int customerID, int contractID)
        {
            return _rentSys.RemoveCustomerFromContract(customerID, contractID);
        }
    }
}
