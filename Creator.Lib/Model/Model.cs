namespace Creator.Lib.Model
{
	public interface IModel
	{
		string Name { get; }
	}

	public class Model: IModel
	{
		public string Name { get; }
		public SolutionModel SolutionModel { get; }
		public Model(string name, SolutionModel model)
		{
			this.Name = name;
			this.SolutionModel = model;
		}
}
}
