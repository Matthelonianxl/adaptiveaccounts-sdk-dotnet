This repository contains .NET SDK and samples for PayPal Adaptive Accounts API.

Prerequisites:
--------------
*	Visual Studio 2005 or higher

SDK Integration:
----------------
*	Create a new ASP.NET Web Application with appropriate web application and solution name

*	Execute 'AdaptiveAccounts.bat' batch commands to ensure that the Adaptive Accounts stubs are up-to-date 
	[Note: Also ensure that the path to 'devenv.com' in 'AdaptiveAccounts.bat' file is correct as per Visual Studio installation]
	
*	Add reference to 'PayPal_AdaptiveAccounts_SDK.dll'

*	Add reference to 'PayPal_Core_SDK.dll'

*	Namespaces to be used
	•	PayPal
	•	PayPal.AdaptiveAccounts
	•	PayPal.AdaptiveAccounts.Model
	•	PayPal.Util
	•	PayPal.Exception
 
Web.config:
-----------
Please refer to the sample web.config file in 'AdaptiveAccountsSampleApp' sample application to configure the following
 
*	Configuration Sections
	•	paypal
	•	log4net

*	PayPal Settings
	•	endpoint
	•	connectionTimeout
	•	requestRetries
	•	IPAddress
	•	sandboxEmailAddress

*	PayPal (Multiple) Accounts API credentials
	•	apiUsername
	•	apiPassword
	•	applicationId
	•	apiSignature
	•	apiCertificate
	•	privateKeyPassword

Tools:
------
*	log4net.dll - included in 'lib' folder in 'PayPal_AdaptiveAccounts_SDK' project
	log4net is a tool to help output log statements to a variety of output targets.
	
*	ObjectDumper.cs - included in 'AdaptiveAccountsSampleApp' sample application
	ObjectDumper.cs is a nifty little utility class that you can use to dump the data within an object (It will walk the object graph to a specified depth which you can then output to console or a textWriter).

*	jQuery JavaScript Library - included in 'Content' folder in 'AdaptiveAccountsSampleApp' sample application
	This is a fast and concise JavaScript Library that simplifies HTML document traversing, event handling, animating, and Ajax interactions for rapid web development.