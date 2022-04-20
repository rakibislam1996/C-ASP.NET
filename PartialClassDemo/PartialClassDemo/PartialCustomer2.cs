using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    internal partial class Customer
    {
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        public partial void CustomerStatus( )
        {
            if(isActive)
                Console.WriteLine($"Customer ID : {CustomerID} is active");
            else
                Console.WriteLine($"Customer ID : {CustomerID} is not active");
        }
    }
}
