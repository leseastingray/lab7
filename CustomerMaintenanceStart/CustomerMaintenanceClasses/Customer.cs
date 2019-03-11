﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;


        public Customer() { }

        public Customer(string f, string l, string e)
        {
            firstName = f;
            lastName = l;
            email = e;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (firstName.Length > 30)
                {
                    throw new ArgumentException("firstName");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public virtual string GetDisplayText()
        {
            return firstName + " " + lastName + ", " + email;
        }

        public override string ToString()
        {
            return GetDisplayText();
        }
    }
}
