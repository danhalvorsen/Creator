using Creator.Lib.Features.CreateSolution;
using Creator.Lib.Model;

namespace Creator.Tests {
	[Collection("HandlersTests")]
	public class HandlersTests {
		private CreateSolutionCommandHandler sut =
			new CreateSolutionCommandHandler(
			new CreateSolutionStrategy(
			new CreateSolutionModel(string.Empty,"")
			));
	}
}
