namespace Creator.Lib.Model
{
	public interface IModel
	{
		string SolutionName { get; set; }
		string WebProjectName { get; set; }
		string WorkingDirectory { get; set; }
	}

	public class Model: IModel
	{
		public string WorkingDirectory { get; set; } = string.Empty;
		public string SolutionName { get; set; } = string.Empty;
		public string WebProjectName { get; set; } = string.Empty;
	}
}
