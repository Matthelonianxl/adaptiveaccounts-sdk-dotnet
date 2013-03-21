

# PayPal Adaptive Accounts SDK

The PayPal Adaptive Accounts API lets you build applications that create PayPal accounts and handle account management. The PayPal Adaptive Accounts SDK provides the following methods:

   * CreateAccount: Creates PayPal accounts.
   * AddBankAccount: Link bank accounts to PayPal accounts as funding sources.
   * AddPaymentCard: Link payment cards to PayPal accounts as funding sources.
   * SetFundingSourceConfirmed: Set the funding source to confirmed; they may set the account to PayPal Verified status.
   * GetVerifiedStatus: Verify PayPal accounts by matching account holder criteria such as the account holder’s email address.
   * Get User Agreement: The GetUserAgreement method lets you retrieve the user agreement for the customer to approve the new PayPal account.

## Prerequisites

   * Visual Studio 2005 or higher
   * .NET Framework 2.0 or higher
   * (Optional) NuGet 2.2 for managing dependencies

## Using the SDK

   To use the SDK in your application, you must
   
   * Get the PayPalAdaptiveAccountsSDK dll via NuGet or from the download bundle and add references to the PayPalAdaptiveAccountsSDK and PayPalCoreSDK libraries.
   * Configure your app as detailed in the configuration section.
   
## SDK Configuration

  An application that uses the PayPal SDKs can be configured in one of two ways -
  
  * Using the Web.Config / App.Config files.

	```html
    <configSections>
	<section name="paypal" type="PayPal.Manager.SDKConfigHandler, PayPalCoreSDK" />
	<section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
	</configSections>
	<!-- PayPal SDK config -->
	<paypal>
	<settings>
	    <add name="mode" value="sandbox"/>
	    <add name="sandboxEmailAddress" value="account@devportal.com"/>	    
	    <add name="connectionTimeout" value="30000"/>
	    .....
	</settings>
	<accounts>
	    <account apiUsername="jb-us-seller_api1.paypal.com" apiPassword="..." apiSignature="..."/>
	    <account apiUsername="enduser_biz_api1.gmail.com" apiPassword="..." apiCertificate="..." privateKeyPassword="..."/>
	</accounts>
	</paypal>
    ```
  
  * Or, by dynamically passing in a dictionary (that you can load from a database or as suits your needs).

    ```csharp
    Dictionary<string, string> config = new Dictionary<string, string>();
    config.Add("mode", "sandbox");
    config.Add("sandboxEmailAddress", "account@devportal.com");    
    config.Add("account1.apiUsername", "jb-us-seller_api1.paypal.com");
    config.Add("account1.apiPassword", "...");
    config.Add("account1.apiSignature", "...");

    AdaptiveAccountsService service = new  AdaptiveAccountsService(config);
    ```

## Links

   * [Installing NuGet in Visual Studio 2005 & 2008] (https://github.com/paypal/sdk-core-dotnet/wiki/Using-Nuget-in-Visual-Studio-2005-&-2008)
   * [Installing NuGet in Visual Studio 2010 & 2012] (https://github.com/paypal/sdk-core-dotnet/wiki/Using-Nuget-in-Visual-Studio-2010-&-2012)
