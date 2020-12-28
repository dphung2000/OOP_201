using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class Customer {
        protected bool _isOnContract = false;
        protected bool _hasLicense;
        protected string _customerName;
        protected int   _customerAge;
        protected int   _customerID;
        protected string _customerAddress;
        public Customer() {
            this._hasLicense = false;
            this._customerName = this._customerAddress = "";
            this._customerID = this._customerAge = -1;
        }
        public Customer(int customerID) {
            this._hasLicense = false;
            this._customerName = this._customerAddress = "";
            this._customerAge = -1;
            this._customerID = customerID;
        }
        public Customer(bool hasLicense, string customerName, int customerAge, int customerID, string customerAddress) {
            this._hasLicense = hasLicense;
            this._customerAddress = customerAddress;
            this._customerName = customerName;
            this._customerID = customerID;
            this._customerAge = customerAge;
        }
        public int getID() { return _customerID; }
        public void setOnContractFlag(bool contractFlag) { _isOnContract = contractFlag; }
        public bool getOnContractFlag() { return _isOnContract; }
        public static bool operator==(Customer cus1, Customer cus2) {
            return cus1._customerID == cus2._customerID;
        }
        public static bool operator!=(Customer cus1, Customer cus2) {
            return cus1._customerID != cus2._customerID;
        }
    }
}
