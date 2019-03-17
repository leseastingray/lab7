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

            // CustomerList2 Tests
            TestCustomerList2Constructor();
            TestCustomerList2Add();
            TestCustomerList2Remove();
            TestCustomerList2Indexers();
            TestCustomerList2Combo();

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
        // CustomerList2 Tests
        static void TestCustomerList2Constructor()
        {
            CustomerList cList = new CustomerList();

            Console.WriteLine("Testing constructor");
            Console.WriteLine("Default constructor. Expecting count of 0 " + cList.Count);
            Console.WriteLine("Default constructor. Expecting empty string" + cList);
            Console.WriteLine();
        }

        static void TestCustomerList2Fill()
        {
            CustomerList2 cList2 = new CustomerList2();
            cList2.Fill();

            Console.WriteLine("Testing Fill");
            Console.WriteLine("Expecting count of 5 " + cList2.Count);
            Console.WriteLine("Expecting list of 5 customers: \n" + cList2);
            Console.WriteLine();
        }

        static void TestCustomerList2Add()
        {
            CustomerList2 cList2 = new CustomerList2();
            Customer c1 = new Customer("John", "Smith", "jsmith@virginia.gov");
            Customer c3 = new Customer("Jake", "Andrews", "jandrews@dog.net");

            Console.WriteLine("Testing Add");
            cList2.Add(c1);
            Console.WriteLine("Add that takes a customer parameter");
            Console.WriteLine("Expecting count of 1 " + cList2.Count);
            Console.WriteLine("Expecting list of 1 customer: \n" + cList2);

            cList2.Add("Elsa", "Jacobs", "secondtestcustomer@cs.net");
            Console.WriteLine("Add that takes individual customer attributes and constructs customer");
            Console.WriteLine("Expecting count of 2 " + cList2.Count);
            Console.WriteLine("Expecting list of 2 customers: \n" + cList2);

            cList2 += c3;
            Console.WriteLine("+ operator");
            Console.WriteLine("Expecting count of 3 " + cList2.Count);
            Console.WriteLine("Expecting list of 3 customers:\n" + cList2);
            Console.WriteLine();
        }

        static void TestCustomerList2Remove()
        {
            CustomerList2 cList2 = new CustomerList2();
            Customer c1 = new Customer("John", "Smith", "jsmith@virginia.gov");
            Customer c3 = new Customer("Jake", "Andrews", "jandrews@dog.net");

            cList2.Add(c1);
            cList2.Add("Elsa", "Jacobs", "secondtestcustomer@cs.net");
            cList2 += c3;

            Console.WriteLine("Testing Remove");
            Console.WriteLine("Remove");
            cList2.Remove(c1);
            Console.WriteLine("Expecting count of 2 " + cList2.Count);
            Console.WriteLine("Expecting list of 2 customers: Removed John: \n" + cList2);

            cList2 -= c3;
            Console.WriteLine("- operator");
            Console.WriteLine("Expecting count of 1 " + cList2.Count);
            Console.WriteLine("Expecting list of 1 customer. Removed Jake: \n" + cList2);
            Console.WriteLine();
        }

        static void TestCustomerList2Indexers()
        {
            CustomerList2 cList2 = new CustomerList2();
            Customer c1 = new Customer("John", "Smith", "jsmith@virginia.gov");
            Customer c3 = new Customer("Jake", "Andrews", "jandrews@dog.net");

            cList2.Add(c1);
            cList2.Add("Elsa", "Jacobs", "secondtestcustomer@cs.net");
            cList2 += c3;

            Console.WriteLine("Testing indexer");
            Console.WriteLine("Get product with index 0");
            Customer c4 = cList2[0];
            Console.WriteLine("Expecting John. " + c4);
            Console.WriteLine("Should not change list. Expecting count of 3 " + cList2.Count);
            Console.WriteLine("Expecting list of 3 customers.  John is the first element in list:\n" + cList2);
        }

        // CustomerList2 Combo Tests
        static void TestCustomerList2Combo()
        {
            Console.WriteLine("Testing Wholesale and Retail in same list");
            CustomerList2 cList2 = new CustomerList2();

            // Add wholesale customers to the list
            WholesaleCustomer wholecust1 = new WholesaleCustomer("Brandon", "Bobs", "bbobs@bobsmotors.com", "Bobs Motors");
            cList2.Add(wholecust1);
            WholesaleCustomer wholecust2 = new WholesaleCustomer("Mary", "Scampi", "maryscampi@scampishrimp.com", "Scampi Shrimp");
            cList2.Add(wholecust2);

            // Add retail customers to the list w/overloaded operators
            RetailCustomer retailcust1 = new RetailCustomer("Aaron", "Baker", "abaker@dog.net", "(555) 555-5555");
            cList2 += retailcust1;
            RetailCustomer retailcust2 = new RetailCustomer("Cathi", "Davis", "cdavis@dog.net", "(555) 777-7777");
            cList2 += retailcust2;

            Console.WriteLine("Expecting list of 4 customers, 1st 2 wholesale, next 2 retail \n" + cList2);
            Console.WriteLine();

            Console.WriteLine("Testing foreach");
            Console.WriteLine("All first names. Expecting: Brandon Mary Aaron Cathi");
            string allFirstNames = "";

            //foreach loop to get all first names in both lists, then combine
            foreach (Customer cust in cList2)
            {
                allFirstNames = allFirstNames + cust.FirstName + " ";
            }
            Console.WriteLine(allFirstNames);
            Console.WriteLine();

            Console.WriteLine("Testing Remove and - operator");
            cList2.Remove(wholecust2);
            cList2 -= retailcust2;
            Console.WriteLine("Expecting 1 retail and 1 wholesale \n" + cList2);
        }

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
