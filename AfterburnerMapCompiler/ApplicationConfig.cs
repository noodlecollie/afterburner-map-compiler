using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace AfterburnerMapCompiler
{
	class ApplicationConfig
	{
		private ApplicationConfigData m_Data;
		private bool m_DataStale = false;

		public ApplicationConfig()
		{
			m_Data = new ApplicationConfigData();
		}

		public string CsgExePath
		{
			get
			{
				return m_Data.CsgExePath;
			}

			set
			{
				if ( value != m_Data.CsgExePath )
				{
					m_Data.CsgExePath = value;
					m_DataStale = true;
				}
			}
		}

		public string BspExePath
		{
			get
			{
				return m_Data.BspExePath;
			}

			set
			{
				if ( value != m_Data.BspExePath )
				{
					m_Data.BspExePath = value;
					m_DataStale = true;
				}
			}
		}

		public string VisExePath
		{
			get
			{
				return m_Data.VisExePath;
			}

			set
			{
				if ( value != m_Data.VisExePath )
				{
					m_Data.VisExePath = value;
					m_DataStale = true;
				}
			}
		}

		public string RadExePath
		{
			get
			{
				return m_Data.RadExePath;
			}

			set
			{
				if ( value != m_Data.RadExePath )
				{
					m_Data.RadExePath = value;
					m_DataStale = true;
				}
			}
		}

		public string GameDirPath
		{
			get
			{
				return m_Data.GameDirectoryPath;
			}

			set
			{
				if ( value != m_Data.GameDirectoryPath )
				{
					m_Data.GameDirectoryPath = value;
					m_DataStale = true;
				}
			}
		}

		public string Serialise(string outputFile, bool force = false)
		{
			string errorString = "";

			if ( m_DataStale || force )
			{
				try
				{
					JsonSerializerOptions options = new JsonSerializerOptions();
					options.WriteIndented = true;

					string jsonString = JsonSerializer.Serialize(m_Data, options);
					File.WriteAllText(outputFile, jsonString);
				}
				catch ( Exception ex )
				{
					errorString = ex.ToString();
				}
			}

			return errorString;
		}

		public void Deserialise(string inputFile)
		{
			try
			{
				string jsonString = File.ReadAllText(inputFile);
				m_Data = JsonSerializer.Deserialize<ApplicationConfigData>(jsonString);
			}
			catch ( Exception )
			{
				// Do nothing if no config file could be loaded.
			}
		}
	}
}
