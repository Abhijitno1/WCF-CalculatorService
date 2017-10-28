using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using CalculatorService;

namespace CalculatorServiceConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof(CalculatorService.SimpleCalculator)
                , new Uri("http://localhost:4200/CalculatorService/SimpleCalculator"));

            serviceHost.AddServiceEndpoint(typeof(ISimpleCalculator), new BasicHttpBinding(), "basic");
            serviceHost.AddServiceEndpoint(typeof(ISimpleCalculator), new WSHttpBinding(), "ws");

            try
            {
                serviceHost.Open();
                Console.WriteLine("{0} is up and running on following endpoints:", serviceHost.Description.ServiceType);
                foreach (var se in serviceHost.Description.Endpoints)
                {
                    Console.WriteLine(se.Address);
                }
                Console.WriteLine("Press any key to close the WCF Service");
                Console.ReadKey();
                serviceHost.Close();
            }
            catch (Exception)
            {
                serviceHost.Abort();
                throw;
            }
        }
    }
}
