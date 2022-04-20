using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    // Violating DIP
    public class SalaryCalculator
    {
        public double CalculateSalary(int hoursWorked,double hourlyRate)=>hoursWorked*hourlyRate;
    }
    public class EmployeeDetails
    {
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public double GetSlary()
        {
            var salaryCalculator = new SalaryCalculator();
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate); 
        }
    }
    // In the above segment  higher-level class EmployeeDetails is directly
    // depending upon the lower level SalaryCalculator class.

    // Supporting DIP
    public interface ISalaryCalculator
    {
        public double CalculateSalary(int hoursWorked, double hourlyRate);
    }
    public class SalaryCalculatorModified : ISalaryCalculator
    {
        public double CalculateSalary(int hoursWorked, double hourlyRate)=> hoursWorked*hourlyRate;
    }
    public class EmployeeDetailsModified 
    {
        private readonly ISalaryCalculator _salaryCalculator;
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public EmployeeDetailsModified(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }
        public double GetSlary()
        {
            return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}
