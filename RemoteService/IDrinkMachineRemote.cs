using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RemoteService
{
    //定義遠端服務接口的介面
    public interface IDrinkMachineRemote
    {
        string GetLocation();
        int GetCount();
        bool GetState();
    }
}
