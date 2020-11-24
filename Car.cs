using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
	class Car : Vehicle
	{
		private int vehicleType = 0;
		public Car() : base()
		{
			Console.WriteLine("Car ()");
		}
		public Car
			(int _ID, bool _isOnContract, bool _hasInsurance, int _rentCost, string _gara, int _currentKm, int _maxKmServiceEngine, int _maxKmServiceTransmission, int _maxKmServiceTires) :
				base(_ID, _isOnContract, _hasInsurance, _rentCost, 0, _gara, _currentKm, _maxKmServiceEngine, _maxKmServiceTransmission, _maxKmServiceTires)
		{ }
		public override void serviceEngine()
		{
			if (needServiceEngine)
			{
				Console.WriteLine("On:{0}\t do :{1}\t with Car {2}", this.serviceHistory.listOfServiceEngine.Last()._date, this.serviceHistory.listOfServiceEngine.Last()._log, this.ID);
				Console.WriteLine("Mileage of the vehicle:{0}\n Costs:{1}\n Garage:{2}",currentKm,rentCost,Gara);
				Record newRecord = new Record(new DateTime(), "serviceEngine",currentKm,rentCost,Gara);
				this.serviceHistory.addlistOfServiceEngine(newRecord);
				this.currentKm = 0;
				this.needServiceEngine = false;
			}
		}
		public override void serviceTransmission()
		{
			if (needServiceTransmission)
			{
				Console.WriteLine("On:{0}\t do :{1}\t with Car {2}", this.serviceHistory.listOfServiceTransmission.Last()._date, this.serviceHistory.listOfServiceTransmission.Last()._log, this.ID);
				Console.WriteLine("Mileage of the vehicle:{0}\n Costs:{1}\n Garage:{2}", currentKm, rentCost, Gara);
				Record newRecord = new Record(new DateTime(), "serviceTransmission",currentKm,rentCost,Gara);
				this.serviceHistory.addlistOfServiceTransmission(newRecord);
				this.currentKm = 0;
				this.needServiceTransmission = false;
			}
		}
		public override void serviceTires()
		{
			if (needServiceTires)
			{
				Console.WriteLine("On:{0}\t do :{1}\t with Car {2}", this.serviceHistory.listOfServiceTire.Last()._date, this.serviceHistory.listOfServiceTire.Last()._log, this.ID);
				Console.WriteLine("Mileage of the vehicle:{0}\n Costs:{1}\n Garage:{2}", currentKm, rentCost, Gara);
				Record newRecord = new Record(new DateTime(), "serviceTires",currentKm,rentCost,Gara);
				this.serviceHistory.addlistOfServiceTire(newRecord);
				this.currentKm = 0;
				this.needServiceTires = false;
			}
		}
		public void checkNeed()
		{
			if (currentKm > maxKmServiceEngine)
			{
				needServiceEngine = true;
				Console.WriteLine("needServiceEngine");
			}

			if (currentKm > maxKmServiceTransmission)
			{
				needServiceTransmission = true;
				Console.WriteLine("needServiceTransmission");
			}

			if (currentKm > maxKmServiceTires)
			{
				needServiceTires = true;
				Console.WriteLine("needServiceTires");
			}

		}

		public override void go()
		{
			this.currentKm++;
			checkNeed();
		}
	}
}
