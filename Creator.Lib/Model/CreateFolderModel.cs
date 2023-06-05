namespace Creator.Lib.Model
{
	public interface IFolderModel: IModel
	{
		public string RelativePath { get; set; }
		public bool CreateFolder { get; set; }
		public string Name { get; set; }
	}

	public class CreateFolderModel: IFolderModel
	{
		public string Name { get; set; }
		public string RelativePath { get; set; }
		public bool CreateFolder { get; set; } = true;

		public CreateFolderModel(string folderName,string relativePath)
		{
			this.Name = folderName;
			this.RelativePath = relativePath;

		}

	}

}
