# Impossible Innovations

This mod adds some late-game engines and tanks to the game. These parts are fusion-based or use advanced technologies.

Now under New Management by Lisias. :)


## Installation Instructions

To install, place the GameData folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
	+ Delete `<KSP_ROOT>/GameData/ImpossibleInnovations`
* Extract the package's `GameData\ImpossibleInnovations` folder into your KSP's as follows:
	+ `<PACKAGE>/GameData/ImpossibleInnovations` --> `<KSP_ROOT>/GameData/ImpossibleInnovations`
	+ `<PACKAGE>/Ships` --> `<KSP_ROOT>/Ships`
		- You can safely overwrite any old files.
* If (and only if) you **do not** have installed the full package from the Dependencies:
	+ `<PACKAGE>/GameData/TweakScale` --> `<KSP_ROOT>/GameData/TweakScale`
	+ `<PACKAGE>/GameData/000_KSPe.dll` --> `<KSP_ROOT>/GameData/000_KSPe.dll`
	+ `<PACKAGE>/GameData/ModuleManager.3.1.0.dll` --> `<KSP_ROOT>/GameData/ModuleManager.3.1.0.dll`

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[ImpossibleInnovations]
			[Parts]
				...
			[Plugins]
				...
			[Resources]
				...
			CHANGE_LOG.md
			II-TechTree.cfg
			II-TweakScale.cfg
			ImpossibleInnovations.version
			LICENSE
			LICENSE.CC_NC-SA-4_0
			LICENSE.SKL-1_0
			NOTICE
			README.md
		[TweakScale]
			[plugins]
				license.txt
				...
			DefaultScales.cfg
			...
		000_KSPe.dll
		ModuleManager.dll
		...
[Ships]
	[SPH]
		...
		Impossible Innovations_A.craft
		...
	[VAB]
		...
		Impossible Innovations_R.craft
		...
	KSP.log
	PastDatabase.cfg
	...
```

### Extras Content

* Patches : Optional Module Manager patches
	+ EDITOR_160.cfg : Patch to add a dummy `bulkheadProfiles` entry on parts without it, to allow these parts to be used in KSP 1.6 and newer.

### Dependencies

* [KSP API Extensions/L](https://github.com/net-lisias-ksp/KSPAPIExtensions) 2.1 or later
	+ Included
		- (do not overwrite if you download a new version from the Official Distribution Site)
* Module Manager 3.0.7 or later
	+ Included
		- Do not unzip this if you use my [Unofficial fork](https://github.com/net-lisias-kspu/ModuleManager). 
* [TweakScale](https://github.com/net-lisias-ksp/TweakScale) 2.4 or later
	+ Included
		- (do not overwrite if you download a new version from the Official Distribution Site)

