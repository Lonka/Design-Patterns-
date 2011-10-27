using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DesignPatterns.FactoryPattern
{
    public partial class OrderPizza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btn_SimpleOrderPizza_Click(object sender, EventArgs e)
        {
            //EPizzaFlavors ePizzaFlavors = EPizzaFlavors.PepperoniPizza;
            //switch (rdol_PizzaFlavors.SelectedValue)
            //{
            //    case "GreekPizza":
            //        ePizzaFlavors = EPizzaFlavors.GreekPizza;
            //        break;
            //    case "PepperoniPizza":
            //        ePizzaFlavors = EPizzaFlavors.PepperoniPizza;

            //        break;
            //}
            //SimplePizzaFactory simplePizzaFactory = new SimplePizzaFactory();
            //PizzaStore pizzaStore = new PizzaStore(simplePizzaFactory);
            //Pizza pizza = pizzaStore.OrderPizza(ePizzaFlavors);
            //string prepare = pizza.Prepare();
            //string bake = pizza.Bake();
            //string cut = pizza.Cut();
            //string box = pizza.Box();
        }



        protected void btn_OrderPizza_Click(object sender, EventArgs e)
        {
            EPizzaFlavors ePizzaFlavors = EPizzaFlavors.PepperoniPizza;
            switch (rdol_PizzaFlavors.SelectedValue)
            {
                case "GreekPizza":
                    ePizzaFlavors = EPizzaFlavors.GreekPizza;
                    break;
                case "PepperoniPizza":
                    ePizzaFlavors = EPizzaFlavors.PepperoniPizza;

                    break;
            }
            EPizzaArea ePizzaArea = EPizzaArea.TW;
            switch (rdol_PizzaStory.SelectedValue)
            {
                case "PizzaStoryTW":
                    ePizzaArea = EPizzaArea.TW;
                    break;
                case "PizzaStoryNY":
                    ePizzaArea = EPizzaArea.NY;
                    break;
            }
            //-------------以下為simple factory pattern--
            //其實這算是一個design pattern
            //算是一個編碼behavior
            //簡單來說就是把重覆的switch or if
            //拉去一個class做(PizzaStoreArea)
            PizzaStore pizzaStore = null;
            PizzaStoreArea pizzaStoreArea = new PizzaStoreArea();
            pizzaStore = pizzaStoreArea.CreateStore(ePizzaArea);
            //-------------------------------------------


            //-------------以下為factory pattern---------
            //建立者class不需要知道實際的產品是何(Pizza pizza class不需要知道實際的產品是何)
            //選擇了哪個次類別(選擇了那個PizzaStore 「type(ePizzaFlavors)可有可無」)
            //自然就決定了實際的建立產品為何(自然就知道是那個pizza)
            Pizza pizza = pizzaStore.OrderPizza(ePizzaFlavors);
            string name = pizza.getName();


            //---------請不要錯過Abstract Factory Pattern- 
            //由於每個Creator(PizzaStore)的每個Product(Pizza)的原料來源都有可能不同
            //故建立一個相關原料或相依物件的介面(IPizzaIngredientFactory)
            //該介面中提供回傳各種原料的介面(IDough and ISauce)
            //建立每個Creator相對應的原料工廠(PizzaIngredientFactoryNY and PizzaIngredientFactoryTW)
            //並實作(Implement)介面回傳正確的原料類別(DoughTW or SouceTW)
            //最後在每個Product(Pizza)中便可直接使用相對應的原料工廠
            //找出正確的原料，請參考(GreekPizzaNY)
            string dough = pizza.getDough();
            string sauce = pizza.getSauce();
            //---------------------------------------------


            string prepare = pizza.Prepare();
            string bake = pizza.Bake();
            string cut = pizza.Cut();
            string box = pizza.Box();
            //----------------------------------------

        }
    }
}