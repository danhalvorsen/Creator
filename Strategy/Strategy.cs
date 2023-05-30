using System.Diagnostics;


namespace Creator.Strategy
{
    public interface IProcessStarter
    {
        public ProcessStartInfo Info { get; }
    }
}

