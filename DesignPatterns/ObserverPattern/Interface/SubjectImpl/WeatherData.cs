using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.ObserverPattern.Interface.SubjectImpl
{
    public class WeatherData : ISubject
    {
        private List<IObserver> lsIObserver;
        private string data = string.Empty;
        private bool change = false;
        public WeatherData()
        {
            lsIObserver = new List<IObserver>();
        }

        private List<string> returnData = new List<string>();
        public List<string> GetData
        {
            get { return returnData; }
        }
        #region ISubject 成員

        public void RegisterObserver(IObserver os)
        {
            lsIObserver.Add(os);
        }

        public void RemoveObserver(IObserver os)
        {
            lsIObserver.Remove(os);
        }

        public void NotifyObserver()
        {
            if (change)
            {
                returnData.Clear();
                for (int i = 0; i < lsIObserver.Count; i++)
                    returnData.Add(lsIObserver[i].Update(data));
                change = false;
            }
        }


        public void SetChange()
        {
            change = true;
        }
        #endregion

        public void SetData(string _data)
        {
            data = _data;
            NotifyObserver();
        }

        


    }
}