/*
	This file is part of Impossible Innovations,
		(C) 2018-2020 : Lisias T : http://lisias.net <support@lisias.net>
		(C) 2014-2018 : JandCandO https://spacedock.info/profile/jandcando

	Impossible Innovations is licensed as follows:

		* CC BY-NC-SA 4.0 : https://creativecommons.org/licenses/by-nc-sa/4.0/

	And you are allowed to choose the License that better suit your needs.

	Impossible Innovations is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the CC BY-NC-SA 4.0
	along with Impossible Innovations. If not, see < https://creativecommons.org/>.
*/
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

		public const float LIFT_MULTIPLIER = 8.576f;
	}
}
