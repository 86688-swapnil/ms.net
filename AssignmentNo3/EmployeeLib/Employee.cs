using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Employee : Person
    {
		private string designation;
		private double salary;
		private int id;
		private static int autoGenId = 1;
		private  DepartmentType dept;
        public enum DepartmentType
        {
			Finance,
			Development,
			Testing,
			Marketing
		}


        public Employee() :base()
		{
			autoGenId = autoGenId++;
			designation = "";
			salary = 0.0;
			dept = DepartmentType.Finance;
		}

		public Employee(string name,bool gender,string address,Date birth, string designation, double salary,DepartmentType dept):base(name,gender,address,birth) 
		{
			autoGenId=autoGenId++;
			this.designation = designation;
			this.salary = salary;
			this.dept = dept;
		}
		public int ID
		{
			get { return id; }
			set { id = value; }
		}


		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}


		public string Designation
		{
			get { return designation; }
			set { designation = value; }
		}

		public void Accept()
		{
			base.Accept();

			Console.WriteLine("Enter designation ");
			designation = Console.ReadLine();

			Console.WriteLine("Enter Salary ");
			salary=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Department (0 for Finance, 1 for Development , 2 for Marketing ,3 for Testing):");
            Console.WriteLine("enter department name ");
            dept = (DepartmentType)int.Parse(Console.ReadLine());
        }

		public void Print()
		{
			base.Print();	
			Console.WriteLine("dept name {0} ", designation);
			Console.WriteLine("employee salary {1} ",salary);
			Console.WriteLine("depatment type {2}", dept);
		}

        public override string ToString()
        {
            return $"{{{nameof(ID)}={ID.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Age)}={Age.ToString()}, {nameof(BirthDate)}={BirthDate}, {nameof(Address)}={Address}, {nameof(Gender)}={Gender.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
