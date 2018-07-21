using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace WcfService1
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single ,InstanceContextMode = InstanceContextMode.Single)]
    public class Visitor : VCount
    {

        int vc = 0;

        public void VCount()
        {
            Console.WriteLine("New Service Instance Created");
        }

        public int GetVCount()
        {
            vc++;

            return vc;
        }

        

    }

    [ServiceContract]
    public interface VCount
    {
        [OperationContract]
        int GetVCount();
    }
}