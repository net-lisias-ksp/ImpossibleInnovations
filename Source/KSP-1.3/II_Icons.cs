/*
	This file is part of Impossible Innovations,
		(C) 2018-2020 : Lisias T : http://lisias.net <support@lisias.net>
		(C) 2014-2018 : JandCandO https://spacedock.info/profile/jandcando
	and it's doubled licensed to you under SKL-1.0 & GPL-2.0

	Impossible Innovations is licensed as follows:

	* Source Code and TweakScale Patches:
		+ SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
		+ GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt
		+ And you are allowed to choose the License that better suit your needs.
	* Models, Textures, Art & Configs:
		+ CC BY-NC-SA 4.0

	Impossible Innovations is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with Impossible Innovations. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with Impossible Innovations. If not, see <https://www.gnu.org/licenses/>.

	You should have received a copy of the Creative Commons 4.0 Attribution-NonCommercial-ShareAlike License
	along with Impossible Innovations. If not, see <https://creativecommons.org/licenses/by-nc-sa/4.0/>.
*/
using System;

using UnityEngine;
using KSP.UI.Screens;
using RUI.Icons.Selectable;

using AssetIO = KSPe.IO.Asset;
using DataIO = KSPe.IO.Data;

namespace ImpossibleInnovations.KSP13
{
	internal class II_Icons
	{
		private Icon icon;

		internal void DoIt()
		{
			this.icon = this.GenIcons("Impossible Innovations", "SmallLogo", "SmallLogoON");
			if (KSPe.Util.KSP.Version.Current >= KSPe.Util.KSP.Version.FindByVersion(1,3,0))
			{ 
				AssetIO.ConfigNode defaults = AssetIO.ConfigNode.ForType<ImpossibleInnovations.II_Icons>("ImpossibleInnovations", "defaults.cfg");
				DataIO.ConfigNode user = DataIO.ConfigNode.ForType<ImpossibleInnovations.II_Icons>("ImpossibleInnovations", "user.cfg");
				if (!user.IsLoadable)
				{
					user.Clear();
					string v = defaults.Load().Node.GetValue("CategoryFilter");
					user.Node.SetValue("CategoryFilter", v, true);
					user.Save();
				}
				{
					user.Load();
					string CategoryFilter = user.Node.GetValue("CategoryFilter");
					switch (CategoryFilter)
					{
						case "CLASSIC":
							GameEvents.onGUIEditorToolbarReady.Add(addIIfilter);
							break;
						case "NONE":
							break;
						default:
							Log.warn("CategoryFilter [{0}] unrecognized on user settings file!", CategoryFilter);
							break;
					}
				}
			}
		}

		private void addIIfilter()
		{
			try
			{ 
				Icon currentPartsIcon = this.GenIcons("II_filter_icon", "SmallLogo", "SmallLogoON");
				Icon legacyPartsIcon = this.GenIcons("II_filter_icon_legacy", "SmallLogoGrey", "SmallLogoGreyON");

				PartCategorizer.Category IIfilter = PartCategorizer.AddCustomFilter(Constants.PLUGIN_ID, Constants.MANUFACTURER_NAME, this.icon, Color.white);
				//filters for all II parts
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "AllParts", string.Format("All {0} Parts", Constants.MANUFACTURER_NAME), currentPartsIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && !o.title.Contains("(LEGACY)"));
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "CommandPods", "Command Pods", currentPartsIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && o.category.ToString() == "Pods" && !o.title.Contains("(LEGACY)"));
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Control", "Control", currentPartsIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && o.category.ToString().Contains("Control") && !o.title.Contains("(LEGACY)"));
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Tanks", "Tanks", currentPartsIcon, p => p.resourceInfos.Exists(q => q.resourceName == "HydrogenProtium" || q.resourceName == "HydrogenDeuterium" || q.resourceName == "HydrogenTritium") && p.manufacturer == Constants.MANUFACTURER_NAME);
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Electrical", "Electrical", currentPartsIcon, o => o.manufacturer == Constants.MANUFACTURER_NAME && o.category.ToString() == "Electrical" && !o.title.Contains("(LEGACY)"));
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Engines", "Engines", currentPartsIcon, r => r.title.Contains("Fusion Engine") && r.manufacturer == Constants.MANUFACTURER_NAME);
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "BoostersCL20", "CL-20 Boosters", currentPartsIcon, s => s.resourceInfos.Exists(t => t.resourceName == "CL-20") && s.manufacturer == Constants.MANUFACTURER_NAME);
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "WingsIonized", "Ionized Wings", currentPartsIcon, u => u.title.Contains("Ionized") && !u.title.Contains("(LEGACY)") && u.manufacturer == Constants.MANUFACTURER_NAME);
				PartCategorizer.AddCustomSubcategoryFilter(IIfilter, "Legacy", "Legacy Parts", legacyPartsIcon, v => v.title.Contains("(LEGACY)") && v.manufacturer == Constants.MANUFACTURER_NAME);
			}
			catch (Exception e)
			{
				Log.ex(this, e);
			}
		}

		private Icon GenIcons(string iconName, string iconNameUnselected, string iconNameSelected)
		{
			try
			{
				Texture2D normIcon = this.GenIconTexture(iconNameUnselected);
				Texture2D selIcon = this.GenIconTexture(iconNameSelected);

				return new Icon(iconName + "_icon", normIcon, selIcon);
			}
			catch (Exception e)
			{
				Log.ex(this, e);
				return this.icon;
			}
		}

		private Texture2D GenIconTexture(string iconName)
		{
			string filename = KSPe.IO.File<ImpossibleInnovations.II_Icons>.Asset.Solve("Icons/" + iconName + ".png");
			return KSPe.Util.Image.Texture2D.LoadFromFile(filename);
		}

	}
}
