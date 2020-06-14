using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterburnerMapCompiler
{
	class CompilePreset
	{
		public List<CompileToolArgument> CSGArgs; 
		public List<CompileToolArgument> BSPArgs; 
		public List<CompileToolArgument> VISArgs; 
		public List<CompileToolArgument> RADArgs;

		public CompilePreset()
		{
			CSGArgs = new List<CompileToolArgument>();
			BSPArgs = new List<CompileToolArgument>();
			VISArgs = new List<CompileToolArgument>();
			RADArgs = new List<CompileToolArgument>();
		}

		public static string GetCommandString(List<CompileToolArgument> args, KnownPaths knownPaths)
		{
			string cmdString = "";

			foreach ( CompileToolArgument arg in args )
			{
				if ( arg is StringCompileToolArgument )
				{
					cmdString += (cmdString.Length > 0 ? " " : "") + ((StringCompileToolArgument)arg).Value;
				}
				else if ( arg is KnownPathCompileToolArgument )
				{
					cmdString += (cmdString.Length > 0 ? " " : "") + ((KnownPathCompileToolArgument)arg).GetPathString(knownPaths);
				}
			}

			return cmdString;
		}
	}
}
