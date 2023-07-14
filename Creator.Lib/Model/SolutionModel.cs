namespace Creator.Lib.Model {

	public class CreateSolutionModel: IModel<CreateSolutionModel> {

		public CreateSolutionModel(string solutionName,string rootDirectory) {
			this.SolutionName = solutionName;
			this.RootDirectory = rootDirectory;

		}

		public string SolutionName { get; set; } = string.Empty;
		public string RootDirectory { get; set; } = string.Empty;
		public List<CreateProjectModel> Projects { get; set; } = new List<CreateProjectModel>();
		public CreateSolutionModel Config { get; }
	}

}
