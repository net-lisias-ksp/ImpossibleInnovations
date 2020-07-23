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
using UnityEngine;

namespace ImpossibleInnovations
{
	public class ModuleIIPoof : PartModule
	{
	#region KSPFields

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Active", isPersistant = true)]
		public bool poofSafety = true;

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Safety", isPersistant = false)]
		public string poofStatus;

	#endregion


	#region Action Groups
		[KSPAction("Toggle Safety")]
		public void actionToggleSaftey(KSPActionParam param)
		{
			this.toggleSafety();
		}

		[KSPAction("Safety On")]
		public void actionSafteyOn(KSPActionParam param)
		{
			this.poofSafetyOn();
		}

		[KSPAction("Safety Off")]
		public void actionSafteyOff(KSPActionParam param)
		{
			this.poofSafetyOff();
		}

		[KSPAction("Poof!")]
		public void actionPoof(KSPActionParam param)
		{
			this.poof();
		}

	#endregion


	#region KSP Life Cycle

		private void OnStart()
		{
			this.UpdateGui();
		}

	#endregion


	#region KSP Events

		[KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Turn Safety Off")]
		public void toggleSafety()
		{
			if (this.poofSafety) poofSafetyOff();
			else poofSafetyOn();
		}

		[KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Poof!")]
		public void poof()
		{
			if (this.poofSafety) return;
			this.part.explode();
		}

	#endregion


	#region Public Interface

		public void poofSafetyOn()
		{
			this.poofSafety = true;
			this.poofStatus = "On";
			this.UpdateGui();
		}

		public void poofSafetyOff()
		{
			this.poofSafety = false;
			this.poofStatus = "OFF";
			this.UpdateGui();
		}

	#endregion


		private void UpdateGui()
		{
			Events["toggleSafety"].guiName = this.poofSafety ? "Turn Safety On" : "Turn Safety Off";
		}

	}
}
