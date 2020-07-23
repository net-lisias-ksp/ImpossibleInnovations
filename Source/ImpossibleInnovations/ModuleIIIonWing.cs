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
using UnityEngine;

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
			wingOn("Active");
		}

		[KSPAction("Wing Off")]
		public void actionWingOff(KSPActionParam param)
		{
			wingOff();
		}

		[KSPAction("Toggle Wing")]
		public void actionWingToggle(KSPActionParam param)
		{
			wingToggle();
		}

	#endregion


	#region KSP Events

		[KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Toggle Wing")]
		public void wingToggle()
		{
			if (wingActive)	wingOff();
			else			wingOn();
		}

	#endregion


	#region Attributes

		private ModuleLiftingSurface module;
		private float defaultdDeflectionLiftCoeff;

	#endregion


	#region KSP Life Cycle

		private void OnStart()
		{
			this.enabled = part.Modules.Contains("ModuleLiftingSurface");
			if (!this.enabled) return;

			this.module = this.part.Modules.GetModule<ModuleLiftingSurface>();
			this.defaultdDeflectionLiftCoeff = this.module.deflectionLiftCoeff;
		}

		private void FixedUpdate()
		{
			if (!HighLogic.LoadedSceneIsFlight) return;

			if (vessel.srfSpeed < 30 && wingActive) //if vessel speed is below 30 m/s, give full lift at no cost
			{
				wingOn("Below min. drain velocity");

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
				wingOn();

				this.wingElectricConsumption = (vessel.srfSpeed * vessel.atmDensity) / this.deflectionLiftCoeff; //electricCharge drain dependent on airspeed and atmospheric density. if either is 0, no electricCharge is drained
				part.RequestResource("ElectricCharge", TimeWarp.fixedDeltaTime * this.wingElectricConsumption);
				return;
			}

			// the wing is active (implying there is no electricCharge), then shut wing off
			wingOff("Not enough electricCharge!");
		}

	#endregion


	#region Public Interface

		public void wingOn(string status = "Active")
		{
			wingStatus = status;
			wingActive = true;

			this.module.deflectionLiftCoeff =
				this.deflectionLiftCoeff = this.defaultdDeflectionLiftCoeff * Constants.LIFT_MULTIPLIER;
		}

		public void wingOff(string status = "Inactive")
		{
			wingStatus = status;
			wingActive = false;

			wingElectricConsumption = 0;
			this.module.deflectionLiftCoeff =
				this.deflectionLiftCoeff = this.defaultdDeflectionLiftCoeff * Constants.LIFT_HANDICAP; //a bit less than a normal wing
		}

	#endregion


	}
}
