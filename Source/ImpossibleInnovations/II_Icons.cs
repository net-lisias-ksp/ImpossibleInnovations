﻿/*
	This file is part of Impossible Innovations,
		(C) 2014-2018 : JandCandO https://spacedock.info/profile/jandcando
		(C) 2018 Lisias T : http://lisias.net <support@lisias.net>

	Impossible Innovations is as follows:

		* CC BY-NC-SA 4.0 : https://creativecommons.org/licenses/by-nc-sa/4.0/

	And you are allowed to choose the License that better suit your needs.

	Impossible Innovations is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the GNU General Public License 2.0
	along with Impossible Innovations. If not, see < https://creativecommons.org/>.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using UnityEngine;
using KSP.UI.Screens;

namespace ImpossibleInnovations
{
    [KSPAddon(KSPAddon.Startup.MainMenu , true)]
    public class II_Icons : MonoBehaviour
    {
        private void addIIfilter()
        {
            //Loading Textures
            Texture2D unselected = new Texture2D(32, 32);
            Texture2D selected = new Texture2D(32, 32);
            Texture2D unselectedLegacy = new Texture2D(32, 32);
            Texture2D selectedLegacy = new Texture2D(32, 32);

			{
				string fn = KSPe.IO.File<II_Icons>.Asset.Solve("Icons/SmallLogo.png");
				unselected.LoadImage(File.ReadAllBytes(fn));
			}
			{
				string fn = KSPe.IO.File<II_Icons>.Asset.Solve("Icons/SmallLogoON.png");
				selected.LoadImage(File.ReadAllBytes(fn));
			}
            RUI.Icons.Selectable.Icon filterIcon = new RUI.Icons.Selectable.Icon("II_filter_icon", unselected, selected); //Defining filterIcon

			{
				string fn = KSPe.IO.File<II_Icons>.Asset.Solve("Icons/SmallLogoGrey.png");
				unselectedLegacy.LoadImage(File.ReadAllBytes(fn));
			}
			{
				string fn = KSPe.IO.File<II_Icons>.Asset.Solve("Icons/SmallLogoGreyON.png");
				selectedLegacy.LoadImage(File.ReadAllBytes(fn));
			}
            RUI.Icons.Selectable.Icon filterIconLegacy = new RUI.Icons.Selectable.Icon("II_filter_icon_legacy", unselectedLegacy, selectedLegacy); //Defining filterIconLegacy

            PartCategorizer.Category IIfilter = PartCategorizer.AddCustomFilter(Constants.PLUGIN_ID, Constants.MANUFACTURER_NAME, filterIcon, Color.white);

            //filters for all II parts
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "AllParts", string.Format("All {0} Parts", Constants.MANUFACTURER_NAME), filterIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && !o.title.Contains("(LEGACY)"));
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "CommandPods", "Command Pods", filterIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && o.category.ToString() == "Pods" && !o.title.Contains("(LEGACY)"));
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Control", "Control", filterIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && o.category.ToString().Contains("Control") && !o.title.Contains("(LEGACY)"));
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Tanks", "Tanks", filterIcon, p => p.resourceInfos.Exists(q => q.resourceName == "HydrogenProtium" || q.resourceName == "HydrogenDeuterium" || q.resourceName == "HydrogenTritium") && p.manufacturer == Constants.MANUFACTURER_NAME);
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Electrical", "Electrical", filterIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && o.category.ToString() == "Electrical" && !o.title.Contains("(LEGACY)"));
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Engines", "Engines", filterIcon, r => r.title.Contains("Fusion Engine") && r.manufacturer == Constants.MANUFACTURER_NAME);
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "BoostersCL20", "CL-20 Boosters", filterIcon, s => s.resourceInfos.Exists(t => t.resourceName == "CL-20") && s.manufacturer == Constants.MANUFACTURER_NAME);
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "WingsIonized", "Ionized Wings", filterIcon, u => u.title.Contains("Ionized") && !u.title.Contains("(LEGACY)") && u.manufacturer == Constants.MANUFACTURER_NAME);
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Legacy", "Legacy Parts", filterIconLegacy, v => v.title.Contains("(LEGACY)") && v.manufacturer == Constants.MANUFACTURER_NAME);
        }

        private void Awake()
        {
            GameEvents.onGUIEditorToolbarReady.Add(addIIfilter);
        }
    }
}
