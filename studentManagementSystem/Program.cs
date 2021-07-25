using System;

namespace studentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageStudent manage = new ManageStudent();

            int choice = 0;
            while (true)
            {
                Console.WriteLine("\n\nPress 1 to add a student");
                Console.WriteLine("Press 2 to display all students");
                Console.WriteLine("Press 3 to display a student on the basis of a roll number");
                Console.WriteLine("Press 4 to modify details of a student on the basis of a roll number");
                Console.WriteLine("Press 5 to delete a student");
                Console.WriteLine("Press 6 to delete all students");
                Console.WriteLine("Press 7 to save changes");
                Console.WriteLine("Press any key to terminate the program");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Student student = ManageStudent.inputDetails();
                    manage.addStudent(student);
                    Console.WriteLine("Student added");
                }
                else if (choice == 2) manage.displayAllStudents();
                else if (choice == 3) manage.displayStudent();
                else if (choice == 4) manage.modifyDetails();
                else if (choice == 5) manage.deleteStudent();
                else if (choice == 6) manage.deleteAllStudents();
                else if (choice == 7) fileManage.writeInFile(manage);
                else break;

            }
        }
    }
}
