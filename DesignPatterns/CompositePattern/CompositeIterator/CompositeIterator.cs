using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.CompositePattern
{
    public class CompositeIterator : IIterator
    {
        Stack stack = new Stack();
        public CompositeIterator(IIterator iterator)
        {
            stack.Push(iterator);
        }



        #region IIterator 成員

        public bool hasNext()
        {
            if (stack.Count == 0)
                return false;
            else
            {
                //這邊取出的反覆器有可能是composite iterator(stack menu) or menu's iterator 
                //如果是composite的iterator時下一行的hasNext便會呼叫該menu的composite iterator的hasNext(這裡程式看起來很像是呼叫自己，但其是呼叫該menu的)，此時的hasNext便會是該menu的Iterator看是如有下一個menuitem
                //
                // Composite Iterator 1                                                         Composite Iterator 2       
                //  │        │
                //  │        │
                //  │        │
                //  ├────┤                                                                 │        │
                //  │MenuA   │ -> Next中的 stack.Push(component.CreateIterator()) 會建立一個   │        │  
                //  ├────┤                                                                 ├────┤
                //  │AllMenu │                                                                 │MenuA   │
                //  └────┘                                                                 └────┘
                //如果是menu的iterator時下一行的hasNext便會呼叫該menu的Iterator來看是否有下一個menuitem
                IIterator iterator = (IIterator)stack.Peek();
                if (!iterator.hasNext())
                {
                    //menuitem全沒時便取出該menu
                    stack.Pop();
                    //由於Composite Iterator 2沒了時必須讓Composite Iterator 1去找是否還有下一個節點
                    //所以要return hasnext() 不能return false
                    return hasNext();
                }
                else
                    return true;

            }
        }

        public object next()
        {
            if (hasNext())
            {
                //取出menu
                IIterator iterator = (IIterator)stack.Peek();
                //取出menu的iterator並找出來menu的下一個
                MenuComponent component = (MenuComponent)iterator.next();
                if (component is Menu)
                    stack.Push(component.CreateIterator());
                return component;
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}