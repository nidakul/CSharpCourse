using System;
namespace Classes
{
	public class Customer
	{
		public int Id { get; set; }

		private string _firstName;
		public string FirstName { get { return "Mr." + _firstName; } set { _firstName = value; } }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

