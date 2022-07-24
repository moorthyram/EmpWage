namespace EmpWageFullProgram

{
    class Program
    {
        public const int Emp_Full_TimePresent = 1;
        public const int Emp_Part_TimePresent = 2;
        public const int Emp_Rate_per_Hour = 20;
        static void Main(string[] args)
        {

            // Variables
            int empWage = 0;
            int empHrs = 0;

            Random random = new Random();

            // Computation
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
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
