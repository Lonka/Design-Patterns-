using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.SingletonPattern
{
    public partial class SingletonPatternPage2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Singleton singleton = Singleton.getInstance();
            lbl_ConnectionString.Text = singleton.DBConnectionString;
        }
    }
}