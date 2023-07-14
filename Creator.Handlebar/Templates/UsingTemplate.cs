namespace Creator.Handlebar.Templates {
	public class UsingTemplate: ITemplate {
		private string cSTemplate = @"
		""
		using System;
		using System.Collections.Generic;
		using System.Linq;
		using System.Text;
		using MediatR;""
	";

		public string TSCode => "";
		public string CSCode => "";
	}
}
