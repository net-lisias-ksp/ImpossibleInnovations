using UnityEngine;

namespace ImpossibleInnovations
{
    public class ModuleIIPoof : PartModule
    {
		[KSPField(guiActive = true, guiActiveEditor = false, guiName = "Safety", isPersistant = true)]
		private bool _poofSafety = true;
        public string poofSafety
		{
			get => this._poofSafety ? "On" : "Off";
			set => this._poofSafety = "On" == value;
		}

		#region Functions
		public void poofSafetyOn()
        {
			this._poofSafety = true;
            Events["toggleSafety"].guiName = "Turn Safety Off";
        }

        public void poofSafetyOff()
        {
			this._poofSafety = false;
            Events["toggleSafety"].guiName = "Turn Safety On";
        }

        [KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Turn Safety Off")]
        public void toggleSafety()
        {
            if (this._poofSafety)   poofSafetyOff();
			else                    poofSafetyOn();
		}

		[KSPEvent(active = true, guiActive = true, guiActiveEditor = false, guiName = "Poof!")]
        public void poof()
        {
			if (this._poofSafety) return;
			
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
