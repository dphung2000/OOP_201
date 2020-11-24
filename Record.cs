using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class Record
	{
		public int _carID;
		public DateTime _date;
		public string _log;
		public int _km;
		public Record(DateTime date, string log, int km, int carID)
		{
			this._carID = carID;
			this._date = date;
			this._log = log;
			this._km = km;
		}

		public static int operator -(Record obj1, Record obj2)
		{
			if (obj1._carID == obj2._carID && obj1._log == obj2._log) return obj1._km - obj2._km;
			else if (obj1._carID != obj2._carID) throw new System.InvalidOperationException("Not same CAR_ID");
			else throw new System.InvalidOperationException("Not same RECORD_TYPE");
		}

		public static bool operator >(Record obj1, Record obj2)
		{
			if (obj1._carID == obj2._carID && obj1._log == obj2._log) return obj1._date > obj2._date;
			else if (obj1._carID != obj2._carID) throw new System.InvalidOperationException("Not same CAR_ID");
			else throw new System.InvalidOperationException("Not same RECORD_TYPE");
		}

		public static bool operator <(Record obj1, Record obj2)
		{
			if (obj1._carID == obj2._carID && obj1._log == obj2._log) return obj1._date < obj2._date;
			else if (obj1._carID != obj2._carID) throw new System.InvalidOperationException("Not same CAR_ID");
			else throw new System.InvalidOperationException("Not same RECORD_TYPE");
		}

		public static bool operator ==(Record obj1, Record obj2)
		{
			if (obj1._carID == obj2._carID && obj1._log == obj2._log) return obj1._date == obj2._date;
			else if (obj1._carID != obj2._carID) throw new System.InvalidOperationException("Not same CAR_ID");
			else throw new System.InvalidOperationException("Not same RECORD_TYPE");
		}

		public static bool operator !=(Record obj1, Record obj2)
		{
			if (obj1._carID == obj2._carID && obj1._log == obj2._log) return obj1._date != obj2._date;
			else if (obj1._carID != obj2._carID) throw new System.InvalidOperationException("Not same CAR_ID");
			else throw new System.InvalidOperationException("Not same RECORD_TYPE");
		}

		public static bool operator >=(Record obj1, Record obj2)
		{
			if (obj1._carID == obj2._carID && obj1._log == obj2._log) return obj1._date >= obj2._date;
			else if (obj1._carID != obj2._carID) throw new System.InvalidOperationException("Not same CAR_ID");
			else throw new System.InvalidOperationException("Not same RECORD_TYPE");
		}

		public static bool operator <=(Record obj1, Record obj2)
		{
			if (obj1._carID == obj2._carID && obj1._log == obj2._log) return obj1._date <= obj2._date;
			else if (obj1._carID != obj2._carID) throw new System.InvalidOperationException("Not same CAR_ID");
			else throw new System.InvalidOperationException("Not same RECORD_TYPE");
		}
	}
}
