using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.CommandPattern
{
    public partial class RemoteControlTest : System.Web.UI.Page
    {
       static  SimpleRemoteControl simpleRemoteControl;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                simpleRemoteControl = new SimpleRemoteControl();
        }

        protected void btn_Undo_Click(object sender, EventArgs e)
        {
            lbl_Msg.Text = simpleRemoteControl.buttonUndo();
        }

        protected void btn_Set_Click(object sender, EventArgs e)
        {
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorStopCommand garageDoorStop = new GarageDoorStopCommand(garageDoor);
            simpleRemoteControl.setCommand(lightOn);
            simpleRemoteControl.setCommand(garageDoorUp);
            simpleRemoteControl.setCommand(garageDoorStop);
            lbl_Msg.Text = simpleRemoteControl.buttonWasPressed();
        }
    }
}