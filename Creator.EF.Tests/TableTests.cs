using Creator.EF.Model;
using FluentAssertions;
using System.Text.Json;

namespace Creator.EF.Tests
{

	/*
	 Table1
	 *	 Column type value required relationship Table2 one-to-man
	 */

	public class TableTests
	{
		const string tableJSON = """{"Columns":[{"type":"int32","Value":100},{"type":"string","Value":"DataData"}]}""";
		Table table = new Table();

		public TableTests()
		{
			table.AddColumn(new FieldInt(100));
			table.AddColumn(new FieldString("DataData"));
		}

		[Fact]
		public void ShouldCreateTable()
		{
			var options = new JsonSerializerOptions { Converters = { new JsonConverterField() } };
			var serialized = JsonSerializer.Serialize(table);
			serialized.Should().Be(tableJSON);
		}

		[Fact]
		public void ShouldConstructTable() 
		{
			var options = new JsonSerializerOptions { Converters = { new JsonConverterField() } };
			var tableFromConfig = JsonSerializer.Deserialize<Table>(tableJSON, options);
			tableFromConfig.Columns[0].Value.Should().Be(100);
			//bleFromConfig.Columns[1].Value.Should().Be("");

		}

	}
}