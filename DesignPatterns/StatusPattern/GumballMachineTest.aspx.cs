using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.StatusPattern
{
    public partial class GumballMachineTest : System.Web.UI.Page
    {
        GumballMachine gumballMachine = GumballMachine.CreateGumballMachine (10);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbl_State.Text = gumballMachine.GetState();
            }
        }

        protected void btn_Execute_Click(object sender, EventArgs e)
        {
            switch (rdol_state.SelectedValue)
            {
                case "0":
                    lbl_Result.Text += gumballMachine.InsertQuarter();
                    break;
                case "1":
                    lbl_Result.Text += gumballMachine.EjectQuarter();
                    break;
                case "2":
                    lbl_Result.Text += gumballMachine.TurnCrank();
                    break;
                case "3":
                    lbl_Result.Text += gumballMachine.Refill();
                    break;
            }
            lbl_State.Text = gumballMachine.GetState();
        }
    }
}