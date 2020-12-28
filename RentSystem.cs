using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    class RentSystem : IRent
    {
        private LinkedList<Contract> _contractList = new LinkedList<Contract>();
        private LinkedList<Vehicle> _vehiclesList = new LinkedList<Vehicle>();
        private LinkedList<Customer> _customersList = new LinkedList<Customer>();
        public int AddCar(int carType, int rentCost, String brand, int runningDistance, int specificProperty)
        {
            int id = 0;
            //iterate through linked list
            Console.WriteLine("Size of vehicle list is: " + _vehiclesList.Count);
            while(true)
            {
                LinkedListNode<Vehicle> iter = _vehiclesList.First;
                bool isValid = true;
                while (iter != null) //check id of all existing vehicles
                {
                    if (iter.Value.getID() == id)
                    {
                        isValid = false;
                        break;
                    }
                    iter = iter.Next;
                }
                if (!isValid)
                {
                    id++;
                } else
                {
                    switch (carType)
                    {
                        case 0:
                            _vehiclesList.AddLast(new PickupTruck(id, false, rentCost, brand, runningDistance, specificProperty));
                            Console.WriteLine("Added a pickup truck");
                            break;
                        case 1:
                            _vehiclesList.AddLast(new Sedan(id, false, rentCost, brand, runningDistance, specificProperty));
                            Console.WriteLine("Added a sedan");
                            break;
                        case 2:
                            _vehiclesList.AddLast(new SportsCar(id, false, rentCost, brand, runningDistance, specificProperty));
                            Console.WriteLine("Added a sports car");
                            break;
                        default:
                            Console.WriteLine("Wrong vehicle type!");
                            return -1;
                    }
                    return id;
                }
            }
        }
        public bool SetCar(int ID, String type, int rentCost, bool insurance)
        {
            return true;
        }

        public int AddContract(DateTime startDate, DateTime endDate = default(DateTime))
        {
            int id = 0;
            while (true)
            {
                LinkedListNode<Contract> iter = _contractList.First;
                bool isValid = true;
                while (iter != null) //check id of all existing contracts
                {
                    if (iter.Value.getID() == id)
                    {
                        isValid = false;
                        break;
                    }
                    iter = iter.Next;
                }
                if (!isValid)
                {
                    id++;
                }
                else
                {
                    _contractList.AddLast(new Contract(id, startDate, endDate));
                    Console.WriteLine("Created a contract with no car nor person attached, date " + endDate.ToString("dd/MM/yyyy") + " and ID " + id);
                    return id;
                }
            }
        }
        public bool AddCarToContract(int carID, int contractID)
        {
            LinkedListNode<Vehicle> vehicleTemp = _vehiclesList.First;
            LinkedListNode<Contract> contractTemp = _contractList.First;
            while (vehicleTemp != null)
            {
                if (vehicleTemp.Value.getID() == carID)
                {
                    break;
                }
                else
                {
                    vehicleTemp = vehicleTemp.Next;
                }
            }
            if (vehicleTemp == null)
            {
                Console.WriteLine("Car with that ID not found");
                return false;
            }
            if (vehicleTemp.Value.getOnContractFlag())
            {
                Console.WriteLine("Car with that ID is already on a contract");
                return false;
            }
            while (contractTemp != null)
            {
                if (contractTemp.Value.getID() == contractID)
                {
                    break;
                }
                else
                {
                    contractTemp = contractTemp.Next;
                }
            }
            if (contractTemp == null)
            {
                Console.WriteLine("Contract with that ID not found");
                return false;
            }
            vehicleTemp.Value.setOnContractFlag(true);
            Console.WriteLine(contractTemp.Value);
            contractTemp.Value.AddCar(vehicleTemp.Value);
            Console.WriteLine("AddCarToContract called, Car added to a contract");
            return false;
        }
        public bool RemoveCar(int carID)
        {
            LinkedListNode<Vehicle> vehicleTemp = _vehiclesList.First;
            while (vehicleTemp != null)
            {
                //Console.WriteLine("In");
                if (carID == vehicleTemp.Value.getID())
                {
                    //Console.WriteLine(vehicleTemp.Value.getID());
                    if (vehicleTemp.Value.getOnContractFlag())
                    {
                        Console.WriteLine("Car is on a contract, can't be removed, list size is now " + _vehiclesList.Count);
                        return false;
                    }
                    _vehiclesList.Remove(vehicleTemp.Value);
                    Console.WriteLine("Car has been removed, list size is now " + _vehiclesList.Count);
                    return true;
                }
                else
                {
                    vehicleTemp = vehicleTemp.Next;
                }
            }
            Console.WriteLine("Invalid car ID");
            return false;
        }
        public bool RemoveContract(int contractID)
        {
            LinkedListNode<Contract> contractTemp = _contractList.First;
            while (contractTemp != null)
            {
                if (contractTemp.Value.getID() == contractID)
                {
                    _contractList.Remove(contractTemp.Value);
                    Console.WriteLine("Contract ended");
                    return true;
                }
                else
                {
                    contractTemp = contractTemp.Next;
                }
            }
            Console.WriteLine("Invalid contract ID");
            return true;
        }
        public bool RemoveCarFromContract(int carID, int contractID)
        {
            LinkedListNode<Vehicle> vehicleTemp = _vehiclesList.First;
            LinkedListNode<Contract> contractTemp = _contractList.First;
            while (vehicleTemp != null)
            {
                if (vehicleTemp.Value.getID() == carID)
                {
                    break;
                }
                else
                {
                    vehicleTemp = vehicleTemp.Next;
                }
            }
            if (vehicleTemp == null)
            {
                Console.WriteLine("Car with that ID not found");
                return false;
            }
            if (vehicleTemp.Value.getOnContractFlag() == false)
            {
                Console.WriteLine("Car with that ID is not on a contract");
                return false;
            }
            while (contractTemp != null)
            {
                if (contractTemp.Value.getID() == contractID)
                {
                    break;
                }
                else
                {
                    contractTemp = contractTemp.Next;
                }
            }
            if (contractTemp == null)
            {
                Console.WriteLine("Contract with that ID not found");
                return false;
            }
            vehicleTemp.Value.setOnContractFlag(false);
            contractTemp.Value.RemoveCar(vehicleTemp.Value);
            return true;
        }
        public int AddCustomer(bool hasLicense, string customerName, int customerAge, string customerAddress)
        {
            int id = 0;
            while (true)
            {
                LinkedListNode<Customer> iter = _customersList.First;
                bool isValid = true;
                while (iter != null) //check id of all existing contracts
                {
                    if (iter.Value.getID() == id)
                    {
                        isValid = false;
                        break;
                    }
                    iter = iter.Next;
                }
                if (!isValid)
                {
                    id++;
                }
                else
                {
                    _customersList.AddLast(new Customer(hasLicense, customerName, customerAge, id, customerAddress));
                    Console.WriteLine("Created a customer whose name's "+ customerName +", ID " + id);
                    return id;
                }
            }
        }
        public bool RemoveCustomer(int customerID)
        {
            LinkedListNode<Customer> customerTemp = _customersList.First;
            while (customerTemp != null)
            {
                //Console.WriteLine("In");
                if (customerID == customerTemp.Value.getID())
                {
                    //Console.WriteLine(customerTemp.Value.getID());
                    if (customerTemp.Value.getOnContractFlag())
                    {
                        Console.WriteLine("Customer is on a contract, can't be removed, list size is now " + _vehiclesList.Count);
                        return false;
                    }
                    _customersList.Remove(customerTemp.Value);
                    Console.WriteLine("Customer has been removed, list size is now " + _vehiclesList.Count);
                    return true;
                }
                else
                {
                    customerTemp = customerTemp.Next;
                }
            }
            Console.WriteLine("Invalid customer ID");
            return false;
        }
        public bool AddCustomerToContract(int customerID, int contractID)
        {
            LinkedListNode<Customer> customerTemp = _customersList.First;
            LinkedListNode<Contract> contractTemp = _contractList.First;
            while (customerTemp != null)
            {
                if (customerTemp.Value.getID() == customerID)
                {
                    break;
                }
                else
                {
                    customerTemp = customerTemp.Next;
                }
            }
            if (customerTemp == null)
            {
                Console.WriteLine("Customer with that ID not found");
                return false;
            }
            if (customerTemp.Value.getOnContractFlag())
            {
                Console.WriteLine("Customer with that ID is already on a contract");
                return false;
            }
            while (contractTemp != null)
            {
                if (contractTemp.Value.getID() == contractID)
                {
                    break;
                }
                else
                {
                    contractTemp = contractTemp.Next;
                }
            }
            if (contractTemp == null)
            {
                Console.WriteLine("Contract with that ID not found");
                return false;
            }
            customerTemp.Value.setOnContractFlag(true);
            //Console.WriteLine(contractTemp.Value);
            contractTemp.Value.SetCustomer(customerTemp.Value);
            return true;
        }
        public bool RemoveCustomerFromContract(int customerID, int contractID)
        {
            LinkedListNode<Customer> customerTemp = _customersList.First;
            LinkedListNode<Contract> contractTemp = _contractList.First;
            while (!customerTemp.Equals(null))
            {
                if (customerTemp.Value.getID() == customerID)
                {
                    break;
                }
                else
                {
                    customerTemp = customerTemp.Next;
                }
            }
            if (customerTemp.Equals(null))
            {
                Console.WriteLine("Customer with that ID not found");
                return false;
            }
            if (customerTemp.Value.getOnContractFlag() == false)
            {
                Console.WriteLine("Customer with that ID is not on a contract");
                return false;
            }
            while (!contractTemp.Equals(null))
            {
                if (contractTemp.Value.getID() == contractID)
                {
                    break;
                }
                else
                {
                    contractTemp = contractTemp.Next;
                }
            }
            if (contractTemp.Equals(null))
            {
                Console.WriteLine("Contract with that ID not found");
                return false;
            }
            if (contractTemp.Value.GetCustomerID() != customerID)
            {
                Console.WriteLine("Contract's customerID does not match the one we are trying to remove");
                return false;
            }
            customerTemp.Value.setOnContractFlag(false);
            contractTemp.Value.SetCustomer(null);
            return true;
        }
    }
}
