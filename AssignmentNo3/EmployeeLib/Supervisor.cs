using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Supervisor :Employee
    {
		private int subordinate;

		public Supervisor():base()
		{

		}

        public Supervisor(string name, bool gender, string address, Date birth, string designation, double salary, DepartmentType dept, int subordinate)
           : base(name, gender, address, birth, "Supervisor", salary, dept)
        {
            this.subordinate = subordinate;
        }
        public int Subbordinate
		{
			get { return subordinate; }
			set { subordinate = value; }
		}

		public void Accept()
		{
			base.Accept();
			Designation = "Supervisor";

			Console.WriteLine("enter number of subordinate ");
			Subbordinate=Convert.ToInt32(Console.ReadLine());

		}

		public void Print()
		{
			base.Print();
			Console.WriteLine("No. of subbordinate {0} ",subordinate);
		}

        public override string ToString()
        {
            return $"{{{nameof(Subbordinate)}={Subbordinate.ToString()}, {nameof(ID)}={ID.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Age)}={Age.ToString()}, {nameof(BirthDate)}={BirthDate}, {nameof(Address)}={Address}, {nameof(Gender)}={Gender.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
