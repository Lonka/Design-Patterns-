using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.IteratorPattern
{
    public partial class IteratorTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //不好的方法
                //LonkaMenu lonkaMenu = new LonkaMenu();
                //OnizukaMenu onizukaMenu = new OnizukaMenu();
                //MenuItem[] lMenu = lonkaMenu.getMenuItems();
                //List<MenuItem> OMenu = onizukaMenu.getMenuItems();
                //for (int i = 0; i < lMenu.Length; i++)
                //    Response.Write(lMenu[i].name + "<br/>");
                //for (int i = 0; i < OMenu.Count; i++)
                //    Response.Write(OMenu[i].name + "<br/>");


                //Iterator
                IMenuIterator  lonkaMenu = new LonkaMenu();
                IMenuIterator onizukaMenu = new OnizukaMenu();
                IIterator lMenu = lonkaMenu.createIterator();
                IIterator OMenu = onizukaMenu.createIterator();
                PrintMenu(lMenu);
                PrintMenu(OMenu);

            }
        }
        private void PrintMenu(IIterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                Response.Write(menuItem.name + "<br/>");
            }
        }
    }
}