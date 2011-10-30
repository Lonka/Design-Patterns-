using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.StatusPattern
{
   public interface IStatus
    {
       /// <summary>投入代幣
       /// 
       /// </summary>
       /// <returns></returns>
       string InsertQuarter();

       /// <summary>退出代幣
       /// 
       /// </summary>
       /// <returns></returns>
       string EjectQuarter();

       /// <summary>轉動把手
       /// 
       /// </summary>
       /// <returns></returns>
       string TurnCrank();

       /// <summary>發放糖果
       /// 
       /// </summary>
       /// <returns></returns>
       string Dispense();

       /// <summary>補滿
       /// 
       /// </summary>
       /// <returns></returns>
       string Refill();

    }
}
