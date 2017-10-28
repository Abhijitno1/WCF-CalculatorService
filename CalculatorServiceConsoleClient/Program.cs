using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CalculatorService;

namespace CalculatorServiceConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ChannelFactory<ISimpleCalculator>("wsHttpBinding_ISimpleCalculator");
            var client = factory.CreateChannel();
            try
            {
                Console.Write("Enter first Number: ");
                var num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second Number: ");
                var num2 = Convert.ToDouble(Console.ReadLine());
                var sum = client.AddNumbers(num1, num2);
                Console.WriteLine("The sum is {0}", sum);
                var sub = client.SubtractNumbers(num1, num2);
                Console.WriteLine("The subtraction is {0}", sub);
                //var mul = client.MultplyNumbers(num1, num2);
                //Console.WriteLine("The multiplication is {0}", mul);
                var div = client.DivideNumbers(num1, num2);
                Console.WriteLine("The division is {0}", div);
                (client as IClientChannel).Close();
            }
            catch(FaultException<CustomExceptionWrapper> ex)
            {
                Console.WriteLine(ex.Detail.Msg);
                Console.WriteLine(ex.Detail.Desc);
                (client as IClientChannel).Abort();
            }
            catch(FaultException ex)
            {
                Console.WriteLine(ex.Message);
                (client as IClientChannel).Abort();
            }
            Console.ReadKey();
        }
    }
}
