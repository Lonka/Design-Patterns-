using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.SingletonPattern
{
    public partial class SingletonPatternPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               Singleton singleton =  Singleton.getInstance();
               singleton.DBConnectionString = "This is Connection String";
            }
        }

        protected void btn_Redirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("SingletonPatternPage2.aspx");
        }
    }
}