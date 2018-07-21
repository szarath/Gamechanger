using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Windows.Forms;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    
    [ServiceContract]
    public interface IService1
    {

       
        [OperationContract]

        int Insertdata(int Gameid, int Kills, int Death);

        [OperationContract]
        Object[] Getkills(int Gameid);


        [OperationContract]
        Object[] Getdeaths(int Gameid);

        [OperationContract]
        int Addgame(string name);


        [OperationContract]
        Object[] Getgames();

        [OperationContract]
        Object[] Getgamesid();


        [OperationContract]
        int GetIgn();

        [OperationContract]
        int GetSteam();

       



    }

    [DataContract]
    public class Header
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }

    }
    


}
