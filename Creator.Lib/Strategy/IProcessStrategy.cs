using System.Diagnostics;
using System.Net.WebSockets;

namespace Application.Strategy
{
    public interface IProcessStrategy
    {
        public ProcessStartInfo Info { get; }

        public void Execute();
        
    }
}

