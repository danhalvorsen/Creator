using Application.Strategy;

namespace Creator.Lib.Strategies.Concrete {
	public class DotNetCreateNUnitTestProject: DotNetAbstractProcessStarter<ProcessStrategy> {
		private readonly string projectName;

		public DotNetCreateNUnitTestProject(string name) {
			projectName = name;
		}
		public override string Arguments() {
			return $"new nunit-test --name {projectName}";
		}
	}
}
