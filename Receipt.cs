using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    public class Receipt {
        protected Customer _customer;
        protected LinkedList<Vehicle> _listOfVehicle;
        protected double _cost = 0;
        protected int _dayRent;

        public Receipt(Customer customer, LinkedList<Vehicle> listOfVehicle, TimeSpan dayRent) {
            this._customer = customer;
            this._dayRent = int.Parse(dayRent.Days.ToString());
            this._listOfVehicle = listOfVehicle;
            LinkedListNode<Vehicle> node = listOfVehicle.First;
            while (node != null)
            {
                this._cost = this._cost + node.Value.getCost() * this._dayRent;
                node = node.Next;
            }
            Console.WriteLine("Contract's cost is " + this._cost);
        }
	}
}
