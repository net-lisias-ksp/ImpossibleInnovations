# Impossible Innovations :: Change Log

* 2019-0709: 0.8.8.5 (Lisias) for KSP >= 1.4
	+ Avoiding runtime problems on TweakScale
* 2019-0111: 0.8.8.4 (Lisias) for KSP >= 1.4
	+ Certified for use on KSP 1.5.x and 1.6.x series
	+ Added an option to turn off the II Category Filter on the Advanced Menu
		- Useful if you want to use [Community Category Filter](https://forum.kerbalspaceprogram.com/index.php?/topic/149840-discussion-community-category-kit/).
	+ Added `bulkheadProfiles` setting to parts missing it.
	+ Updated embedded dependencies to the latest.
* 2019-0110: 0.8.8.3 (Lisias) for KSP >= 1.4
	+ **DITCHED**
* 2018-1009: 0.8.8.2 (Lisias) for KSP 1.4
	+ New Parts!
	+ Renamed resources to avoid conflicts with CRP.
	+ New Filters.
	+ New Distribution sites
		- CurseForge
	+ Some bad decisions reverted. Sorry, my bad.
* 2018-0608: 0.8.8.1 (Lisias) for KSP 1.4
	+ No changes but "legal" ones.
	+ This is a (production) RELEASE. Version bumped.
* 2018-0605: 0.8.7.8 (Lisias) for KSP 1.4. PRE-RELEASE
	+ Bug Fix release:
		- Icons and Images were not being fetched from the right place.
	+ Unofficial (Pre) Release for KSP 1.4.x
	+ Somewhat tested, but not properly. Please report any issues.
* 2018-0509: 0.8.7.7 (Lisias) for KSP 1.4. PRE-RELEASE
	+ Unofficial (Pre) Release for KSP 1.4.x
	+ UNTESTED. Please report any issues.
	+ ModuleManager and TweakScale updated to latest.
* 2016-1103: 0.8.7.6 (JandCandO) for KSP 1.2, Other fixes
	+ 0.8.7.6:
		- Updated depended mods in package for those who aren't using CKAN
		- Recompiled code for KSP version 1.2
		- Increased hydrogen tank capacity from 2000 to 3000
		- Implemented a rough compatibility with the Community Tech Tree
		- Fixed some parts not loading in KSP 1.2
		- Re-assigned part VAB categories to make them easier to find in 1.2
		- Fixed TweakScale configs for the CL-20 Flea engine
		- Fixed TweakScale configs for the Dead Weight
* 2016-0802: 0.8.7.5 (JandCandO) for KSP 1.1.3
	+ Updated all dependent mods that come in package
	+ Code recompile for 1.1.3 (very late)
* 2016-0306: 0.8.7.4 (JandCandO) for KSP 1.0.4
	+ Nothing else changed.
* 2016-0305: 0.8.7.3 (JandCandO) for KSP 1.0.4
	+ Recomiled for KSP version 1.0.5. I know it's very late, but this will make the transition to 1.1 easier.
	+ Ion wings now have action groups for On, Off, and Toggle
	+ The Toggle Button is available in-flight
	+ New readouts for Ion Wing's State
	+ New behavior for Ion Wings:
		- When electricCharge runs out, the wings shut off
		- They must be manually re-activated to work again
	+ This is as opposed to the previous behavior, where they would rapidly switch on and off as electricCharge began trickling in
	+ The Tweakscale and Module Manager packages included in the package are up-to-date as well
* 2015-0818: 0.8.7.2 (JandCandO) for KSP 1.0.4
	+ The dead weight's bottom node's angle was 1 instead of -1. Hopefully that's all of them now. (I went through and checked).
	+ Updated Module Manager included in the package to version 2.6.7.
* 2015-0804: 0.8.7.1 (JandCandO) for KSP 1.0.4
	+ 0.8.7.1:
	+ Recomplie code for KSP version 1.0.4
	+ Latest versions of Module Manager and Tweakscale included
	+ The Tweakscale that comes with Impossible Innovations now only has configs for Impossible Innovations. If you want all the stock configs, go install Tweakscale.
* 2015-0525: 0.8.7 (JandCandO) for KSP 1.0.2
	+ The standard fusion engine is no longer buggy.
	+ All resources have a specific heat capacity value now.
* 2015-0524: 0.8.6 (JandCandO) for KSP 1.0.2
	+ 0.8.6:
	+ Plugin recompiled for KSP 1.0.2
	+ All bottom nodes corrected to an angle of -1 instead of 1
	+ New Ionized Wing varieties (delta, small delta, and boards A-C)
	+ Old Ion Wing moved to legacy folder. It will load in old ships, but is not visible in editor
	+ Ionized Wings now display their current lift and electric consumption
	+ Ionized Wings no longer explode when there is no electricCharge, now they set their lift to less than a normal wing's
	+ Editor scene filters for Impossible Innovations (with a little icon I made)
	+ all stock counterpart textures switched to .dds. Now I can edit them to stand out!
	+ Added a CL-20 booster that looks like Squad's "flea" booster
	+ Hydrogen intake is nerfed slightly
	+ Some .dds textures like the dense solar panel are edited to make them different from stock
	+ Tech tree that is compatible with KSP 1.0 - no longer needs TechManger
* 2015-0102: 0.8.5 (JandCandO) for KSP 0.90
	+ Added a CL-20 sepatron
	+ All code recompliled for KSP v0.90
	+ Fixed up the code for the hydrogen converter. There shouldn't be any more issues.
	+ Nerfed hydrogen intake to 1/4 of its previous performance.
* 2014-1124: 0.8 (JandCandO) for KSP 0.25
	+ Added a stable, but unbalanced tech tree, powered by TechManager!
	+ New models for aluminum strut, iridium strut, radial battery pack, and the x8 deuterium tank!
	+ Radial battery is now rescalable.
	+ Fixed the positions of a few placement nodes.
	+ All nodes are now size 1! That means no more massive 3-meter nodes on a tiny 1-meter part.
	+ Support for the Addon Version Checker by cybutek was added! It isn't in the release package, but the option to monitor the version of this mod is now available if you want to do it. Just install AVC.
	+ 4-Kerbal command pod now uses tritium instead of ElectricCharge for torque. The weak RTG is still in place, though.
	+ The 4-Kerbal command pod's IVA was removed due to weird clipping stuff while inside.
* 2014-1122: 0.7 (JandCandO) for KSP 0.25
	+ ADDED FEATURES:
```
Included TweakScale in Impossible Innovations. This drastically changed the part layout. Here's the new system:
    Engines:
        There are only 4 deuterium engines now; a standard model, a standard radial model, a High-Efficiency model, and a Low-Efficiency model.
        Added a new CL-20 booster and tweaked lots of the engine settings for all CL-20 boosters.
        ALL engines are fully rescalable from 0.625m to 7m.
    Tanks:
        There are now only 4 deuterium tanks, varying only in length.
        There are only 2 tritium tanks; a stackable and a radial type.
        ALL tanks are rescalable.
I added 2 new ships to the VAB ship selection; an Impossible Lander and The Impossible Missle of Doom.
There is now only 1 dead weight. The dead weight now has a resource called "Lead." Lead adds the correct amount of weight per unit (liter) added to the part. The larger the dead weight is upscaled, the more lead it can hold.
Engines can now be requested for testing in contracts.
There are now only 2 kind of rescalable parachutes; a top-stack one and a radial one.
Solar panels are rescalable.
TDRCS ports are now rescalable.
Poofing part is now rescalabe.
Both probe cores are now rescalable.
There is now only 1 kind of stackable battery pack.
```
	+ CHANGED FEATURES / NOTES:
```
THIS UPDATE WILL BREAK EVERY SHIP THAT USES IMPOSSIBLE INNOVATIONS PARTS, WITHOUT EXCEPTION.
I have left the hydrogen processing system, the reaction wheel system, and the ionized wing out of the TweakScale system for now. They will come eventually.
I played with lots of part prices and settings.
The command pod will never be rescalable, and neither will the struts.
I left the radial battery pack out of the TweakScale system because it will be replaced soon.
```
	+ REMOVED FEATURES:
```
Treeloader is no longer! I will be using TechManager in the next release.
I removed pretty much every engine and tank, except for the ones currently implemented.
Removed the Impossible Innovations Heavy craft from the VAB.
```
* 2014-1121: 0.6.2.1 (JandCandO) for KSP 0.25
	+ Changed GameData file name from "Impossible Innovations" to"ImpossibleInnovations." Very minor. Is intended to make it compatible with CKAN.
* 2014-1120: 0.6.2 (JandCandO) for KSP 0.25
	+ Recompiled for KSP v0.25.
	+ (Sorry for being a GitHub newb, I just discovered this release feature)

