namespace EmpWageFullProgram

{
    class Program
    {
        static void Main(string[] args)
        {
            // constants
            int Emp_Full_TimePresent = 1;

            Random random = new Random();

            // Computation
            int empCheck = random.Next(0, 2);

            if (empCheck == Emp_Full_TimePresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
