using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection.Emit;
using JetBrains.Annotations;

namespace ImpossibleInnovations
{
	public static class FileManager
	{

		public static readonly string PLUGINDATA_PATHNAME = FileManager.FULLPATHNAME(String.Format("{0}/{1}/{2}/Plugins/PluginData", Constants.GAMEDATA, Constants.ROOT, Constants.PLUGIN_ID));

		public static string FULLPATHNAME(string pathname)
		{
			return Path.Combine(KSPUtil.ApplicationRootPath, pathname);
		}

		public static string FULLPATHNAME(string basedir, string pathname)
		{
			return FULLPATHNAME(Path.Combine(basedir, pathname));
		}

		public static string PATHNAME(string basedir, string dir, string filename)
		{
			return Path.Combine(Path.Combine(basedir, dir), filename);
		}

		// Checks the full pathname (filename included), checks if the parent dirs are available, creating it when not.
		// Raises exception if some directory on the hiarachy cannot be created.
		// Returns if the file exists.
		private static bool checkPathnameAvailability(string pathname)
		{
			string dirnames = Path.GetDirectoryName(pathname);
			Directory.CreateDirectory(dirnames);
			return File.Exists(pathname);
		}
	}
}
