using System;
using System.Collections.Generic;

namespace PortfolioManager
{
	internal class Person
	{
		public string FirstName;
		public string LastName;
		public DateTime DateOfBirth;
		public string Nationality;
		public List<Portfolio> Portfolios;

		public Person(string firstName, string lastName, DateTime dateOfBirth, string nationality)
		{
			FirstName = firstName;
			LastName = lastName;
			DateOfBirth = dateOfBirth;
			Nationality = nationality;
		}
	}
}
