/*
	This file is part of Impossible Innovations,
		© 2018-2023 : Lisias T : http://lisias.net <support@lisias.net>
		© 2014-2018 : JandCandO https://spacedock.info/profile/jandcando
	and it's doubled licensed to you under SKL-1.0 & GPL-2.0

	Impossible Innovations is licensed as follows:

	* Source Code and TweakScale Patches:
		+ SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
		+ GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt
		+ And you are allowed to choose the License that better suit your needs.
	* Models, Textures, Art & Configs:
		+ CC BY-NC-SA 4.0

	Impossible Innovations is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with Impossible Innovations. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with Impossible Innovations. If not, see <https://www.gnu.org/licenses/>.

	You should have received a copy of the Creative Commons 4.0 Attribution-NonCommercial-ShareAlike License
	along with Impossible Innovations. If not, see <https://creativecommons.org/licenses/by-nc-sa/4.0/>.
*/
using System.Reflection;

// Information about this assembly is defined by the following attributes.
// Change them to the values specific to your project.

[assembly: AssemblyTitle (ImpossibleInnovations.Constants.PLUGIN_ID)]
[assembly: AssemblyDescription ("This mod adds some late-game engines and tanks to the game. These parts are fusion-based or use advanced technologies.")]
[assembly: AssemblyConfiguration ("")]
[assembly: AssemblyCompany (ImpossibleInnovations.LegalMamboJambo.Company)]
[assembly: AssemblyProduct (ImpossibleInnovations.LegalMamboJambo.Product)]
[assembly: AssemblyCopyright (ImpossibleInnovations.LegalMamboJambo.Copyright)]
[assembly: AssemblyTrademark (ImpossibleInnovations.LegalMamboJambo.Trademark)]
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

[assembly: KSPAssemblyDependency("KSPe", 2, 5)]
[assembly: KSPAssemblyDependency("KSPe.UI", 2, 5)]
