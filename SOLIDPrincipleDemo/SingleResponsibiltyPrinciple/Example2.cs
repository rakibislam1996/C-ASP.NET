using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleDemo
{
    using System;
    using System.Net.Mail;

    namespace SingleResponsibilityPrinciple
    {
        public class Invoice
        {
            public void AddInvoice()
            {

            }
            public void DeleteInvoice()
            {

            }
            public void EmailSender(MailMessage mailmessage)  // Violates SRP
            {

            }
        }
    }
}
