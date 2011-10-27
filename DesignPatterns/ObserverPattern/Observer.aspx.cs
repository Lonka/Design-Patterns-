using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DesignPatterns.ObserverPattern.Interface.SubjectImpl;
using DesignPatterns.ObserverPattern.Interface.ObserverImpl;

namespace DesignPatterns.ObserverPattern
{
    public partial class Observer : System.Web.UI.Page
    {
        WeatherData weatherData = new WeatherData();
        ObserverSite1 observerSite1 = new ObserverSite1();
        ObserverSite2 observerSite2 = new ObserverSite2();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                weatherData.RegisterObserver(observerSite1);
                weatherData.RegisterObserver(observerSite2);
            }
        }

        protected void btn_UpdateData_Click(object sender, EventArgs e)
        {
            weatherData.SetChange();
            weatherData.SetData(txt_data.Text);
            List<string> returnData = weatherData.GetData;
            lbl_ObserverSite1.Text = returnData[0];
            lbl_ObserverSite2.Text = returnData[1];
        }

    }
}