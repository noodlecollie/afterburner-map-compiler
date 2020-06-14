using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterburnerMapCompiler
{
	enum KnownPath
	{
		GameDirectory,
		GameMapsDirectory,
		GameTexturesDirectory,

		MapSourceFile,
		MapSourceDirectory,
		MapCompileDirectory,
		MapIntermediateFile,
		MapOutputFile,
	};

	class KnownPaths
	{
		public string GameDirectoryPath;
		public string GameMapsDirectoryPath;
		public string GameTexturesDirectoryPath;

		public string MapSourceFilePath;
		public string MapSourceDirectoryPath;
		public string MapCompileDirectoryPath;
		public string MapIntermediateFilePath;
		public string MapOutputFilePath;

		public string GetPathString(KnownPath path)
		{
			switch ( path )
			{
				case KnownPath.GameDirectory:
				{
					return GameDirectoryPath;
				}

				case KnownPath.GameMapsDirectory:
				{
					return GameMapsDirectoryPath;
				}

				case KnownPath.GameTexturesDirectory:
				{
					return GameTexturesDirectoryPath;
				}

				case KnownPath.MapSourceFile:
				{
					return MapSourceFilePath;
				}

				case KnownPath.MapSourceDirectory:
				{
					return MapSourceDirectoryPath;
				}

				case KnownPath.MapCompileDirectory:
				{
					return MapCompileDirectoryPath;
				}

				case KnownPath.MapIntermediateFile:
				{
					return MapIntermediateFilePath;
				}

				case KnownPath.MapOutputFile:
				{
					return MapOutputFilePath;
				}

				default:
				{
					throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}
