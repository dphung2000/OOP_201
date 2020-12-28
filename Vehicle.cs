using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ObjectOrientedProject
{
    public abstract class Vehicle
    {
        ServiceHistory _history; //datetime, mô tả
        protected int _ID = 0;
        protected bool _isOnContract = false;
        protected VehicleInsurance _insurance = null;
        protected int _rentCost = 0;
        protected string _brand = "None";
        protected int _runningDistance = 0;
        public Vehicle(int id, bool isOnContract, int rentCost, string brand, int runningDistance)
        {
            _history = new ServiceHistory();
            _ID = id;
            Console.WriteLine("Car with ID " + _ID + " created");
            _isOnContract = isOnContract;
            _insurance = null;
            _rentCost = rentCost;
            _brand = brand;
            _runningDistance = runningDistance;
        }
        public int getCost() { return this._rentCost; }
        public int getID() { return this._ID;  }
        public void setOnContractFlag(bool contractFlag) { _isOnContract = contractFlag; }
        public bool getOnContractFlag() { return _isOnContract; }
        protected virtual void serviceEngine() { }
        protected virtual void serviceTransmission() { }
        protected virtual void serviceTires() { }
    }

    class PickupTruck : Vehicle
    {
        private int _tankSize = 0;
        protected override void serviceEngine()
        {

        }
        protected override void serviceTransmission()
        {

        }
        protected override void serviceTires()
        {
            if (_runningDistance > 4000)
            {
                /* _history.time = thời gian để vào đay
                 * Console.Writeln("Sửa 4 bánh");
                 * _runningDistance = 0;
                 * Console
                 */
            }
        }
        public PickupTruck(int id, bool isOnContract, int rentCost, string brand, int runningDistance, int tankSize) : base(id, isOnContract, rentCost, brand, runningDistance)
        {
            _tankSize = tankSize;
            Console.WriteLine("Pickup truck added! Tank size is "+tankSize);
        }
    }

    class Sedan : Vehicle
    {
        private int _numberOfSeats = 0;
        protected override void serviceEngine()
        {
            
        }
        protected override void serviceTransmission()
        {
            
        }
        protected override void serviceTires()
        {
            
        }
        public Sedan(int id, bool isOnContract, int rentCost, string brand, int runningDistance, int numberOfSeats) : base(id, isOnContract, rentCost, brand, runningDistance)
        {
            _numberOfSeats = numberOfSeats;
            Console.WriteLine("Sedan added! Has "+numberOfSeats+" seats.");
        }
    }

    class SportsCar : Vehicle
    {
        private int _accelerationSpeed = 0;
        protected override void serviceEngine()
        {

        }
        protected override void serviceTransmission()
        {

        }
        protected override void serviceTires()
        {

        }
        public SportsCar(int id, bool isOnContract, int rentCost, string brand, int runningDistance, int accelerationSpeed) : base(id, isOnContract, rentCost, brand, runningDistance)
        {
            _accelerationSpeed = accelerationSpeed;
            Console.WriteLine("Sports car added! Acceleration speed is " + accelerationSpeed);
        }
    }
}
