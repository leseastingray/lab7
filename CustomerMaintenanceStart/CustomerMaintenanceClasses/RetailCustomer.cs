using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    // TODO: RetailCustomer Child Class
    public class RetailCustomer : Customer
    {
        public RetailCustomer()
        {

        }

        public RetailCustomer(string firstName, string lastName, string email, string homePhone) 
            : base(firstName, lastName, email)
        {

        }
    }
}
