using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace DesignPatterns.ProxyPattern.RemoteProxy
{
    public partial class testDrinkMachine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DrinkMachine.location = "Taiwan";
                DrinkMachine.RefillDrink(10);
                TcpChannel channal = new TcpChannel(9876);
                ChannelServices.RegisterChannel(channal, false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(DrinkMachineRemote), "remotePin", WellKnownObjectMode.Singleton);
                lbl_Result.Text +="The Server is ready ....<br/>";
                lbl_Result.Text +="You can click 'buy drink' to buy the drink<br/>";
                lbl_Result.Text += "Now drink is "+DrinkMachine.count +"<br/>";
            }
        }

        protected void btn_Buy_Click(object sender, EventArgs e)
        {
           lbl_Result.Text +=  DrinkMachine.SaleDrink() + "<br/>";
        }
    }
}