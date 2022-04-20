using System;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetailsModified employeDetails = new EmployeeDetailsModified(new SalaryCalculatorModified());
            employeDetails.HourlyRate = 120;
            employeDetails.HoursWorked = 50;
            Console.WriteLine(employeDetails.GetSlary() ); 
        }
    }
}
