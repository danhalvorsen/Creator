namespace Creator.Handlebar.Templates
{
	public class CommandTemplate: ITemplate
	{
		public string CSTemplate { get; set; } = @"""
		
		public class {{{name}}}Command: IRequest<Task>
		{}""
		";
	}
}
