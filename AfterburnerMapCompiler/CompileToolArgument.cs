using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterburnerMapCompiler
{
	class CompileToolArgument
	{
	}

	class StringCompileToolArgument : CompileToolArgument
	{
		public string Value { get; set; }

		public StringCompileToolArgument(string value)
		{
			Value = value;
		}
	}

	class KnownPathCompileToolArgument : CompileToolArgument
	{
		public KnownPath Path { get; set; }

		public KnownPathCompileToolArgument(KnownPath path)
		{
			Path = path;
		}

		public string GetPathString(KnownPaths knownPaths)
		{
			return $"\"{knownPaths.GetPathString(Path)}\"";
		}
	}
}
