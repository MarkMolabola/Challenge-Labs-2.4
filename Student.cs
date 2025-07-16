using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_Labs_2._4
{
    internal class Student
    {
        //private double totalGrade;
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public double PhysicsGrade { get; set; }
        public double ChemistryGrade { get; set; }
        public double ComputerAppGrade { get; set; }
        public double TotalGrade
        {
            get
            {
                return PhysicsGrade + ChemistryGrade + ComputerAppGrade;
            }
        }
        public double Percentage
        {
            get
            {
                return (TotalGrade / 300);
            }
        }
        public string Division
        {
            get
            {
                if (Percentage >= 60)
                    return "First";
                else if (Percentage >= 50)
                    return "Second";
                else if (Percentage >= 40)
                    return "Third";
                else
                    return "Fail";
            }
        }
        public override string ToString()
        {
            return $"----------------Student Details------------------\n" +
                   $"Roll Number: {RollNumber}\n" +
                   $"Name: {Name}\n" +
                   $"Physics Grade: {PhysicsGrade}\n" +
                   $"Chemistry Grade: {ChemistryGrade}\n" +
                   $"Computer App Grade: {ComputerAppGrade}\n" +
                   $"Total Grade: {TotalGrade}\n" +
                   $"Percentage: {Percentage:P}\n" +
                   $"Division: {Division}\n"+
                   $"-------------------------------------------------";

        }
    }
}
