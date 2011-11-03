using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemoteService;

namespace RemoteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);
            IDrinkMachineRemote obj = (IDrinkMachineRemote)Activator.GetObject(typeof(IDrinkMachineRemote), "tcp://127.0.0.1:9876/remotePin");
            if (obj.Equals(null))
            {
                Console.WriteLine("Error: unable to locate server");
            }
            else
            {
                DrinkMachineReporter report = new DrinkMachineReporter(obj);
                Console.WriteLine(report.Report());
                Console.ReadLine();
            }
        }
    }
}
