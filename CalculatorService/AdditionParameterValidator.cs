using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class AdditionParameterValidator: Attribute, IOperationBehavior
    {
        int index = 0;
        public AdditionParameterValidator(int index) { this.index = index; }
        public AdditionParameterValidator() : this(0) { }

        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
            //Do nothing here
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation)
        {
            clientOperation.ClientParameterInspectors.Add(new AdditionParameterInspector(index));
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(new AdditionParameterInspector(index));
        }

        public void Validate(OperationDescription operationDescription)
        {
            //Do nothing here
        }
    }
}
