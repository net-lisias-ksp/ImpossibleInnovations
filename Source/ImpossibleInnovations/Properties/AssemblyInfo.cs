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
using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.

[assembly: AssemblyTitle (ImpossibleInnovations.Constants.PLUGIN_ID)]
[assembly: AssemblyDescription ("")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany ("net.lisias.ksp")]
[assembly: AssemblyProduct ("")]
[assembly: AssemblyCopyright ("© 2016-18 jandcando, ©2018 Lisias T")]
[assembly: AssemblyTrademark ("")]
[assembly: AssemblyCulture ("")]

// The assembly version has the format "{Major}.{Minor}.{Build}.{Revision}".
// The form "{Major}.{Minor}.*" will automatically update the build and revision,
// and "{Major}.{Minor}.{Build}.*" will update just the revision.

[assembly: AssemblyVersion (ImpossibleInnovations.Version.Number)]
[assembly: AssemblyFileVersion(ImpossibleInnovations.Version.Number)]
[assembly: KSPAssembly(ImpossibleInnovations.Constants.PLUGIN_ID, ImpossibleInnovations.Version.major, ImpossibleInnovations.Version.minor)]

// The following attributes are used to specify the signing key for the assembly,
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]

[assembly: KSPAssemblyDependency("KSPe", 2, 2)]
