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
using System;
namespace ImpossibleInnovations
{
	public static class Util
	{

		public static void CalcShipResource(Vessel vessel, string resource, out double currentAmount, out double maxAmount)
		{
			currentAmount = maxAmount = 0f;
			int COUNT = vessel.parts.Count;
			for (int i = 0; i < COUNT; ++i)
			{
				Part p = vessel.parts[i];
				if (p.Resources.Contains(resource))
				{
					PartResource res = p.Resources[resource];
					currentAmount += (int)res.amount;
					currentAmount += (int)res.maxAmount;
				}
			}
		}

	}
}
