using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Person
    {
		private string  name;
		private bool gender;
		private string address;
		private Date birth;

		public Person()
		{
			name = "";
			gender = true;
			address = "";
			birth = new Date();
		}

		public Person(string name, bool gender, string address,Date birth)
		{
			this.name = name;
			this.gender = gender;
			this.address = address;
			this.birth = birth;
		}

		public int Age
		{
			get
			{
				Date date1 = new Date(DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year);
				return Date.DifferneceInYear(date1,birth);
				//return date1 - birth;
			}
		}
		public Date BirthDate
		{
			get { return birth; }
			set { birth = value; }
		}


		public string Address
		{
			get { return address; }
			set { address = value; }
		}


		public bool Gender
		{
			get { return gender; }
			set { gender = value; }
		}


		public string  Name
		{
			get { return name; }
			set { name = value; }
		}

		public void Accept()
		{
			Console.WriteLine("Enter name ");
			name = Console.ReadLine();

			Console.WriteLine("enter gender ");
			gender=Convert.ToBoolean(Console.ReadLine());

			Console.WriteLine("enter address ");
			address = Console.ReadLine();

			Console.WriteLine("Enter date of birth ");
			BirthDate.Accept();
		}
		

		public void Print()
		{
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {(Gender ? "Male" : "Female")}");
            Console.WriteLine($"Birth Date: {BirthDate}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Age: {Age}");
			birth.Print();
            Console.WriteLine("name " + name + "gender" + gender + "address" + address + "date of birth " + birth);
		}

        public override string ToString()
        {
            return $"{{{nameof(BirthDate)}={BirthDate}, {nameof(Address)}={Address}, {nameof(Gender)}={Gender.ToString()}, {nameof(Name)}={Name}, {nameof(Age)}={Age.ToString()}}}";
        }
    }
}
