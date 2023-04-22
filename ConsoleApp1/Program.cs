using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student("Maxaiette", "Cubero", "N/A", "BSIT", 4, 24, "Jovito", "Maunate");
            students[1] = new Student("Maxaiette", "Cubero", "N/A", "BSIT", 4, 24, "Jovito", "Maunate");
            students[2] = new Student("Maxaiette", "Cubero", "N/A", "BSIT", 4, 24, "Jovito", "Maunate");
            students[3] = new Student("Maxaiette", "Cubero", "N/A", "BSIT", 4, 24, "Jovito", "Maunate");
            students[4] = new Student("Maxaiette", "Cubero", "N/A", "BSIT", 4, 24, "Jovito", "Maunate");

            foreach (Student student in students) 
            {
                student.intro();
            }
            
                
            
        }

           
    }
}
