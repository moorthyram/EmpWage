namespace EmpWageFullProgram

{
    class Program
    {
        public const int Emp_Full_TimePresent = 1;
        public const int Emp_Part_TimePresent = 2;
        public static int ComputeEmpWage(string company, int empRateperHour, int numOfWorkingDays, int maxHoursPerMonth)
        {

            // Variables
            int empWage = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            // Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRateperHour;
            Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage("Tcs", 20, 2, 10);
            ComputeEmpWage("Mobo", 10, 4, 20);
        }
    }
}
