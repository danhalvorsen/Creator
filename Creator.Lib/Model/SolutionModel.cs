namespace Creator.Lib.Model
{
	public record CreateSolutionModel(string name,string rootDirectory,List<CreateProjectModel> Projects): IModel
	{
		public string Name { get; set; } = string.Empty;
		public string RootDirectory { get; set; } = string.Empty;

		public CreateSolutionModel(string name,string rootDirectory) : this(default)
		{
			Name = name;
			RootDirectory = rootDirectory;

		}

		public CreateSolutionModel() : this(default)
		{
			Name = string.Empty;
			Projects = new List<CreateProjectModel>();
		}
	}
}
