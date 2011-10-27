using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.FactoryPattern
{
    public abstract class Pizza
    {
        /// <summary>
        /// pizza 名字
        /// </summary>
        protected string name;
        /// <summary>
        /// pizza 生麵團
        /// </summary>
        protected string dough;
        /// <summary>
        /// pizza 醬
        /// </summary>
        protected string sauce;
        /// <summary>
        /// 準備
        /// </summary>
        /// <returns></returns>
        public abstract string Prepare();

        /// <summary>
        /// 烤
        /// </summary>
        /// <returns></returns>
        public abstract string Bake();

        /// <summary>
        /// 切
        /// </summary>
        /// <returns></returns>
        public abstract string Cut();

        /// <summary>
        /// 裝箱
        /// </summary>
        /// <returns></returns>
        public abstract string Box();

        /// <summary>
        /// 取得pizza name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }
        /// <summary>
        /// 取得pizza 生麵團
        /// </summary>
        /// <returns></returns>
        public string getDough()
        {
            return dough ;
        }
        /// <summary>
        /// 取得pizza 醬
        /// </summary>
        /// <returns></returns>
        public string getSauce()
        {
            return sauce;
        }
    }
}