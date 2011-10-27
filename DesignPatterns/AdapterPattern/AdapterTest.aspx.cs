using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.AdapterPattern
{
    public partial class AdapterTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IDuck mallardDuck = new MallardDuck("M.L Duck");
            IDuck blackDuck = new BlackDuck("B.L Duck");
            Response.Write(mallardDuck.Quack()+"<br/>");
            Response.Write(mallardDuck.Fly() + "<br/>");
            Response.Write(blackDuck.Quack() + "<br/>");
            Response.Write(blackDuck.Fly() + "<br/>");
            ITurkey wildTurkey = new WildTurkey("W.D Turkey");
            TurkeyAdapter turkeyAdapter = new TurkeyAdapter(wildTurkey);
            Response.Write(turkeyAdapter.Quack() + "<br/>");
            Response.Write(turkeyAdapter.Fly() + "<br/>");
        }
    }
}