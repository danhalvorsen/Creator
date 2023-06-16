namespace Creator.Lib.Model {
	public class CreateProjectModel: IModel {
		public string Name { get; set; } = string.Empty;
		public IFolderModel Folder { get; set; }

		public CreateProjectModel(string projectName,IFolderModel folderModel,CreateSolutionModel solution) {
			Name = projectName;
			Folder = folderModel;

		}
	}

}
