using Creator.Strategy;

namespace Creator
{
	public interface IWorker 
	{
		void DoIt();
	}
	public class Worker: IWorker
	{
		private readonly List<IProcessStrategy> strategies;
		
		public Worker(List<IProcessStrategy> strategies)
		{
			this.strategies = strategies;
		}

		public void DoIt()
		{
			foreach (var strategy in strategies)
			{
				strategy.Execute();
			}
		}
	}
}
