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
