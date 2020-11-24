using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class RentSystem : Rent, IBookAndRent
	{

		private LinkedList<Vehicle> listOfVehicle;
		private LinkedList<Rent> listOfRent;
		private string report;

		public RentSystem()
		{
			listOfVehicle = new LinkedList<Vehicle>();
			listOfRent = new LinkedList<Rent>();
			report = "";
		}

		public void addVehicle(int _ID, bool _isOnContract, bool _hasInsurance, int _rentCost, int _currentKm,  int _maxKmServiceEngine, int _maxKmServiceTransmission, int _maxKmServiceTires)
		{
			Vehicle newVehicle = new Car(_ID, _isOnContract, _hasInsurance, _rentCost,  _currentKm, _maxKmServiceEngine, _maxKmServiceTransmission, _maxKmServiceTires);
			listOfVehicle.AddLast(newVehicle);
		}
		public void addRent(DateTime _date, string _renterName, int _IDrenter, string _address, string _jobber, string _payment)
		{
			Rent newRent = new Rent(_date, _renterName, _IDrenter, _address, _jobber, _payment);
			listOfRent.AddLast(newRent);
		}
		public void serviceFleet()
		{
			LinkedListNode<Vehicle> node = listOfVehicle.First;
			while (node != null)
			{
				node.Value.serviceEngine();
				node.Value.serviceTransmission();
				node.Value.serviceTires();
			}
		}
		public void Book()
		{
			LinkedListNode<Rent> node = listOfRent.First;
			while (node != null)
			{
				node.Value.Signed();
			}
		}

		public void Rent()
		{
			if (signed && paid)
			{
				Console.WriteLine("Mr.{0} rented car with car's ID:{1}", renterName, ID);
			}
		}
	}
}
