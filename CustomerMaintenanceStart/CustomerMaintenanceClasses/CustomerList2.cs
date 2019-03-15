using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList2 : List<Customer>
    {
        private List<Customer> customers;

        // changed Fill method
        public void Fill()
        {
            List<Customer> customers = CustomerDB.GetCustomers();
            foreach (Customer c in customers)
            {
                base.Add(c);
            }
        }
        // replaced customers variable with this keyword
        public void Save()
        {
            CustomerDB.SaveCustomers(this);
        }
        // used base keyword
        public new void Add(Customer c)
        {
            base.Add(c);
            //Changed(this);
        }
        // replaced customers variable with this keyword
        public void Add(string firstName, string lastName, string email)
        {
            Customer c = new Customer(firstName, lastName, email);
            this.Add(c);
            //Changed(this);
        }

        public new void Remove(Customer customer)
        {
            base.Remove(customer);
            //Changed(this);
        }

        public override string ToString()
        {
            string output = "";
            foreach (Customer c in this)
            {
                output += c.ToString() + "\n";
            }
            return output;
        }
        // indexer. use base class for properties and array
        public new Customer this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= base.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return base[i];
            }
            set
            {
                base[i] = value;
                //Changed(this);
            }
        }

        // Look at stuff below this, watch 3/11 class video, need to fix errors in operators

        public Customer this[string email]
        {
            get
            {
                foreach (Customer c in customers)
                {
                    if (c.Email == email)
                        return c;
                }
                return null;
            }
        }


        public static CustomerList2 operator + (CustomerList2 clist, Customer c)
        {
            clist.Add(c);
            return clist;
        }

        public static CustomerList2 operator - (CustomerList2 clist, Customer c)
        {
            clist.Remove(c);
            return clist;
        }
    }
}
