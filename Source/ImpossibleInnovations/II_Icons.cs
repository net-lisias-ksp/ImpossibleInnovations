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
using System;

using UnityEngine;
using KSP.UI.Screens;
using RUI.Icons.Selectable;

using AssetIO = KSPe.IO.Asset;
using DataIO = KSPe.IO.Data;

namespace ImpossibleInnovations
{
	[KSPAddon(KSPAddon.Startup.MainMenu , true)]
	public class II_Icons : MonoBehaviour
	{
		private void Start()
		{
			if (KSPe.Util.KSP.Version.Current >= KSPe.Util.KSP.Version.FindByVersion(1,3,0))
				KSPe.Util.SystemTools.Assembly.LoadFromFileAndStartup("GameData/ImpossibleInnovations/PluginData/KSP-1.3.dll");
		}
	}
}
