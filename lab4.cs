using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//(int _ID, bool _isOnContract, bool _hasInsurance, int _rentCost, int _currentKm, int _maxKmServiceEngine,int _maxKmServiceTransmission, int _maxKmServiceTires): 
			Vehicle A = new Car(123, false, true, 10, 100, 103, 104, 105);
			for (int i = 0; i < 10; i++)
			{
				A.go();
			}
			Record r1 = A.getEngineRecord();
			for (int i = 0; i < 100; i++)
			{
				A.go();
			}
			Record r2 = A.getEngineRecord();
			Console.WriteLine(r2 == r1);
			Vehicle B = new Car(124, false, true, 10, 90, 93, 96, 97);
			for (int i = 0; i < 10; i++)
			{
				B.go();
			}
			int c = A.getEngineRecord() - B.getEngineRecord();
		}
	}
}