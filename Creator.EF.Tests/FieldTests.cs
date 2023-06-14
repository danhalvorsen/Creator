using Creator.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Creator.EF.Tests
{
	public class FieldTests
	{
		private const int Value10 = 10;

		[Fact]
		public void Test() 
		{
			IField field = new FieldInt(Value10);

			string jsonString = JsonSerializer.Serialize(field);

		}
	}
}
