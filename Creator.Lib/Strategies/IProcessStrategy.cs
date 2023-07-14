using System.Diagnostics;

namespace Application.Strategy {
	public interface IProcessStrategy<M> {
		public ProcessStartInfo GetInfoStarter { get; }
		public void Execute();

	}

	public class ProcessStrategy: IProcessStrategy<ProcessStrategy> {
		public ProcessStartInfo GetInfoStarter { get; } = new ProcessStartInfo();

		public void Execute() {
			throw new NotImplementedException();
		}
	}
}

