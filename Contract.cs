using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class Contract {
        protected int _contractID;
        protected LinkedList<Customer> _customer = null; // use linkedlist because AddLast can deep copy it
        protected LinkedList<Vehicle> _listOfVehicle = new LinkedList<Vehicle>();  
        protected DateTime _startDate = default(DateTime);
        protected DateTime _endDate = default(DateTime);  
        public Receipt _contractReceipt;
        public int getID() { return this._contractID; }
        public Contract(int contractID, DateTime startDate, DateTime endDate = default(DateTime)) {
            this._contractID = contractID;
            this._startDate = startDate;
            this._endDate = endDate;
        }
        public void makeReceipt() {
            //_contractReceipt = new Receipt(_customer, _listOfVehicle, _endDate.Subtract(_startDate));
        }
        public Receipt end () {
            if (_endDate == null) this._endDate = new DateTime();
            makeReceipt();
            return this._contractReceipt;
        }
        public void extendContract(DateTime endDate) {
            if (endDate > _startDate) 
                this._endDate = endDate;
        }
        public static bool operator==(Contract ctr1, Contract ctr2) {
            return ctr1._contractID == ctr2._contractID;
        }
        public static bool operator!=(Contract ctr1, Contract ctr2) {
            return ctr1._contractID != ctr2._contractID;
        }
        public void AddCar(Vehicle vehicle)
        {
            _listOfVehicle.AddLast(vehicle);
        }
        public void RemoveCar(Vehicle vehicle)
        {
            if (_listOfVehicle.Remove(vehicle))
            {
                Console.WriteLine("Successfully removed a vehicle from a contract");
                return;
            }
            Console.WriteLine("Vehicle not found in this contract (BUG)");
        }
        public int GetCustomerID()
        {
            if (_customer.Equals(null))
            {
                return -1;
            }
            return _customer.First.Value.getID();
        }
        public bool SetCustomer(Customer customer)
        {
            if (_customer == null)
            {
                if (!(customer is null)) // if you use "customer != null" instead it will raise an error
                {
                    _customer = new LinkedList<Customer>();
                    _customer.AddFirst(customer);
                    Console.WriteLine("Added a customer to a contract successfully");
                    return true;
                }
                else
                {
                    Console.WriteLine("Removing a customer from a contract that doesn't have a customer");
                    return false;
                }
            }
            else
            {
                if (!(customer is null)) // if you use "customer != null" instead it will raise an error
                {
                    Console.WriteLine("Already has a customer");
                    return false;
                } else
                {
                    _customer = null;
                    Console.WriteLine("Removed a customer from a contract successfully");
                    return true;
                }
            }
        }
    }
}
