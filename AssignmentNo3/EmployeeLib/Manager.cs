using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Manager:Employee
    {
        private double bonus;

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        public Manager():base()
        {

        }

        public Manager(string name, bool gender, string address, Date birth, string designation, double salary,DepartmentType dept,double bonus) 
            :base(name,gender,address,birth,"Manager",salary,dept)
        {
            this.bonus = bonus;
        }

        public void Accept()
        {
            base.Accept();
            Designation = "Manager";
            Console.WriteLine("enter bonus ");
            bonus=Convert.ToDouble(Bonus);

        }

        public void Print()
        {
            base.Print();
            Console.WriteLine("Bonus {0} ",bonus);

        }

        public override string ToString()
        {
            return $"{{{nameof(Bonus)}={Bonus.ToString()}, {nameof(ID)}={ID.ToString()}, {nameof(Salary)}={Salary.ToString()}, {nameof(Designation)}={Designation}, {nameof(Age)}={Age.ToString()}, {nameof(BirthDate)}={BirthDate}, {nameof(Address)}={Address}, {nameof(Gender)}={Gender.ToString()}, {nameof(Name)}={Name}}}";
        }
    }
}
