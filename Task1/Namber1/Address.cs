using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Namber1
{
    public class Address
    {
		private int _index;

		public int Index
        {
			get { return _index; }
			set { _index = value; }
		}

		private string _country;

		public string Country
        {
			get { return _country; }
			set { _country = value; }
		}

		private string _city;

		public string City
        {
			get { return _city; }
			set { _city = value; }
		}

		private string _street;

		public string Street
        {
			get { return _street; }
			set { _street = value; }
		}

		private int _house;

		public int House
        {
			get { return _house; }
			set { _house = value; }
		}

		private string _apartment;

		public string Apartment
        {
			get { return _apartment; }
			set { _apartment = value; }
		}

	}
}
