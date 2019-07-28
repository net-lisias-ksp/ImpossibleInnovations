/*
	This file is part of Impossible Innovations,
		(C) 2014-2018 : JandCandO https://spacedock.info/profile/jandcando
		(C) 2018-2019 Lisias T : http://lisias.net <support@lisias.net>

	Impossible Innovations is licensed as follows:

		* CC BY-NC-SA 4.0 : https://creativecommons.org/licenses/by-nc-sa/4.0/

	And you are allowed to choose the License that better suit your needs.

	Impossible Innovations is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the GNU General Public License 2.0
	along with Impossible Innovations. If not, see < https://creativecommons.org/>.
*/
using UnityEngine;

namespace ImpossibleInnovations
{
    public class ModuleIIHydrogenIntake : PartModule
    {
        [KSPField(guiActive = true, guiActiveEditor = false, guiName = "Active", isPersistant = true)]
        public bool intakeActive = true;

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "State", isPersistant = false)]
		public string intakeStatus = "Active";

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Scoop", isPersistant = false)]
		public double ammount = 0;

		#region Functions
		public void filterOn()
        {
			this.intakeActive = true;
			this.intakeStatus = "Active";
            Events["toggleFilter"].guiName = "Turn Collector Off";
        }

        public void filterOff()
        {
			this.intakeActive = false;
			this.intakeStatus = "Inactive";
            Events["toggleFilter"].guiName = "Turn Collector On";
        }

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

        public void FixedUpdate()
        {
			if (!HighLogic.LoadedSceneIsFlight) return;
			if (!this.intakeActive) return;
			
            {
				this.ammount = ((this.part.vessel.atmDensity * -0.20) - 0.0025) * TimeWarp.fixedDeltaTime;
				if (this.ammount < .000001) this.intakeStatus = "Iddle";
				else this.intakeStatus = "Scooping";
                part.RequestResource("HydrogenProtium", ammount);
            }
        }
    }
}
