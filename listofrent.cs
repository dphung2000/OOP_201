using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
	class listofrent
	{
		public LinkedList<Rent> listOfRent;
		public listofrent()
		{
			listOfRent = new LinkedList<Rent>();
		}
		public void addlistOfRent(Rent newRent)
		{
			listOfRent.AddLast(newRent);
		}
	}
}
