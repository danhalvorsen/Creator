namespace Creator.Lib.Model {
	public interface IFolderModel: IModel<CreateSolutionModel> {
		public string RelativePath { get; set; }
		public bool CreateFolder { get; set; }
		public string SolutionName { get; set; }
	}

	public class CreateFolderModel: IFolderModel {
		public string SolutionName { get; set; }
		public string RelativePath { get; set; }
		public bool CreateFolder { get; set; } = true;
		public CreateSolutionModel Config { get; }

		public CreateFolderModel(string folderName,string relativePath) {
			this.SolutionName = folderName;
			this.RelativePath = relativePath;

		}

	}

}
