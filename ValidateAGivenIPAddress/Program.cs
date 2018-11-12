using System;
using System.Linq;

namespace ValidateAGivenIPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validate IP address!");
            Console.WriteLine("--------------------");

            Console.WriteLine("Enter the IP v4 address");
            try
            {
                string IPV4address = Console.ReadLine();
                StringManipulator.ValidateIPV4Address(IPV4address);
            }
            catch (Exception exception) {
                Console.WriteLine("Exception is"+exception.Message);
            }

            Console.ReadLine();
        }
    }
}
