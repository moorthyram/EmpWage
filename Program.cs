namespace EmpWageFullProgram

{
    class Program
    {
        static void Main(string[] args)
        {
            // Constants
            int Emp_Full_TimePresent = 1;
            int Emp_Rate_per_Hour = 20;

            // Variables
            int empWage = 0;
            int empHrs = 0;

            Random random = new Random();

            // Computation
            int empCheck = random.Next(0, 2);

            if (empCheck == Emp_Full_TimePresent)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_per_Hour;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
