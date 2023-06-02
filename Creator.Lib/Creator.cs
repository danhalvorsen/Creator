using Application.Strategy;

namespace Application
{
	public interface ICreator 
	{
		void Create();
	}
	public class CreatorWithThis: ICreator
	{
		private readonly List<IProcessStrategy> orders;
		
		public CreatorWithThis(List<IProcessStrategy> strategies)
		{
			this.orders = strategies;
		}

		/// <summary>
		/// Create according to strategies in the collection ordes
		/// </summary>
		public void Create()
		{
			foreach (var strategy in orders)
			{
				strategy.Execute();
			}
		}
	}
}
