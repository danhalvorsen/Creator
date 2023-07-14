namespace Creator.Lib.Model {
	public interface IModel<M> where M : IModel<M> {
		M Config { get; }

	}

	//public class Model: IModel {
	//	public string SolutionName { get; }
	//	public CreateSolutionModel SolutionModel { get; }
	//	public Model(string name,CreateSolutionModel model) {
	//		this.SolutionName = name;
	//		this.SolutionModel = model;
	//	}
	//}
}
