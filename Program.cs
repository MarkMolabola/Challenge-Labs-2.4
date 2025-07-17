namespace Challenge_Labs_2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Prompt();
            Console.Clear();
            Console.WriteLine(student.ToString());

        }
    }
}
