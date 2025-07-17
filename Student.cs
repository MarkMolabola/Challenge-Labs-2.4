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
                switch (Percentage)
                {
                    case double p when p >= 0.9:
                        return "First Division";
                    case double p when p >= 0.8:
                        return "Second Division";
                    case double p when p >= 0.7:
                        return "Third Division";
                    case double p when p >= 0.6:
                        return "Fourth Division";
                    default:
                        return "Fail";
                }
            }
        }
        public void Prompt()
        {
            Console.WriteLine("-----------------------Student details----------------------");
            Console.Write("Roll Number: ");
            RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("-----------------------Input Grades--------------------------- ");
            Console.WriteLine("Physics:");
            PhysicsGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry:");
            ChemistryGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("Computer Application:");
            ComputerAppGrade = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------------");
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
