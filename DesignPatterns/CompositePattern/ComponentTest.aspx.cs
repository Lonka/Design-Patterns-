using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.CompositePattern
{
    public partial class ComponentTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MenuComponent menuA = new Menu("MenuA", "MenuA Description");
                MenuComponent menuB = new Menu("MenuB", "MenuB Description");
                MenuComponent menuC = new Menu("MenuC", "MenuC Description");
                MenuComponent menuD = new Menu("MenuD", "MenuD Description");
                MenuComponent menuAll = new Menu("MenuAll", "MenuAll Description");
                menuAll.Add(menuA);
                menuB.Add(new MenuItem("MenuB Item1 ", "This is MenuB,s Item1", 9.99, true));
                menuB.Add(new MenuItem("MenuB Item2 ", "This is MenuB's Item2", 19.99, false ));
                menuB.Add(new MenuItem("MenuB Item3 ", "This is MenuB's Item3", 3.99, true));
                MenuComponent menuBB = new Menu("MenuB-B", "MenuB-B Description");
                menuBB.Add(new MenuItem("MenuBB Item1 ", "This is MenuBB's Item1", 129.99, false));
                menuBB.Add(new MenuItem("MenuBB Item2 ", "This is MenuBB's Item2", 33.99, true));
                menuB.Add(menuBB);
                menuAll.Add(menuB);
                menuAll.Add(menuC);
                menuD.Add(new MenuItem("MenuD Item1 ", "This is MenuD's Item1", 119.99, true));
                menuD.Add(new MenuItem("MenuD Item2 ", "This is MenuD's Item2", 29.99, false));
                MenuComponent menuDD = new Menu("MenuD-D", "MenuD-D Description");
                menuDD.Add(new MenuItem("MenuDD Item1 ", "This is MenuDD's Item1", 129.99, false));
                menuDD.Add(new MenuItem("MenuDD Item2 ", "This is MenuDD's Item2", 33.99, true));
                menuD.Add(menuDD);
                menuD.Add(new MenuItem("MenuD Item4 ", "This is MenuD's Item4", 34.99, true));
                menuAll.Add(menuD);

                menuA.Add(new MenuItem("MenuA Item1 ", "This is MenuA,s Item1", 94.99, true));
                menuC.Add(new MenuItem("MenuC Item1 ", "This is MenuC,s Item1", 92.99, true));

                lbl_MenuAll.Text = menuAll.Print();



                //以下用合成反覆器印出素食菜單
                //還不太懂
                //
                //這裡回傳的composite iterator 是記錄menu的堆疊(stack)反覆器
                //也就是說這個反覆器會記錄每個menu的stack
                IIterator stackIterator = menuAll.CreateIterator();
                lbl_MenuAll.Text += "<br/><br/>---------------------------<br/><br/>";
                //這裡的hasNext其實會去找出剛放進stack中的menu中是否還有下一個
                while (stackIterator.hasNext())
                {
                    MenuComponent menuComponent = (MenuComponent)stackIterator.next();
                    try
                    {
                        if (menuComponent.isVegetarian())
                            lbl_MenuAll.Text += menuComponent.Print();
                    }
                    catch (Exception ex)
                    {
                    }
                }
                lbl_MenuAll.Text += "<br/><br/>---------------------------<br/><br/>";
            }
        }
    }
}