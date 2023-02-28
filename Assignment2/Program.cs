namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("Roshan", 19);
            Console.WriteLine(std.IsCollegeStudent());
        }
    }
}