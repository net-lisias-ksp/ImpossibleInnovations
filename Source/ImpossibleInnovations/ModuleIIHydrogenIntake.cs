﻿/*
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
namespace ImpossibleInnovations
{
	public class ModuleIIHydrogenIntake : PartModule
	{
	#region KSPFields

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Active", isPersistant = true)]
		public bool intakeActive = true;

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "State", isPersistant = false)]
		public string intakeStatus = "Active";

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Scoop", isPersistant = false)]
		public double ammount = 0;

	#endregion


	#region Action Groups
		[KSPAction("Toggle Collector")]
		public void actionToggleCollector(KSPActionParam param)
		{
			toggleFilter();
		}

		[KSPAction("Turn Collector On")]
		public void actionTurnCollectorOn(KSPActionParam param)
		{
			filterOn();
		}

		[KSPAction("Turn Collector Off")]
		public void actionTurnCollectorOff(KSPActionParam param)
		{
			filterOff();
		}
	#endregion


	#region KSP Events

		[KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Turn Collector Off")]
		public void toggleFilter()
		{
			if (this.intakeActive)
			{
				filterOff();
			}
			else
			{
				filterOn();
			}
		}

		#endregion


	#region Unity Life Cycle

		public void FixedUpdate()
		{
			if (!HighLogic.LoadedSceneIsFlight) return;
			if (!this.intakeActive) return;

			{
				this.ammount = ((this.part.vessel.atmDensity * -0.20) - 0.0025) * TimeWarp.fixedDeltaTime;
				this.intakeStatus = this.ammount < .000001 ? "Iddle" : "Scooping";
				part.RequestResource("HydrogenProtium", ammount);
			}
		}

	#endregion


	#region Public Interface

		public void filterOn()
		{
			this.intakeActive = true;
			this.UpdateGui();
		}

		public void filterOff()
		{
			this.intakeActive = false;
			this.UpdateGui();
		}

	#endregion


		private void UpdateGui()
		{
			this.intakeStatus = this.intakeActive ? "Active" : "Inactive";
			Events["toggleSafety"].guiName = this.intakeActive ? "Turn Collector On" : "Turn Collector Off";
		}

	}
}
