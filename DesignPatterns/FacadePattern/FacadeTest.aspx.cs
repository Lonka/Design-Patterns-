using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.FacadePattern
{
    public partial class FacadeTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Open_Click(object sender, EventArgs e)
        {
            Dvd dvd = new Dvd();
            Light light = new Light();
            Popper popper = new Popper();
            Screen screen = new Screen();

            //不好的方法
            //ShowMsg(light.On());
            //ShowMsg(light.Dim(10));
            //ShowMsg(popper.On());
            //ShowMsg(popper.Pop());
            //ShowMsg(screen.On());
            //ShowMsg(screen.Down());
            //ShowMsg(dvd.On());

            //運用表象模式
            DvdFacade dvdFacade = new DvdFacade(dvd, light, popper, screen);
            ShowMsg(dvdFacade.Open());
        }

        private void ShowMsg(string msg)
        {
            lbl_Msg.Text += msg + "<br/>";
        }
        private void ClearMsg()
        {
            lbl_Msg.Text = string.Empty;
        }

        protected void btn_Close_Click(object sender, EventArgs e)
        {
            Dvd dvd = new Dvd();
            Light light = new Light();
            Popper popper = new Popper();
            Screen screen = new Screen();
            //不好的方法
            //ShowMsg(dvd.Off());
            //ShowMsg(screen.Up());
            //ShowMsg(screen.Off());
            //ShowMsg(popper.Off());
            //ShowMsg(light.Off());
            //運用表象模式
            DvdFacade dvdFacade = new DvdFacade(dvd, light, popper, screen);
            ShowMsg(dvdFacade.Close ());
        }
    }
}