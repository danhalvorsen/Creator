using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.EF.Model.Fields
{
	public interface IFieldType
	{
		string FieldType { get; }
	}

	public class BaseType: IFieldType
	{
        public BaseType()
        {
            
        }

        public string FieldName { get; set; }
		public string Description { get; set; }
		public string FieldType => nameof(BaseType);
	}

	public class StringField: BaseType
	{
		public int Length { get; set; }
		public new string FieldType => nameof(StringField);
	}

	public class IntField: BaseType
	{
    //    public IntField(string fieldName, int min, int max, string description)
				//{
            
    //    }
        public int MinValue { get; set; }
		public int MaxValue { get; set; }
		public new string FieldType => nameof(IntField);
	}
}
