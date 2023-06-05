using Creator.Lib.Features.CreateSolution;
using Creator.Lib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator._Tests
{
	[Collection("HandlersTests")]
	public class HandlersTests
	{
		private CreateSolutionCommandHandler sut =
			new CreateSolutionCommandHandler(
			new CreateSolutionStrategy(
			new CreateSolutionModel()
			));
	}
}
