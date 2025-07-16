namespace Challenge_Labs_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
           

            Console.WriteLine("-----------------------Student details----------------------");
            Console.Write("Roll Number: ");
            student.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Grades for Physics, Chemistry and Computer App: (ex: 90 80 91) ");
            String input = Console.ReadLine();
            string[] grades = input.Split(' ');
            Console.WriteLine("-------------------------------------------------------------");

            student.PhysicsGrade = Convert.ToDouble(grades[0]);
            student.ChemistryGrade = Convert.ToDouble(grades[1]);
            student.ComputerAppGrade = Convert.ToDouble(grades[2]);
            Console.Clear();
            Console.WriteLine(student.ToString());

        }
    }
}
