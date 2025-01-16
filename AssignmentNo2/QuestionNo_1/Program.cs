using System.Drawing;

namespace QuestionNo_1
{
    public class Program
    {
       
        
        static void Main(string[] args)
        {
            var student = new Student();
           // student.AcceptDetails();
            //Console.WriteLine(student.printDetails());

            Console.WriteLine("Enter size of array ");

            int size = Convert.ToInt32(Console.ReadLine());
             Student[] arrStud;
             arrStud = new Student[size];

            for (int m = 0;m < size; m++)
            {
                arrStud[m].AcceptDetails();
            }
           for(int n = 0;n<size ; n++)
            {
                Console.WriteLine("Print array\n");
                arrStud[n].printDetails();
            }

            int i = 0;
            int j = arrStud.Length - 1;
            while (i < j)
            {
                Student temp=arrStud[i];
                arrStud[i] = arrStud[j];
                arrStud[j] = temp;
                i++;
                j--;
            }

            foreach (Student ttemp in arrStud)
            {
                Console.WriteLine("name" +ttemp.Name+ " gender " + ttemp.Gender+ " age " + ttemp.Age+
                    " std " + ttemp.Standerd+ " marks " + ttemp.Marks+ " Div " + ttemp.Div);
            }

        }
    

    struct Student
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

            public Student(string name,bool gender,int age,int std,double marks,char div)
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

            public void AcceptDetails()
            {
                Console.WriteLine("Enter name ");
                name = Console.ReadLine();

                Console.WriteLine("Enter gender ");
                gender = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Enter age ");
                age=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter standerd ");
                std = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter division ");
                div = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Enter Marks ");
                marks = Convert.ToDouble(Console.ReadLine());


            }
            public string printDetails()
            {
                Console.WriteLine("name " + name + " age " + age.ToString() + " std " + std.ToString() + "  div " + div.ToString() + " mark" + marks.ToString());
             return name;
            }
          
        };
    }
}
