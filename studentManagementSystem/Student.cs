using System;


namespace studentManagementSystem
{
    class Student
    {
        private string name;
        private int age, rollNo;
        private double cgpa;
        public Student() : this("no name", 0, 0.0d, 0)
        {


        }
        public Student(string name, int age, double cgpa, int rollNo)
        {
            Name = name;
            Age = age;
            CGPA = cgpa;
            RollNumber = rollNo;
        }
        public void inputDetails()
        {
            Console.Write("Enter name of student:");
            Name = Console.ReadLine();
            Console.Write("Enter age of student:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter cgpa of student:");
            CGPA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter roll number of student:");
            RollNumber = Convert.ToInt32(Console.ReadLine());
        }

        //method to convert student's data in a string
        public string toString()
        {
            return Name + "," + Age + "," + CGPA + "," + RollNumber + "\n";
        }

        //property for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //property for age
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        //property for roll number
        public int RollNumber
        {
            get { return rollNo; }
            set { rollNo = value; }
        }
        //property for cgpa
        public double CGPA
        {
            get { return cgpa; }
            set { cgpa = value; }
        }


        public void display() => Console.WriteLine("Name: " + Name + " Age: " + Age + " CGPA: " + CGPA + " Roll number: " + RollNumber);

    }
}
