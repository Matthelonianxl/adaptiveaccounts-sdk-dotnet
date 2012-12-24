This repository contains the PayPal Adaptive Accounts SDK C#.NET Class Library Application and the AdaptiveAccountsSampleApp Sample ASP.NET C# Web Application.

SDK Integration
---------------
*	Create a new ASP.NET Web Application with appropriate web application and solution name

*	Execute 'AdaptiveAccounts.bat' batch commands to ensure that the Adaptive Accounts stubs are up-to-date 
	[Note: Also ensure that the path to 'devenv.com' in 'AdaptiveAccounts.bat' file is correct as per the Visual Studio installation]
	
*	Add reference to 'PayPal_AdaptiveAccounts_SDK.dll'

*	Add reference to 'PayPal_Core_SDK.dll'

*	Namespaces to be used
	•	PayPal
	•	PayPal.AdaptiveAccounts
	•	PayPal.AdaptiveAccounts.Model
	•	PayPal.Util
	•	PayPal.Exception

	
Files
-----
*	AdaptiveAccounts.bat - Automation script that builds the PayPal Adaptive Accounts SDK C#.NET Class Library Application in release mode and copies the built dlls to the lib folder in the AdaptiveAccountsSampleApp Sample ASP.NET C# Web Application

*	Changelog.txt - Release Notes

*	DotNetSDK.SandcastleGUI - Tool to create the documentation of the PayPal Adaptive Accounts SDK

*	LICENSE.txt - PayPal, Inc. SDK License

*	Integrating NuGet with Visual Studio 2005 and 2008.pdf - Guide to Integrate NuGet with Visual Studio 2005 and 2008

*	Installing NuGet in Visual Studio 2010 and 2012.pdf - Guide to Integrate NuGet with Visual Studio 2005 and 2008