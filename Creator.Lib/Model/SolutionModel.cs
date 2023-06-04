namespace Creator.Lib.Model
{
	public record SolutionModel(string name,string rootDirectory,List<ProjectModel> Projects): IModel
	{
		public string Name { get; set; } = string.Empty;
		public string RootDirectory { get; set; } = string.Empty;

		public SolutionModel(string name,string rootDirectory) : this(default)
		{
			Name = name;
			RootDirectory = rootDirectory;

		}

		public SolutionModel() : this(default)
		{
			Name = string.Empty;
			Projects = new List<ProjectModel>();
		}
	}
}
