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
using System.Diagnostics;
using UnityEngine;
using Logger = KSPe.Util.Log.Logger;
using Level = KSPe.Util.Log.Level;

namespace ImpossibleInnovations
{
	internal static class Log
	{
		private static readonly Logger log = Logger.CreateForType<Startup>();

		internal static void init()
		{
			log.level =
#if DEBUG
                Level.TRACE
#else
				Level.INFO
#endif
				;
		}

		internal static void force(string msg, params object[] @params)
		{
			log.force(msg, @params);
		}

		internal static void info(string msg, params object[] @params)
		{
			log.info(msg, @params);
		}

		internal static void warn(string msg, params object[] @params)
		{
			log.warn(msg, @params);
		}

		internal static void detail(string msg, params object[] @params)
		{
			log.detail(msg, @params);
		}

		internal static void error(string msg, params object[] @params)
		{
			log.error(msg, @params);
		}

		public static void ex(MonoBehaviour offended, System.Exception e)
		{
			log.error(offended, e);
		}

		[ConditionalAttribute("DEBUG")]
		internal static void dbg(string msg, params object[] @params)
		{
			log.trace(msg, @params);
		}
	}
}
