# NUnit Test Project for ArcObjects
This is a simple NUnit3 Test Project for testing code, that is based on the [ArcObjects SDK 10.4.x](https://desktop.arcgis.com/en/system-requirements/10.4/arcobjects-sdk-system-requirements.htm). Please note, that ArcObjects this **not** the same as the [ArcGIS Runtime SDK](https://developers.arcgis.com/net/). ArcObjects is for customizing/extending the Desktop (ArcMap) and Server applications.



This project contains a pre-configured `SetUpFixture`, that initializes the desired license using the Esri `LicenseInitializer` found in the [SDK Community Examples](https://github.com/Esri/arcobjects-sdk-community-samples/blob/master/Net/Networks/LocationAllocationSolver/CSharp/LicenseInitializer.cs).