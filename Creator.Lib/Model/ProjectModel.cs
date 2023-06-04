using Microsoft.AspNetCore.Authentication;
using System.Linq.Expressions;

namespace Creator.Lib.Model
{
	public class ProjectModel: IModel
	{
		public string Name { get; set; } = string.Empty;
		public IFolderModel Folder { get; set; }

		public ProjectModel(string projectName,string folderName, string projectRelativePath,SolutionModel solution)
		{
			Name = projectName;
			Folder = new FolderModel(folderName,projectRelativePath);

		}
	}

}
