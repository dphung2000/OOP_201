using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    class Vehicle
    {
        protected int _ID;
        protected bool _isOnContract = false;
        protected bool _hasInsurance = false;
        protected int _rentCost;
        protected string _type;
        protected string _brand;
        protected int _runningDistance;
        Vehicle(int ID, bool isOnContract, bool hasInsurance, int rentCost, string type, string brand, int runningDistance)
        {
            ID = ID;
            isOnContract = _isOnContract;
            hasInsurance = _hasInsurance;
            rentCost = _rentCost;
            type = _type;
            brand = _brand;
            runningDistance = _runningDistance; 
        }
    }

    class PickupTruck : Vehicle
    {
        private int _tankSize;
        PickupTruck( a, int tankSize)
        {
            ID = a.ID;
            tankSize = _tankSize;
        }
    }
}
