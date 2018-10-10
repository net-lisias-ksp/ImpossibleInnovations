/*
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
using UnityEngine;

namespace ImpossibleInnovations
{
    public class ModuleIIPoof : PartModule
    {
        [KSPField(guiActive = true, guiActiveEditor = false, guiName = "Active", isPersistant = true)]
        public bool poofSafety = true;

		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Safety", isPersistant = false)]
		public string poofStatus;

		#region Functions
		public void poofSafetyOn()
        {
			this.poofSafety = true;
			this.poofStatus = "On";
            Events["toggleSafety"].guiName = "Turn Safety Off";
        }

        public void poofSafetyOff()
        {
			this.poofSafety = false;
			this.poofStatus = "OFF";
            Events["toggleSafety"].guiName = "Turn Safety On";
        }

        [KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Turn Safety Off")]
        public void toggleSafety()
        {
            if (this.poofSafety)   poofSafetyOff();
			else                    poofSafetyOn();
		}

		[KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Poof!")]
        public void poof()
        {
			if (this.poofSafety) return;
			
            this.part.explode();
        }
        #endregion

        #region Action Groups
        [KSPAction("Toggle Safety")]
        public void actionToggleSaftey(KSPActionParam param)
        {
            toggleSafety();
        }

        [KSPAction("Safety On")]
        public void actionSafteyOn(KSPActionParam param)
        {
            poofSafetyOn();
        }

        [KSPAction("Safety Off")]
        public void actionSafteyOff(KSPActionParam param)
        {
            poofSafetyOff();
        }

        [KSPAction("Poof!")]
        public void actionPoof(KSPActionParam param)
        {
            poof();
        }
        #endregion
    }
}
