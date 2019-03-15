using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    // TODO: RetailCustomer Child Class
    public class RetailCustomer : Customer
    {
        private string homePhone;

        public RetailCustomer()
        {

        }

        public RetailCustomer(string firstName, string lastName, string email, string homePhone) 
            : base(firstName, lastName, email)
        {
            this.homePhone = homePhone;
        }

        public string HomePhone
        {
            get
            {
                return this.homePhone;
            }
            set
            {
                if (homePhone.Length != 10)
                {
                    throw new ArgumentException("home phone number");
                }
                this.homePhone = value;
            }
        }
        public override string GetDisplayText() => base.GetDisplayText() + " ph: " + homePhone;

        public override string ToString()
        {
            return GetDisplayText();
        }
    }
}
