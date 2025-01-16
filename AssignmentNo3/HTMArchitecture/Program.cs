using EmployeeLib;

namespace HTMArchitecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
           WageEmp wageEmp = new WageEmp();
            wageEmp.Accept();
            wageEmp.Print();
            wageEmp.ToString();

            Console.ReadLine();

        }
    }
}
