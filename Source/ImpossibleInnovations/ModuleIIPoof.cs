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
