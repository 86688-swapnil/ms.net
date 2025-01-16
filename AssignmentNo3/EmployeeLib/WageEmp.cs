using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class WageEmp:Employee
    {
		private int hour;
		private int rate;

		public WageEmp():base()
		{
			hour = 0;
			rate = 0;
		}

        public WageEmp(string name, bool gender, string address, Date birth, string designation, double salary, DepartmentType dept,int hour,int rate) 
			: base(name, gender, address, birth,"Wage",salary,dept)
		{
			this.hour=hour;
			this.rate=rate;
		}

        public int Rate
		{
			get { return rate; }
			set { rate = value; }
		}

		public int Hours
		{
			get { return hour; }
			set { hour = value; }
		}

		public void Accept()
		{
			base.Accept();
			Console.WriteLine("Enter hours ");
			hour=Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("enter rate per hr ");
			hour = Convert.ToInt32(Console.ReadLine());
		}

		public void Print()
		{
			base.Print();
			Console.WriteLine("Hours {0} ",hour);
			Console.WriteLine("Rate { 0} ",rate);
		}

        public override string ToString()
        {
            return $"{{{nameof(Rate)}={Rate.ToString()}, {nameof(Hours)}={Hours.ToString()}, {nameof(ID)}={ID.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Age)}={Age.ToString()}, {nameof(BirthDate)}={BirthDate}, {nameof(Address)}={Address}, {nameof(Gender)}={Gender.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
