namespace Creator.Handlebar.Templates {
	public class UsingTemplate: ITemplate {

		public string CSTemplate { get; set; } = @"
		""
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		using MediatR;""
	";
	}
}
