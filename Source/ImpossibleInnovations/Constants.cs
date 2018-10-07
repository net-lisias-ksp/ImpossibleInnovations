using System.IO;
using System.Collections.Generic;
using UnityEngine;

namespace ImpossibleInnovations
{
	/*
	 * Constants Definition
	 */
	static class Constants
	{
		/* General rules:
		 * + Directories *always* end witn "/".
		 * + Pathnames *never* start with "/".
		 * + Use Path.Combine where's possible.
		 */
		public const string GAMEDATA = "GameData/";
		public const string PLUGINDATA = "PluginData/";
		public const string LOCAL = "_LOCAL/";
		public const string ROOT = "net.lisias.ksp/";
		public const string BASE = "ImpossibleInnovations/";
		public const string USERDATA = GAMEDATA + LOCAL;

		public const string PLUGIN_ID = "ImpossibleInnovations";
		public const string MANUFACTURER_NAME = "Impossible Innovations";
	}
}
