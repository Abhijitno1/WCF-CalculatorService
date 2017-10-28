using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorService
{
    public class SubtractionMessageInspector: IClientMessageInspector
    {
        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
            Console.WriteLine("Received the following reply: {0}", reply.ToString());
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel)
        {
            Console.WriteLine("Sending the following request: {0}", request.ToString());
            return null;
        }
    }
}
