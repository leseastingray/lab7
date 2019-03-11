

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    // WholesaleCustomer Child Class
    public class WholesaleCustomer : Customer
    {
        private string company;

        public WholesaleCustomer()
        {

        }

        public WholesaleCustomer(string firstName, string lastName, string email, string company) :
                base(firstName, lastName, email)
        {
            this.company = company;
        }

        public string Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        // See video, think I am missing some
        public override string GetDisplayText() => base.GetDisplayText() + " (" + company + ")";

        public override string ToString()
        {
            return GetDisplayText();
        }

    }
}

