using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class Student
    {
       public string firstName { get; set; }
      public  string lastName { get; set; }
      public  string middleName { get; set; }
      public  string course { get; set; }
      public int grade { get; set; }
      public  int age { get; set; }
      public  string fatherName { get; set; }
      public  string motherName { get; set; }
        public Student(string firstName, string lastName, 
            string middleName, string course, 
            int grade, int age, string 
            fatherName, string motherName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.course = course;
            this.grade = grade;
            this.age = age;
            this.fatherName = fatherName;
            this.motherName = motherName;
        }
        public void intro()
        {
            Console.WriteLine(firstName+ " " + lastName + " " + middleName + " " + course + " " + grade + " " + age + " " + fatherName + " " + motherName   );
        }

   

      
    }
}
