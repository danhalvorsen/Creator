namespace Creator.Handlebar.Templates
{
	public class CommandHandlerTemplate: ITemplate
	{
		public string CSTemplate { get; set; } = @"
		""public class {{name}}CommandHandler: IRequestHandler<{{name}}Command,Task>
			{
				public Task<Task> Handle({{name}}Command command,CancellationToken cancellationToken)
				{
					throw new NotImplementedException();
				}
			}
			""";

		public string TSTemplate { get; set; } = @"
		""class {{name}}CommandHandler: IRequestHandler<{{name}}Command,Task>
			{
				public Task<Task> Handle({{name}}Command command,CancellationToken cancellationToken)
				{
					throw new NotImplementedException();
				}
			}
			""";
	}
}
