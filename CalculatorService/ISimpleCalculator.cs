using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISimpleCalculator
    {
        [OperationContract, AdditionParameterValidator]
        double AddNumbers(double number1, double number2);

        [OperationContract]
        double SubtractNumbers(double number1, double number2);

        [OperationContract]
        [FaultContract(typeof(CustomExceptionWrapper))]
        double MultplyNumbers(double number1, double number2);

        [FaultContract(typeof(CustomExceptionWrapper))]
        [OperationContract]
        double DivideNumbers(double number1, double number2);
    }

    [DataContract]
    public class CustomExceptionWrapper
    {
        [DataMember]
        public string Msg { get; set; }
        [DataMember]
        public string Desc { get; set; }
    }
}
