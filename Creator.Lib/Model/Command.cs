using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creator.Lib.Model
{

	public class Command
	{
		private const string COMMAND_SWITH = "-c";
		private const int MIN_COMMAND_NAME_LENGTH = 2;

		public bool IsCommand(string potentialCommandSwitch, string potentialName) => 	potentialCommandSwitch.Equals(COMMAND_SWITH) && potentialName.Length> MIN_COMMAND_NAME_LENGTH;
    }
}
