using Application.Strategy;

namespace Application {
	public interface ICreator {
		void Create();
	}
	public class CreatorWithThis: ICreator {
		private readonly List<IProcessStrategy<ProcessStrategy>> orders;

		public CreatorWithThis(List<IProcessStrategy<ProcessStrategy>> strategies) {
			this.orders = strategies;
		}

		/// <summary>
		/// Create according to strategies in the collection orders
		/// </summary>
		public void Create() {
			foreach (var strategy in orders) {
				strategy.Execute();
			}
		}
	}
}
