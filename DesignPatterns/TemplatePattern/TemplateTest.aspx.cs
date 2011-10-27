using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.TemplatePattern
{
    public partial class TemplateTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
              
            }
        }

        protected void btn_Tea_Click(object sender, EventArgs e)
        {
            Tea tea = new Tea();
            tea.isHook = rdol_Hook.SelectedValue;
            lbl_Tea.Text = tea.PrepareRecipe();
        }

        protected void btn_Coffee_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.isHook = rdol_Hook.SelectedValue;
            lbl_Coffee.Text = coffee.PrepareRecipe();
        }
    }
}