using System.Diagnostics;
using System.Net.WebSockets;

namespace Creator.Strategy
{
    public interface IProcessStrategy
    {
        public ProcessStartInfo Info { get; }

        public void Execute();
        
    }
}

