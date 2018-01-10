using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class Student
    {
        public Student()
        {
            //Parameter less
            
        }
        public Student(int stdID, string stdName, string stdClass)
        {
            //paramter cons
            StudentID = stdID;
        }
        private string _stdUniversity;
        //Another way of declaring class properties
        //public static string StudentUniversity
        //{
        //    get
        //    {
        //        return _stdUniversity;
        //    }
        //    set
        //    {
        //        _stdUniversity = value;
        //    }
        //}
        public string StudentUniversity { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        //accessSpeicifer returnType MethodName(input parameters){}
        public void AddStudent(int stdID, string stdName)
        {

        }
    }

    class StudentDemo
    {
        static void Main(string[] args)
        {
            //Class_Name objectName = new Class_Name();
            //In the above syntax new is a keyword.

            Student std = new Student();
            std.StudentUniversity = "JNTU";
            string stdUni = std.StudentUniversity;
            Console.Write("Enter Student Roll No.: ");

            std.StudentID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            std.StudentName = Console.ReadLine();
            Console.Write("Enter Student Class: ");
            std.Class = Console.ReadLine();

            Console.WriteLine("Entered Student detaials. RollNo:" + std.StudentID + " Name:" + std.StudentName + " class:" + std.Class);
            Console.ReadKey();

            //Calculate area of Rectangle
            // Aread = Lenth * Breadth

            int lenght;
            int breadth;

            Console.Write("Enter lenght:");
            lenght = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter breadth:");
            breadth = Convert.ToInt32(Console.ReadLine());

            //int area = lenght * breadth;

            Console.WriteLine("Area of Rectangle with lenght:" + lenght + " and breadth:" + breadth + "is " + lenght * breadth);

            // (a+b)2 = a2+b2+2ab OR (a+b)*(a+b) 

            int c = lenght + breadth;
            Console.WriteLine("(a+b)2 " + c * c);

            int variable = lenght;
            int power = breadth;
            int calculatedPower = 1;

            for(int i= 1; i <= power; i++)
            {
                //calculatedPower = calculatedPower * variable ;
                calculatedPower *= variable;
            }

            Console.WriteLine("power"+ calculatedPower);

            Console.ReadKey();
        }
    }

}
