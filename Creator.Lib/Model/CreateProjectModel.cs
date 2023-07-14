namespace Creator.Lib.Model {
	public class CreateProjectModel: IModel<CreateProjectModel> {
		public string SolutionName { get; set; } = string.Empty;
		public IFolderModel Folder { get; set; }
		private CreateSolutionModel SolutionModel { get; }
		public CreateProjectModel Config { get; }

		public CreateProjectModel(string projectName,IFolderModel folderModel,CreateSolutionModel solution) {
			SolutionName = projectName;
			Folder = folderModel;
			SolutionModel = solution;

		}
	}

}
