using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
	class Rent : Vehicle, IPay // giong vehical
	{
		protected DateTime date;
		protected string renterName;
		protected int IDrenter;
		protected string address;
		protected string jobber;
		protected string payment;
		protected listofrent listofRent;
		public bool signed = false;
		public bool paid = false;

		public Rent()
		{
			renterName = "";
			IDrenter = -1;
			address = "";
			jobber = "";
			payment = "";
			listofRent = new listofrent();
			signed = false;
			paid = false;
		}
		public Rent(DateTime _date, string _renterName, int _IDrenter, string _address, string _jobber, string _payment)
		{
			date = _date;
			renterName = _renterName;
			IDrenter = _IDrenter;
			address = _address;
			jobber = _jobber;
			payment = _payment;
		}

		// mô tả hợp đồng thuê xe
		//Bênh thuê, bênh cho thuê, loại xe, 
		public void Signed()
		{
			if (signed)
			{
				Console.WriteLine("On:{0}\t {4} signed :{1}\t with customer'ID: {2} \t customer'Name:{3}", this.date, this.jobber, this.listofRent.listOfRent.Last(), this.IDrenter, this.renterName);
				Rent newRent = new Rent();
				this.listofRent.addlistOfRent(newRent);
				this.signed = false;
			}
		}
		public void Pay()
		{
			if (paid)
			{
				Console.WriteLine("Mr.{0} paid contract with {1} đồng", renterName, rentCost);
			}

		}
	}
}
