using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList2 : List<Customer>
    {
        // changed Fill method
        public void Fill()
        {
            List<Customer> customers = CustomerDB.GetCustomers();
            foreach (Customer cust in customers)
            {
                base.Add(cust);
            }
        }
        // replaced customers variable with this keyword
        public void Save()
        {
            CustomerDB.SaveCustomers(this);
        }
        // used base keyword
        public new void Add(Customer cust)
        {
            base.Add(cust);
        }
        // replaced customers variable with this keyword
        public void Add(string firstName, string lastName, string email)
        {
            Customer cust = new Customer(firstName, lastName, email);
            this.Add(cust);
        }

        public new void Remove(Customer customer)
        {
            base.Remove(customer);
        }

        public override string ToString()
        {
            string output = "";
            foreach (Customer cust in this)
            {
                output += cust.ToString() + "\n";
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
            }
        }


        public Customer this[string email]
        {
            get
            {
                foreach (Customer cust in this)
                {
                    if (cust.Email == email)
                        return cust;
                }
                return null;
            }
        }


        public static CustomerList2 operator + (CustomerList2 clist, Customer cust)
        {
            clist.Add(cust);
            return clist;
        }

        public static CustomerList2 operator - (CustomerList2 clist, Customer cust)
        {
            clist.Remove(cust);
            return clist;
        }
    }
}
