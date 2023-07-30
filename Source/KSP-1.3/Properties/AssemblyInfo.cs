using System.Reflection;
using System.Runtime.CompilerServices;

// Information about this assembly is defined by the following attributes. 
// Change them to the values specific to your project.

[assembly: AssemblyTitle (ImpossibleInnovations.KSP13.Constants.PLUGIN_ID)]
[assembly: AssemblyDescription ("KSP 1.3 Support for Impossible Innovations")]
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
[assembly: KSPAssembly(ImpossibleInnovations.KSP13.Constants.PLUGIN_ID, ImpossibleInnovations.Version.major, ImpossibleInnovations.Version.minor)]

// The following attributes are used to specify the signing key for the assembly, 
// if desired. See the Mono documentation for more information about signing.

//[assembly: AssemblyDelaySign(false)]
//[assembly: AssemblyKeyFile("")]
[assembly: KSPAssemblyDependency("KSPe", 2, 5)]
