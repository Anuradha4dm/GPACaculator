using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGuid.classes
{
    public class Bcs
    {
        public String[] bcsyear1sem1 = new String[] { "Mathematical Foundataion For Computer Science","Programming Techniques","Interner Services and Web Developments","System Analisys And Design", "Laboratary Assignment", "Defferential Equation","Industrial Statistics" };
        public double[] bcsyear1sem1credits = new double[] { 2.5,3,1.5,2,3,1.25,1.25};
        public String[] bcsyear1sem2 = new String[] { "Database Management System", "Data Structure And Algorithms", "Software Enginnering", "Object Oriented System Development", "Computer Laboratory", "Calculus" };
        public double[] bcsyear1sem2credits = new double[] { 3, 3, 3, 2, 1, 2.5 };
        double year1sem1GPA;
        double year1sem2GPA;

        public double Year1sem1GPA { get => year1sem1GPA; set => year1sem1GPA = value; }
        public double Year1sem2GPA { get => year1sem2GPA; set => year1sem2GPA = value; }
    }
}
