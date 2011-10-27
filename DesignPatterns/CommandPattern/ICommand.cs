using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.CommandPattern
{
  public interface ICommand
    {
        string Execute();
        string Undo();
    }
}
