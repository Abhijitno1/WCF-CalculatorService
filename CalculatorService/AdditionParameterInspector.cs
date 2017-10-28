using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class AdditionParameterInspector: IParameterInspector
    {
        int index=0;
        public AdditionParameterInspector(): this(0)
        {
        }

        public AdditionParameterInspector(int index)
        {
            this.index = index;
        }

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            //Do nothing here
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            if (Convert.ToDouble(inputs[0])<=0 || Convert.ToDouble(inputs[1])<=0)
                throw new FaultException("First Number and Second Number should be greater than zero.");
            return null;
        }
    }
}
