using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ObjectOrientedProject
{
    abstract class Vehicle
    {
        ServiceHistory _history; //datetime, mô tả
        static int _ID = 0;
        protected bool _isOnContract = false;
        protected bool _hasInsurance = false;
        protected int _rentCost;
        protected string _brand;
        protected int _runningDistance;
        public Vehicle(bool isOnContract, bool hasInsurance, int rentCost, string brand, int runningDistance)
        {
            _history = new ServiceHistory();
            _ID++;
            Console.WriteLine("Car with ID " + _ID + " created");
            isOnContract = _isOnContract;
            hasInsurance = _hasInsurance;
            rentCost = _rentCost;
            brand = _brand;
            runningDistance = _runningDistance;
        }
        protected virtual void serviceEngine() { }
        protected virtual void serviceTransmission() { }
        protected virtual void serviceTires() { }
    }

    class PickupTruck : Vehicle
    {
        private int _tankSize;
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
        PickupTruck(bool isOnContract, bool hasInsurance, int rentCost, string brand, int runningDistance, int tankSize) : base(isOnContract, hasInsurance, rentCost, brand, runningDistance)
        {
            tankSize = _tankSize;
            Console.WriteLine("Pickup truck added!");
        }
    }

    class Sedan : Vehicle
    {
        private int _numberOfSeats;
        protected override void serviceEngine()
        {
            
        }
        protected override void serviceTransmission()
        {
            
        }
        protected override void serviceTires()
        {
            
        }
        Sedan(bool isOnContract, bool hasInsurance, int rentCost, string brand, int runningDistance, int numberOfSeats) : base(isOnContract, hasInsurance, rentCost, brand, runningDistance)
        {
            numberOfSeats = _numberOfSeats;
        }
    }

    class SportsCar : Vehicle
    {
        private int _accelerationSpeed;
        protected override void serviceEngine()
        {

        }
        protected override void serviceTransmission()
        {

        }
        protected override void serviceTires()
        {

        }
        SportsCar(bool isOnContract, bool hasInsurance, int rentCost, string brand, int runningDistance, int accelerationSpeed) : base(isOnContract, hasInsurance, rentCost, brand, runningDistance)
        {
            accelerationSpeed = _accelerationSpeed;
            Console.WriteLine("Sports car added!");
        }
    }
}
