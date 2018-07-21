using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Web;

namespace WcfService1
{
    public class securityendpoint : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(securityendpoint); }
        }
        protected override object CreateBehavior()
        {
            return new securityendpoint();
        }
    }
}