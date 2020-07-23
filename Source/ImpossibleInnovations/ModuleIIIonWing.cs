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
namespace ImpossibleInnovations
{
	public class ModuleIIIonWing : PartModule
	{
	#region KSPFields

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Electric Consumption", isPersistant = false)]
		public double wingElectricConsumption;

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Lift Coefficient", isPersistant = false)]
		public float deflectionLiftCoeff;

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Active", isPersistant = true)]
		public bool wingActive = true;

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Status", isPersistant = false)]
		public string wingStatus = "Active";

	#endregion


	#region Action Groups

		[KSPAction("Wing On")]
		public void actionWingOn(KSPActionParam param)
		{
			this.wingOn("Active");
		}

		[KSPAction("Wing Off")]
		public void actionWingOff(KSPActionParam param)
		{
			this.wingOff();
		}

		[KSPAction("Toggle Wing")]
		public void actionWingToggle(KSPActionParam param)
		{
			this.wingToggle();
		}

	#endregion


	#region KSP Events

		[KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Toggle Wing")]
		public void wingToggle()
		{
			if (this.wingActive)	this.wingOff();
			else					this.wingOn();
		}

	#endregion


	#region Attributes

		private ModuleLiftingSurface module = null;
		private float defaultdDeflectionLiftCoeff = 0f;

	#endregion


	#region KSP Life Cycle

		private void OnStart()
		{
			this.enabled = part.Modules.Contains("ModuleLiftingSurface");
			if (!this.enabled) return;
		}

		private void FixedUpdate()
		{
			if (!HighLogic.LoadedSceneIsFlight) return;
			if (null == this.module) this.OnFirstUpdate();

			if (vessel.srfSpeed < 30 && wingActive) //if vessel speed is below 30 m/s, give full lift at no cost
			{
				this.wingOn("Below min. drain velocity");

				this.wingElectricConsumption = 0;
				return;
			}

			if (!this.wingActive) //if !wingActive, then make sure it is off
			{
				this.wingOff(); // FixMe: this is really necessary?
				return;
			}

			double electrityAmount, electrityMaxAmount;
			Util.CalcShipResource(vessel, "ElectricCharge", out electrityAmount, out electrityMaxAmount);
			if ( electrityAmount >= this.wingElectricConsumption ) //if vessel is on and has enough electricity, wing is on
			{
				this.wingOn();

				this.wingElectricConsumption = (vessel.srfSpeed * vessel.atmDensity) / this.deflectionLiftCoeff; //electricCharge drain dependent on airspeed and atmospheric density. if either is 0, no electricCharge is drained
				this.part.RequestResource("ElectricCharge", TimeWarp.fixedDeltaTime * this.wingElectricConsumption);
				return;
			}

			// the wing is active (implying there is no electricCharge), then shut wing off
			wingOff("Not enough Electric Charge!");
		}

		private void OnFirstUpdate() // Simulated event
		{
			Log.dbg("OnFirtUpdate()");

			// Fetch the needed data on craft spawn, when anything that wanted to change something already did it.
			// Yeah, TweakScale. :)
			this.module = this.part.Modules.GetModule<ModuleLiftingSurface>();
			this.defaultdDeflectionLiftCoeff = this.module.deflectionLiftCoeff;

			Log.dbg("defaultdDeflectionLiftCoeff = {0}", this.defaultdDeflectionLiftCoeff);
		}

	#endregion


	#region Public Interface

		public void wingOn(string status = "Active")
		{
			this.wingStatus = status;
			this.wingActive = true;

			this.module.deflectionLiftCoeff =
				this.deflectionLiftCoeff = this.defaultdDeflectionLiftCoeff * Constants.LIFT_MULTIPLIER;
			Log.dbg("Wing On : deflectionLiftCoeff {0}", this.deflectionLiftCoeff);
		}

		public void wingOff(string status = "Inactive")
		{
			this.wingStatus = status;
			this.wingActive = false;

			this.wingElectricConsumption = 0;
			this.module.deflectionLiftCoeff =
				this.deflectionLiftCoeff = this.defaultdDeflectionLiftCoeff;
			Log.dbg("Wing Off : deflectionLiftCoeff {0}", this.deflectionLiftCoeff);
		}

	#endregion


	}
}
