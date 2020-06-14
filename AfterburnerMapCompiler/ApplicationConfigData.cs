using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterburnerMapCompiler
{
	class ApplicationConfigData
	{
		public string CsgExePath { get; set; }
		public string BspExePath { get; set; }
		public string VisExePath { get; set; }
		public string RadExePath { get; set; }
		public string GameDirectoryPath { get; set; }

		public ApplicationConfigData()
		{
			CsgExePath = "";
			BspExePath = "";
			VisExePath = "";
			RadExePath = "";
			GameDirectoryPath = "";
		}
	}
}
