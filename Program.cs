using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using POC.WFC.WebService;

namespace POC.WFC.WebService
{
    public class Program
    {
        public static void Main(string[] args)
        {
           //Step 1: Create an instance of the WCF proxy.
            MyWebServiceClient client = new MyWebServiceClient();

            // Step 2: Call the service operations.
            // Call the Add service operation.
            double value1 = 100.00D;
            double value2 = 15.99D;
            double result = client.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            string helloResult = client.HelloWorld();
            Console.WriteLine($"{helloResult}");


            // Step 3: Close the client to gracefully close the connection and clean up resources.
            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();
        }
    }
}