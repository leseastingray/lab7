using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestCustomerMembers()
            //TestCustomerConstructors();
            //TestCustomerPropertyGetters();
            //TestCustomerPropertySetters();
            //TestCustomerMethods();

            // WholesaleCustomer Derived Class Test
            TestWholesaleCustomer();

            // RetailCustomer Derived Class Test
            TestRetailCustomer();

            // Test Polymorphism
            TestCustomerPolymorphism();

            Console.WriteLine();
            Console.ReadLine();
        }


        static void TestCustomerConstructors()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            Console.WriteLine("Testing both constructors");
            Console.WriteLine("Default constructor. Expecting default values. " + c1.GetDisplayText());
            Console.WriteLine("Overloaded constructor. Expecting Jake this is a test customer, jkam@dog.net"
                    + c2.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerPropertyGetters()
        {
            Customer c1 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            Console.WriteLine("Testing getters");
            Console.WriteLine("First name. Expecting Jake. " + c1.FirstName);
            Console.WriteLine("Last name. Expecting this is a test customer. " + c1.LastName);
            Console.WriteLine("Email. Expecting jkam@dog.net. " + c1.Email);
            Console.WriteLine();
        }

        static void TestCustomerPropertySetters()
        {
            Customer c1 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            Console.WriteLine("Testing setters");
            c1.FirstName = "Jeff";
            c1.LastName = "Last";
            c1.Email = "jlast@dog.net";
            Console.WriteLine("Expecting Jeff Last, jlast@dog.net " + c1.GetDisplayText());
            Console.WriteLine();

        }

        static void TestCustomerMethods()
        {
            Customer c1 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            Console.WriteLine("Testing GetDisplayText");
            Console.WriteLine("Expecting Jake this is a test customer, jkam@dog.net " + c1.GetDisplayText());
            Console.WriteLine();
        }

        static void TestSetterExceptions()
        {
            Customer c1 = new Customer("Jake", "this is a test customer", "jkam@dog.net");

            try
            {
                Console.WriteLine("Testing setters");
                c1.FirstName = "Jeff";
                c1.LastName = "Last";
                c1.Email = "jlastbobkeithandersonifyoucanreadthissayhitoyourpuppydog@dog.net";
                Console.WriteLine("Expecting Jeff Last, jlast@dog.net " + c1.GetDisplayText());
                Console.WriteLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Caught email length exception.");
            }
        }

        // WholesaleCustomer Class Test
        static void TestWholesaleCustomer()
        {
            Console.WriteLine("Testing Wholesale Class");

            WholesaleCustomer wholecust1 = new WholesaleCustomer("Brandon", "Bobs", "bbobs@bobsmotors.com", "Bobs Motors");
            WholesaleCustomer wholecust2 = new WholesaleCustomer("Mary", "Scampi", "maryscampi@scampishrimp.com", "Scampi Shrimp");

            Console.WriteLine("Expecting Brandon Bobs, bbobs@bobsmotors (Bobs Motors) \n" + wholecust1.GetDisplayText());
            Console.WriteLine("Expecting Mary Scampi, maryscampi@scampishrimp.com (Scampi Shrimp) \n" + wholecust2.GetDisplayText());
            Console.WriteLine();
        }

        // RetailCustomer Class Test
        static void TestRetailCustomer()
        {
            Console.WriteLine("Testing Retail Class");

            RetailCustomer retailcust1 = new RetailCustomer("Aaron", "Baker", "abaker@dog.net", "(555) 555-5555");
            RetailCustomer retailcust2 = new RetailCustomer("Cathi", "Davis", "cdavis@dog.net", "(555) 777-7777");

            Console.WriteLine("Expecting Aaron Baker, abaker@dog.net ph: (555) 555-5555 \n" + retailcust1.GetDisplayText());
            Console.WriteLine("Expecting Cathi Davis, cdavis@dog.net ph: (555) 777-7777 \n" + retailcust2.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerPolymorphism()
        {
            Console.WriteLine("Polymorphism tested with GetDisplayText");
            Customer cust1 = new Customer("Jake", "Last", "jlast@dog.net");
            WholesaleCustomer wholecust1 = new WholesaleCustomer("Brandon", "Bobs", "bbobs@bobsmotors.com", "Bobs Motors");
            RetailCustomer retailcust1 = new RetailCustomer("Aaron", "Baker", "abaker@dog.net", "(555) 555-5555");

            Console.WriteLine("GetDisplay Text from Customer Class");
            Console.WriteLine("Expecting Jake Last, jlast@dog.net \n" + cust1.GetDisplayText());

            Console.WriteLine("GetDisplayText from WholesaleCustomer Class");
            Console.WriteLine("Expecting Expecting Brandon Bobs, bbobs@bobsmotors (Bobs Motors) \n" + wholecust1.GetDisplayText());

            Console.WriteLine("GetDisplayText from RetailCustomer Class");
            Console.WriteLine("Expecting Aaron Baker, abaker@dog.net ph: (555) 555-5555 \n" + retailcust1.GetDisplayText());
            Console.WriteLine();
        }

        // CustomerList2 Tests - TODO!!!
        static void TestCustomerList2()
        {
            Console.WriteLine("Testing Wholesale and Retail in same list");
            CustomerList2 cList = new CustomerList2();

            //foreach loop to get all first names in both lists, then combine
            foreach (Customer c in cList)
            {
                
            }
        }

        // Add new tests
        static void TestCustomerAll()
        {
            TestCustomerConstructors();
            TestCustomerPropertyGetters();
            TestCustomerPropertySetters();
            TestCustomerMethods();
            Console.WriteLine();
        }
    }
}
