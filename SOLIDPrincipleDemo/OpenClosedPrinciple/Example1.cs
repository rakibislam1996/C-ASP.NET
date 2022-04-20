using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public interface ISavingAccount
    {
        //Other method and property and code  
        decimal CalculateInterest(int balence);
    }

    public class RegularSavingAccount : ISavingAccount
    {
        public decimal CalculateInterest(int balence)
        {
            int interest = (balence*4)/10;
            if (balence < 1000) interest -= (balence * 2) / 10;
            if (balence > 1000) interest += (balence * 2) / 10;

            return interest;
        }
    }

    public class SalarySavingAccount : ISavingAccount
    {
        public decimal CalculateInterest(int balence)
        {
            throw new NotImplementedException();
        }
    }
    //Violates OCP
    public class SavingAccount
    {
        public decimal CalculateInterest(string savingtype)
        {
            decimal balence = 2/10;
            if (savingtype== "RegularSaving") { }
            if (savingtype == "SalarySaving") { }
            return balence;
        }
    }
}
