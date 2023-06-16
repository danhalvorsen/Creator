using Application;
using Application.Strategy;
using Application.Strategy.Concrete;
using Creator.Lib.Features.CreateSolution;
using Creator.Lib.Model;

namespace Creator.API {
	public class Program {
		//Creator --s solutionName --web WebApiName
		public static async Task Main(string[] args) {

			var builder = WebApplication.CreateBuilder(args);
			var app = builder.Build();
			var solution = new CreateSolutionModel("Test",@"c:\temp");
			var folderModel = new CreateFolderModel("Foo",@".\foo");

			solution.Projects.Add(
			 new CreateProjectModel("FooProject",folderModel,solution));
			var model = new Model("ModelName",solution);

			//ToDo - Make a generic model for a wanted solution
			//ToDO - Do we really want an API here? Should choose between communication handler? CLI or API
			//CLI :>build solution --wi|hModel model
			app.MapGet("/get",() => { return model; });

			app.MapPost("/",(Creator.Lib.Model.IModel model) => {

				//Debug.Assert(args[1] != null || args[3] != null,"Invalid input to application");
				//validate the model //ToDo
				var solutionName = model.Name;
				var webName = model.Name;

				var solutionModel = new CreateSolutionModel("NameOfSolution",@"c:\temp");
				var strategies = new List<IProcessStrategy>
			{
				new CreateSolutionStrategy(solutionModel),
				new CreateEmptyWebApiStrategy(webName),
				new AddProjectToSolution(webName)

				//Download the code as zipped files
				//https://blog.elmah.io/creating-and-downloading-zip-files-with-asp-net-core/
		};

				new CreatorWithThis(strategies).Create();

				return Results.Ok();

			});

			await app.RunAsync();

		}

	}

}