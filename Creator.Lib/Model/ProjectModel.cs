namespace Creator.Lib.Model
{
	public class ProjectModel: IModel
	{
		public string Name { get; set; } = string.Empty;
		public string ProjectRelativePath { get; set; } = string.Empty;
		public ProjectModel(string name,string projectRelativePath,SolutionModel solution)
		{
			Name = name;
			ProjectRelativePath = projectRelativePath;

		}
	}

	public interface IFolder: IModel
	{
		public string RelativePath { get; set; }
	}
	public class Folder: IFolder
	{
		public string Name { get; set; }
		public string RelativePath { get; set; }

		public Folder(string name,string relativePath)
		{
			this.Name = name;
			this.RelativePath = relativePath;

		}

	}

}
