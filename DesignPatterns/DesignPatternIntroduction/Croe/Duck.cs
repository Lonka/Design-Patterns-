using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesignPatterns.DesignPatternIntroduction.Interface;
namespace DesignPatterns.DesignPatternIntroduction.Croe
{
    public class Duck
    {
        private IFlyBehavior iFlyBehavior;
        public IFlyBehavior FlyBehavior
        {
            set { iFlyBehavior = value; }
            get { return iFlyBehavior; }
        }
        private IQuackBehavior iQuackBehavior;
        public IQuackBehavior QuackBehavior { get { return iQuackBehavior; } set { iQuackBehavior = value; } }

        public string Swim()
        {
            return "I like Swimming";
        }
        public string PerformFly()
        {
            return iFlyBehavior.Fly();
        }
        public string PerformQuack()
        {
            return iQuackBehavior.DuckSound;
        }
        public void DoQuack()
        {
            iQuackBehavior.DoDuckSound();
        }
    }
}