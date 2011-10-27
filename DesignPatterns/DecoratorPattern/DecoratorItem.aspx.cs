using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.DecoratorPattern
{
    public partial class DecoratorItem : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {



            }
        }

        protected void btn_Decorator_Click(object sender, EventArgs e)
        {
            EBeverageSize eSize = EBeverageSize.Venti;
            Beverage beverage = null;
            switch (rdol_Size.SelectedValue)
            {
                case "Venti":
                    eSize = EBeverageSize.Venti;
                    break;
                case "Grande":
                    eSize = EBeverageSize.Grande;
                    break;
                case "Tall":
                    eSize = EBeverageSize.Tall;
                    break;
            }
            switch (rdol_Beverage.SelectedValue)
            {
                case "HouseBlend":
                    beverage = new HouseBlend(eSize);

                    break;
                case "Espresso":
                    beverage = new Espresso(eSize);
                    break;
            }
            var checkBoxSelect = from chkl in chkl_Decorator.Items.Cast<ListItem>() where chkl.Selected == true  select chkl;
            foreach (var chklItem in checkBoxSelect)
            {
                switch (chklItem.Value)
                {
                    case "Mocha":
                        beverage = new Mocha(beverage);
                        break;
                    case "Whip":
                        beverage = new Whip(beverage);

                        break;
                    case "Milk":
                        beverage = new Milk(beverage);

                        break;
                    case "Soy":
                        beverage = new Soy(beverage);
                        break;
                }
            }
            lbl_Decoraor.Text = beverage.getDescription();
            lbl_Price.Text = beverage.cost().ToString ();

        }
    }
}