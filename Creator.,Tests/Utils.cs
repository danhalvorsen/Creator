using Creator.Model;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Creator._Tests
{
	public class Utils
	{
		private const string AppJson = "application/json";

		public static StringContent Convert(IModel model)
		{
			//var model = new Model.Model { SolutionName = "FooName",WebProjectName = "WebApp",WorkingDirectory = @"c:\temp\" };
			JsonSerializerOptions options = new(JsonSerializerDefaults.Web) { WriteIndented = true };
			string serializedModel = JsonSerializer.Serialize(model,options);
			return new StringContent(serializedModel,Encoding.UTF8,AppJson);
		}
	}
}
