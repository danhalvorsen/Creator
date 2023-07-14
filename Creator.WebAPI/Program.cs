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
			var folderModel = new CreateFolderModel("Foo",@".\foo");
			CreateSolutionModel? solutionModel = new CreateSolutionModel("Test",@"c:\temp");

			solutionModel.Projects.Add(
			 new CreateProjectModel("FooProject",folderModel,solutionModel));

			//var model = new Model("ModelName",solution);

			//ToDo - Make a generic model for a wanted solution
			//ToDO - Do we really want an API here? Should choose between communication handler? CLI or API
			//CLI :>build solution --wi|hModel model
			app.MapGet("/get",() => { return solutionModel; });

			app.MapPost("/",(IModel<CreateSolutionModel> model) => {

				//Debug.Assert(args[1] != null || args[3] != null,"Invalid input to application");
				//validate the model //ToDo
				var solutionName = model.Config.SolutionName;
				var webName = model.Config.SolutionName;

				var solutionModel = new CreateSolutionModel("NameOfSolution",@"c:\temp");
				var strategies = new List<IProcessStrategy<ProcessStrategy>>
			{
				new CreateSolutionStrategy(solutionModel),
				new CreateEmptyWebApiStrategy("DummyName"),

				new AddProjectToSolution("")

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
