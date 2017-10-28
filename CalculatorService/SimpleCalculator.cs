using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class SimpleCalculator : ISimpleCalculator
    {
        public double AddNumbers(double number1, double number2)
        {
            return number1 + number2;
        }

        public double SubtractNumbers(double number1, double number2)
        {
            return number1 - number2;
        }

        public double MultplyNumbers(double number1, double number2)
        {
            if (number1==0 || number2==0)
            {
                throw new FaultException<CustomExceptionWrapper>(new CustomExceptionWrapper
                {
                    Msg = "Business Exception",
                    Desc = "Both Numbers should be nonzero to perform this operation"
                });
            }
            return number1 * number2;
        }

        public double DivideNumbers(double number1, double number2)
        {
            try 
            {
                if (number2 == 0) throw new DivideByZeroException();
                return number1 / number2;
            }
            catch(DivideByZeroException ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
