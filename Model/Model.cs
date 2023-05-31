namespace Creator.Model
{

	public abstract class ModelBasic {
		public string WorkingDirectory { get; set; } = string.Empty;
    }
	public class Model : ModelBasic
	{
		public string SolutionName { get; set; } = string.Empty;
		public string WebProjectName { get; set; } = string.Empty;
	}
}
