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

			unselected.LoadImage(File.ReadAllBytes(FileManager.FULLPATHNAME(FileManager.PLUGINDATA_PATHNAME, "SmallLogo.png")));
			selected.LoadImage(File.ReadAllBytes(FileManager.FULLPATHNAME(FileManager.PLUGINDATA_PATHNAME, "SmallLogoON.png")));
            RUI.Icons.Selectable.Icon filterIcon = new RUI.Icons.Selectable.Icon("II_filter_icon", unselected, selected); //Defining filterIcon

			unselectedLegacy.LoadImage(File.ReadAllBytes(FileManager.FULLPATHNAME(FileManager.PLUGINDATA_PATHNAME, "SmallLogoGrey.png")));
			selectedLegacy.LoadImage(File.ReadAllBytes(FileManager.FULLPATHNAME(FileManager.PLUGINDATA_PATHNAME, "SmallLogoGreyON.png")));
            RUI.Icons.Selectable.Icon filterIconLegacy = new RUI.Icons.Selectable.Icon("II_filter_icon_legacy", unselectedLegacy, selectedLegacy); //Defining filterIconLegacy

            PartCategorizer.Category IIfilter = PartCategorizer.AddCustomFilter(Constants.PLUGIN_ID, Constants.MANUFACTURER_NAME, filterIcon, Color.white);

            //filters for all II parts
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "AllParts", string.Format("All {0} Parts", Constants.MANUFACTURER_NAME), filterIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && !o.title.Contains("(LEGACY)"));
			PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Tanks", "Tanks", filterIcon, p => p.resourceInfos.Exists(q => q.resourceName == "Deuterium" || q.resourceName == "Tritium") && p.manufacturer == Constants.MANUFACTURER_NAME);
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
