namespace EmpWageFullProgram

{
    class Program
    {
        public const int Emp_Full_TimePresent = 1;
        public const int Emp_Part_TimePresent = 2;
        public const int Emp_Rate_per_Hour = 20;
        public const int Num_Of_Working_Days = 2;
        public const int Max_Hrs_In_Month = 10;
        public static int ComputeEmpWage()
        {

            // Variables
            int empWage = 0;
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            // Computation
            while(totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
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
                Console.WriteLine("Days : " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_per_Hour;
            Console.WriteLine("Total Emp Wage : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            ComputeEmpWage();
        }
}
