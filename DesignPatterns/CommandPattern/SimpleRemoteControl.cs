using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    public class SimpleRemoteControl
    {
        List<ICommand> slot;
        //ICommand slot;
        public SimpleRemoteControl()
        {
            slot = new List<ICommand>();
        }
        public void setCommand(ICommand command)
        {
            slot.Add(command);
        }
        public string buttonWasPressed()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < slot.Count; i++)
                sb.Append(slot[i].Execute() + " <br/> ");
            return sb.ToString();
        }
        public string buttonUndo()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < slot.Count; i++)
                sb.Append(slot[i].Undo () + " <br/> ");
            return sb.ToString();
        }
    }
}