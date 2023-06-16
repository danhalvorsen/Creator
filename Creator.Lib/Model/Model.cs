namespace Creator.Lib.Model {
	public interface IModel {
		string Name { get; }

	}

	public class Model: IModel {
		public string Name { get; }
		public CreateSolutionModel SolutionModel { get; }
		public Model(string name,CreateSolutionModel model) {
			this.Name = name;
			this.SolutionModel = model;
		}
	}
}
