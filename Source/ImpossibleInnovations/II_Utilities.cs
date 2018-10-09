using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImpossibleInnovations
{
    public class II_Utilities
    {
        #region Borrowed Code
        //I borrowed this code from Karbonite, and made some changes
        public static double GetShipResourceAmount(Vessel vessel, string resName)
        {
			int amount = 0;
            if (vessel != null)
            {
                foreach (Part p in vessel.parts)
                {
                    if (p.Resources.Contains(resName))
                    {
						PartResource res = p.Resources[resName];
                        amount += (int)res.amount;
                    }
                }
            }
            return amount;
        }

        //I borrowed this code from Karbonite, and made some changes
        public static double GetShipResourceMaxAmount(Vessel vessel, string resName)
        {
			int maxAmount = 0;
            if (vessel != null)
            {
                foreach (Part p in vessel.parts)
                {
                    if (p.Resources.Contains(resName))
                    {
						PartResource res = p.Resources[resName];
                        maxAmount += (int)res.maxAmount;
                    }
                }
            }
            return maxAmount;
        }
        #endregion
    }
}
