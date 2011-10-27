using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DesignPatterns.DesignPatternIntroduction.Croe;
using DesignPatterns.DesignPatternIntroduction.Interface.FlyImplement;
using DesignPatterns.DesignPatternIntroduction.Interface.QuackImplement;


namespace DesignPatterns.DesignPatternIntroduction
{
    public partial class PageDuck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_FlyNoWay_Click(object sender, EventArgs e)
        {
            Duck noWayDuck = new SuperDuck();
            noWayDuck.FlyBehavior = new FlyNoWay();
            lbl_Result.Text = noWayDuck.PerformFly();
        }

        protected void btn_FlyWithWings_Click(object sender, EventArgs e)
        {
            Duck flyWithWingsDuck = new SuperDuck();
            flyWithWingsDuck.FlyBehavior = new FlyWithWings();
            lbl_Result.Text = flyWithWingsDuck.PerformFly();
        }
        protected void btn_FlyRocketPowered_Click(object sender, EventArgs e)
        {
            Duck flyWithRocketPowered = new SuperDuck();
            flyWithRocketPowered.FlyBehavior = new FlyRocketPowered();
            lbl_Result.Text = flyWithRocketPowered.PerformFly();
        }
        protected void btn_Quack_Click(object sender, EventArgs e)
        {
            Duck quackDuck = new SuperDuck();
            quackDuck.QuackBehavior = new Quack();
            lbl_QuackResult.Text = quackDuck.PerformQuack();
            quackDuck.DoQuack();
        }

        protected void btn_Squeak_Click(object sender, EventArgs e)
        {
            Duck quackDuck = new SuperDuck();
            quackDuck.QuackBehavior = new Squeak();
            lbl_QuackResult.Text = quackDuck.PerformQuack();
            quackDuck.DoQuack();
        }

        protected void btn_MuteQuack_Click(object sender, EventArgs e)
        {
            Duck quackDuck = new SuperDuck();
            quackDuck.QuackBehavior = new MuteQuack();
            lbl_QuackResult.Text = quackDuck.PerformQuack();
            quackDuck.DoQuack();
        }

       

      


    }
}