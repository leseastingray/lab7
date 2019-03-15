﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerMaintenanceClasses
{
    public class CustomerList
    {
        private List<Customer> customers;


        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public int Count => customers.Count;

        public void Fill()
        {
            customers = CustomerDB.GetCustomers();
        }

        public void Save()
        {
            CustomerDB.SaveCustomers(customers);
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
            //Changed(this);
        }

        public void Add(string firstName, string lastName, string email)
        {
            Customer c = new Customer(firstName, lastName, email);
            customers.Add(c);
            //Changed(this);
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
            //Changed(this);
        }

        public override string ToString()
        {
            string output = "";
            foreach (Customer c in customers)
            {
                output += c.GetDisplayText() + "\n";
            }
            return output;
        }

        public Customer this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                else if (i >= customers.Count)
                {
                    throw new ArgumentOutOfRangeException("i");
                }
                return customers[i];
            }
            set
            {
                customers[i] = value;
                //Changed(this);
            }
        }

        // Using Customer email for unique key
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

        public static CustomerList operator +(CustomerList clist, Customer c)
        {
            clist.Add(c);
            return clist;
        }

        public static CustomerList operator -(CustomerList clist, Customer c)
        {
            clist.Remove(c);
            return clist;
        }
    }
}
