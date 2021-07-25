using System;
using System.IO;

namespace studentManagementSystem
{
    class ManageStudent
    {
        private Student[] students = null;

        public ManageStudent()
        {
            fileManage.readFromFile(this);
        }

        //method to input details of a student
        public static Student inputDetails()
        {
            Student student = new Student();
            student.inputDetails();
            return student;
        }

        //method to add student in student's list(array)
        public void addStudent(Student student)
        {
            if (this.students != null)
            {
                Student[] temp = new Student[students.Length + 1];
                for (int i = 0; i < this.students.Length; i++)
                {
                    temp[i] = this.students[i];
                }
                temp[students.Length] = student;
                this.students = temp;
            }
            else
            {
                this.students = new Student[] { student };
            }

        }

        public int inputRollNumber()
        {
            Console.Write("Enter roll number of student ");
            return Convert.ToInt32(Console.ReadLine());
        }

        //method to find a student from list on the basis of roll number
        public Student findStudent(int rollNo)
        {
            try
            {
                if (students.Length > 0)
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        if (students[i].RollNumber == rollNo)
                        {
                            return students[i];
                        }
                    }

                }
                else
                    Console.WriteLine("There is no student");

            }
            catch (Exception e)
            {
                Console.WriteLine("There is no student");
            }
            return null;
        }

        public void deleteStudent()
        {
            int rollNo = inputRollNumber();
            Student student = findStudent(rollNo);
            if (student != null)
            {
                Student[] temp = new Student[students.Length - 1];
                int index = 0;
                for (int i = 0; i < students.Length; i++)
                {
                    if (students[i] == student)
                        continue;
                    temp[index++] = students[i];
                }
                students = temp;
                Console.WriteLine("Student deleted Successfully");
            }
            else Console.WriteLine("Student not found with given roll number");

        }

        public void deleteAllStudents()
        {
            students = null;
            Console.WriteLine("Students deleted successfully");
        }

        public void displayAllStudents()
        {
            try
            {
                if (students.Length > 0)
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        Console.WriteLine("\n***Student " + (i + 1) + "***");
                        students[i].display();
                        Console.WriteLine("\n");
                    }
                }

                else
                    Console.WriteLine("There is no student to display");
            }
            catch (Exception e)
            {
                Console.WriteLine("There is no student to display");
            }



        }

        //method to display student on the basis of roll number
        public void displayStudent()
        {

            int rollNo = inputRollNumber();
            Student student = findStudent(rollNo);
            if (student != null)
            {
                student.display();
            }
            else Console.WriteLine("Student not found with given roll number");


        }

        //method to modify details of a student on the basis of roll number
        public void modifyDetails()
        {

            int rollNo = inputRollNumber();
            Student student = findStudent(rollNo);
            if (student != null)
            {
                Console.WriteLine("Enter new Details");
                student.inputDetails();
                Console.WriteLine("Details modified successfully");
            }
            else Console.WriteLine("Student not found with given roll number");

        }


        public Student[] getStudents()
        {
            return students;
        }

    }
    class fileManage
    {
        public const string filePath = "students.txt";
        public static void writeInFile(ManageStudent manage)
        {

            Student[] students = manage.getStudents();

            string data = "";
            if (students != null)
            {
                foreach (Student student in students)
                {
                    data += student.toString();

                }
                File.WriteAllText(filePath, data);
                Console.WriteLine("Changes saved successfully");
            }
            else
            {
                File.WriteAllText(filePath, "");
                Console.WriteLine("Changes saved successfully");
            }





        }
        public static void readFromFile(ManageStudent manage)
        {
            if (File.Exists(filePath))
            {
                string[] stds = File.ReadAllLines(filePath); //stds=> students
                foreach (string studentData in stds)
                {
                    string[] studentSplittedData = studentData.Split(",");
                    Student student = new Student(studentSplittedData[0], Convert.ToInt32(studentSplittedData[1]), Convert.ToDouble(studentSplittedData[2]), Convert.ToInt32(studentSplittedData[3]));
                    manage.addStudent(student);
                }
            }else
            {
                File.WriteAllText(filePath, "");
               
            }
            

        }

    }
}
