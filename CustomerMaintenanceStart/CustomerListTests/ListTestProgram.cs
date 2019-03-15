using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerListTests;
using CustomerMaintenanceClasses;

namespace CustomerListTests
{
    class ListTestProgram
    {
        static void Main(string[] args)
        {
            TestCustomerAll();

            TestCustomerListConstructor();
            // TestCustomerListFill();
            TestCustomerListAdd();
            TestCustomerListRemove();
            TestCustomerListIndexers();

            // CustomerList2 Tests

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestCustomerListConstructor()
        {
            CustomerList cList = new CustomerList();

            Console.WriteLine("Testing constructor");
            Console.WriteLine("Default constructor. Expecting count of 0 " + cList.Count);
            Console.WriteLine("Default constructor. Expecting empty string" + cList);
            Console.WriteLine();
        }

        static void TestCustomerListFill()
        {
            CustomerList cList = new CustomerList();
            cList.Fill();

            Console.WriteLine("Testing Fill");
            Console.WriteLine("Expecting count of 5 " + cList.Count);
            Console.WriteLine("Expecting list of 5 customers: \n" + cList);
            Console.WriteLine();
        }

        static void TestCustomerListAdd()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("John", "Smith", "jsmith@virginia.gov");
            Customer c3 = new Customer("Jake", "Andrews", "jandrews@dog.net");

            Console.WriteLine("Testing Add");
            cList.Add(c1);
            Console.WriteLine("Add that takes a customer parameter");
            Console.WriteLine("Expecting count of 1 " + cList.Count);
            Console.WriteLine("Expecting list of 1 customer: \n" + cList);

            cList.Add("Elsa", "Jacobs", "secondtestcustomer@cs.net");
            Console.WriteLine("Add that takes individual customer attributes and constructs customer");
            Console.WriteLine("Expecting count of 2 " + cList.Count);
            Console.WriteLine("Expecting list of 2 customers: \n" + cList);

            cList += c3;
            Console.WriteLine("+ operator");
            Console.WriteLine("Expecting count of 3 " + cList.Count);
            Console.WriteLine("Expecting list of 3 customers:\n" + cList);
            Console.WriteLine();
        }

        static void TestCustomerListRemove()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("John", "Smith", "jsmith@virginia.gov");
            Customer c3 = new Customer("Jake", "Andrews", "jandrews@dog.net");

            cList.Add(c1);
            cList.Add("Elsa", "Jacobs", "secondtestcustomer@cs.net");
            cList += c3;

            Console.WriteLine("Testing Remove");
            Console.WriteLine("Remove");
            cList.Remove(c1);
            Console.WriteLine("Expecting count of 2 " + cList.Count);
            Console.WriteLine("Expecting list of 2 customers: Removed John: \n" + cList);

            cList -= c3;
            Console.WriteLine("- operator");
            Console.WriteLine("Expecting count of 1 " + cList.Count);
            Console.WriteLine("Expecting list of 1 customer. Removed Jake: \n" + cList);
            Console.WriteLine();
        }

        static void TestCustomerListIndexers()
        {
            CustomerList cList = new CustomerList();
            Customer c1 = new Customer("John", "Smith", "jsmith@virginia.gov");
            Customer c3 = new Customer("Jake", "Andrews", "jandrews@dog.net");

            cList.Add(c1);
            cList.Add("Elsa", "Jacobs", "secondtestcustomer@cs.net");
            cList += c3;

            Console.WriteLine("Testing indexer");
            Console.WriteLine("Get product with index 0");
            Customer c4 = cList[0];
            Console.WriteLine("Expecting John. " + c4);
            Console.WriteLine("Should not change list. Expecting count of 3 " + cList.Count);
            Console.WriteLine("Expecting list of 3 customers.  John is the first element in list:\n" + cList);
        }

        static void TestCustomerAll()
        {
            Console.WriteLine("Testing Customer Class");
            TestCustomerListConstructor();
            TestCustomerListAdd();
            TestCustomerListRemove();
            TestCustomerListIndexers();
            Console.WriteLine();
        }
    }
}
