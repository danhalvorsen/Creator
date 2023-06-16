namespace Creator.CLI {
	public interface IStringArguments {
		public List<string> Args { get; }
	}

	public class StringArguments: IStringArguments {
		public StringArguments(List<string> args) {
			this.Args = args;
		}
		public List<string> Args { get; } = new List<string>();
	}
}
