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

The following file layout must be present after installation:

```
<KSP_ROOT>
	[GameData]
		[000_KSPAPIExtensions]
			...
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
			[Plugins]
				...
			[patches]
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

* KSPAPIExtensions /L [2.1.0.15](https://github.com/net-lisias-ksp/KSPAPIExtensions/releases/tag/RELEASE%2F2.1.0.15) (for KSP >= 1.2.2 - yeah, anything goes) 
* [TweakScale](https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*/)
	+ For KSP 1.3.1, please use [V2.3.7](https://www.curseforge.com/kerbal/ksp-mods/tweakscale/files/2490393) .
	+ For KSP 1.4 or later, use the [latest](https://www.curseforge.com/kerbal/ksp-mods/tweakscale/files).
* [Module Manager](https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*)
	+ Currently, the latest is 4.0.2
		- [Download](https://ksp.sarbian.com/jenkins/job/ModuleManager/149/artifact/ModuleManager-4.0.2.zip) for KSP >= 1.4
		- [Download](https://ksp.sarbian.com/jenkins/job/ModuleManager-RO/8/artifact/ModuleManager-4.0.2.zip) for KSP 1.3.1 	

