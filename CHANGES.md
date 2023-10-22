# Impossible Innovations :: Changes

* 2023-1021: 0.8.10.0 (Lisias) for KSP >= 1.3.1
	+ The KSP 1.6.0 patch to allow bulkheadless parts to be used was moved to KSP-Recall
		- It's not needed anymore, anyway
	+ Updating models from the archaic `DAE` to the standard `mu` format.
		- `II-hydrogenIsotopeConverter` 
		- `II-hydrogenTank`
		- Also fixes the "jumping" when launching crafts with these parts!
	+ Adds missing data on all parts
	+ Fixes the plumes for
		- `II-TDRCS-Lin`
		- `II-TDRCS-Block`
	+ Updated to use the latest `KSPe`
	+ Removes annoying messages about not able to create config from some files.
	+ Closes issues:
		- [#8](https://github.com/net-lisias-ksp/ImpossibleInnovations/issues/8) Normalise formatting and added missing info on all parts
		- [#2](https://github.com/net-lisias-ksp/ImpossibleInnovations/issues/2) Some engines are exhausting the wrong way! Revise the engines.
		- [#1](https://github.com/net-lisias-ksp/ImpossibleInnovations/issues/1) Some parts are triggering the "damned jump from the Krakens" on launch
* 2020-0724: 0.8.9.0 (Lisias) for KSP >= 1.3.1
	+ TweakScale support overhaul
	+ Part overhaul:
		- Refactored the parts to reuse Stock assets. Now II looks closer to the KSP you are running!
			- Smaller package to download as bonus. 
		- Reworked the Part Categorisation to mimic modern KSP.
	+ Code Overhaul
		- Paving the way for seamless supporting new parts 
		- Paving the way to support previous KSP versions, and shielding the Add'On from eventual changes on future ones.
	+ KSPe 2.2 or later required.
