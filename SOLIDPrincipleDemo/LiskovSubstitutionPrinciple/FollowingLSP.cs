using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;
        public Calculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public abstract int Calculate();
    }
    public class SummationCalculator : Calculator
    {
        public SummationCalculator(int[] numbers) : base(numbers){ }
        public override int Calculate()
        {
            return _numbers.Sum();
        }
    }
    public class EvenNumbersSummmationCalculator : Calculator
    {
        public EvenNumbersSummmationCalculator(int[] numbers) : base(numbers) { }
        public override int Calculate()
        {
            return _numbers.Where(x => x%2==0).Sum();
        }
    }
}
