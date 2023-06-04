namespace Creator.Lib.Model
{
	public class SolutionModel: IModel
	{
		public string Name { get; set; } = string.Empty;
		public string RootDirectory { get; set; } = string.Empty;
		public List<ProjectModel> Projects { get; set; } 

		public SolutionModel(string name, string rootDirectory)
		{
			Name = name;
			RootDirectory = rootDirectory;
			
		}
	}
}
