using System.Reflection;
using System.Xml.Linq;

namespace QuestionNo_2
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter size of array ");
            int size=Convert.ToInt32(Console.ReadLine());
            Student[] student = new Student[size];

            createArray(student, size);
            acceptDetails(student);
            printDetails(student);
            reverseArray(student);



        }
        public static void createArray(Student[] student, int size)
        {
            student = new Student[size];
        }

        public static void acceptDetails(Student[] student)
        {
            for (int i = 0; i < student.Length; i++)
            {
                Console.WriteLine("Enter name ");
              string  name = Console.ReadLine();

                Console.WriteLine("Enter gender ");
               Boolean gender = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter age ");
              int  age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter standerd ");
              int  std = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter division ");
              char  div = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter Marks ");
              double  marks = Convert.ToDouble(Console.ReadLine());
                student[i] = new Student(name, gender, age, std, marks, div);
            }
        }

        public static void printDetails(Student[] student)
        {
            foreach (Student ttemp in student)
            {
                Console.WriteLine("name" + ttemp.Name + " gender " + ttemp.Gender + " age " + ttemp.Age +
                    " std " + ttemp.Standerd + " marks " + ttemp.Marks + " Div " + ttemp.Div);
            }
        }

        public static void reverseArray(Student[] student)
        {
            int i = 0;
            int j = student.Length - 1;
            while (i < j)
            {
                Student temp = student[i];
                student[i] = student[j];
                student[j] = temp;
                i++;
                j--;
            }

            foreach (Student ttemp in student)
            {
                Console.WriteLine("name" + ttemp.Name + " gender " + ttemp.Gender + " age " + ttemp.Age +
                    " std " + ttemp.Standerd + " marks " + ttemp.Marks + " Div " + ttemp.Div);
            }
        }

  public  struct Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private double marks;
        private char div;
        public Student()
        {
            name = "";
            gender = true;
            age = 0;
            std = 0;
            marks = 0;
            div = 'a';
        }

        public Student(string name, bool gender, int age, int std, double marks, char div)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.marks = marks;
            this.div = div;
        }
        public char Div
        {
            get { return div; }
            set { div = value; }
        }

        public double Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public int Standerd
        {
            get { return std; }
            set { std = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

     
        }

    }
}
