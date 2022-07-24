namespace EmpWageFullProgram

{
    class Program
    {
        public const int Emp_Full_TimePresent = 1;
        public const int Emp_Part_TimePresent = 2;
        public const int Emp_Rate_per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
        static void Main(string[] args)
        {

            // Variables
            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;
            // Computation
            for (int day = 0; day < Num_Of_Working_Days; day++)
            {

                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case Emp_Part_TimePresent:
                        empHrs = 4;
                        break;
                    case Emp_Full_TimePresent:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_per_Hour;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
        }
    }
}
