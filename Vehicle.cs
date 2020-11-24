using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class Vehicle
	{
		protected int ID;
		protected bool isOnContract;
		protected bool hasInsurance;
		protected int rentCost;
		protected int vehicleType;
		protected ServiceHistory serviceHistory;
		protected int currentKm;
		protected int maxKmServiceEngine;
		protected int maxKmServiceTransmission;
		protected int maxKmServiceTires;
		public bool needServiceEngine = false;
		public bool needServiceTransmission = false;
		public bool needServiceTires = false;
		public Vehicle()
		{
			ID = -1;
			isOnContract = false;
			hasInsurance = false;
			rentCost = -1;
			vehicleType = -1;
			serviceHistory = new ServiceHistory();
			Record newRecordEngine = new Record(new DateTime(), "serviceEngine", 0, 0);
			Record newRecordTransmission = new Record(new DateTime(), "serviceTransmission", 0, 0);
			Record newRecordTire = new Record(new DateTime(), "serviceTires", 0, 0);
			serviceHistory.addlistOfServiceEngine(newRecordEngine);
			serviceHistory.addlistOfServiceTransmission(newRecordTransmission);
			serviceHistory.addlistOfServiceTire(newRecordTire);
			currentKm = 0;
			maxKmServiceEngine = 0;
			maxKmServiceTransmission = 0;
			maxKmServiceTires = 0;
			needServiceEngine = false;
			needServiceTransmission = false;
			needServiceTires = false;
		}

		public Vehicle
			(int _ID, bool _isOnContract, bool _hasInsurance, int _rentCost, int _vehicleType, int _currentKm, int _maxKmServiceEngine, int _maxKmServiceTransmission, int _maxKmServiceTires)
		{
			ID = _ID;
			isOnContract = _isOnContract;
			hasInsurance = _hasInsurance;
			rentCost = _rentCost;
			vehicleType = _vehicleType;
			currentKm = _currentKm;
			maxKmServiceEngine = _maxKmServiceEngine;
			maxKmServiceTransmission = _maxKmServiceTransmission;
			maxKmServiceTires = _maxKmServiceTires;
			serviceHistory = new ServiceHistory();
			Record newRecordEngine = new Record(new DateTime(), "serviceEngine", 0, this.ID);
			Record newRecordTransmission = new Record(new DateTime(), "serviceTransmission", 0, this.ID);
			Record newRecordTire = new Record(new DateTime(), "serviceTires", 0, this.ID);
			serviceHistory.addlistOfServiceEngine(newRecordEngine);
			serviceHistory.addlistOfServiceTransmission(newRecordTransmission);
			serviceHistory.addlistOfServiceTire(newRecordTire);
			if (currentKm > maxKmServiceEngine)
				needServiceEngine = true;
			if (currentKm > maxKmServiceTransmission)
				needServiceTransmission = true;
			if (currentKm > maxKmServiceTires)
				needServiceTires = true;
		}

		public static bool operator ==(Vehicle obj1, Vehicle obj2)
		{
			return obj1.ID == obj2.ID;
		}

		public static bool operator !=(Vehicle obj1, Vehicle obj2)
		{
			return obj1.ID != obj2.ID;
		}

		public virtual void serviceEngine() { }
		public virtual void serviceTransmission() { }
		public virtual void serviceTires() { }
		public virtual void go() { }
		public virtual void checkNeed() { }
		public virtual Record getEngineRecord()
		{
			return this.serviceHistory.getRecordEngine();
		}
		public virtual Record getTransmissionRecord()
		{
			return this.serviceHistory.getRecordTransmission();
		}
		public virtual Record getTireRecord()
		{
			return this.serviceHistory.getRecordTire();
		}
	}

}
