using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    
    public class SumCalculator
    {
        protected readonly int[] _numbers;
        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }
        public int Calculate()
        {
            return _numbers.Sum();
        }
    }
    public class EvenNumbersSumCalculator : SumCalculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers){}
        public new int Calculate()
        {
            return _numbers.Where(x=>x%2==0).Sum();
        }
    }

}
