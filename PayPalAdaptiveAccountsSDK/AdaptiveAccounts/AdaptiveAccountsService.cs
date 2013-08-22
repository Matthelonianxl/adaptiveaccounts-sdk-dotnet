using System;
using System.Collections.Generic;
using System.Xml;
using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.NVP;
using PayPal.AdaptiveAccounts.Model;

namespace PayPal.AdaptiveAccounts 
{
	public partial class AdaptiveAccountsService : BasePayPalService 
	{

		/// <summary>
		/// Service Version
		/// </summary>
		private const string ServiceVersion = "1.2.0";

		/// <summary>
		/// Service Name
		/// </summary>
		private const string ServiceName = "AdaptiveAccounts";
		
		/// <summary>
		/// SDK Name
		/// </summary>
		private const string SDKName = "adaptiveaccounts-dotnet-sdk";
	
		/// <summary>
		/// SDK Version
		/// </summary>
		private const string SDKVersion = "2.5.106";

		/// <summary>
		/// Default constructor for loading configuration from *.Config file
		/// </summary>
		public AdaptiveAccountsService() : base() {}
		
		/// <summary>
		/// constructor for passing in a dynamic configuration object
		/// </summary>
		public AdaptiveAccountsService(Dictionary<string, string> config) : base(config) {}
		

		/// <summary>
		/// Coutries Supported:
		/// AU - Australia
		/// CA - Canada
		/// CY - Cyprus
		/// CZ - Czech Republic
		/// DK - Denmark
		/// EE - Estonia
		/// FI - Finland
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HU - Hungary
		/// IT - Italy
		/// LV - Latvia
		/// LT - Lithuania
		/// LU - Luxembourg
		/// MT - Malta
		/// NL - Netherlands
		/// PL - Poland
		/// PT - Portugal
		/// SK - Slovak Republic
		/// SI - Slovenia
		/// ES - Spain
		/// SE - Sweden
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="createAccountRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, createAccountRequest.ToNVPString(string.Empty), ServiceName, "CreateAccount", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return CreateAccountResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// Coutries Supported:
		/// AU - Australia
		/// CA - Canada
		/// CY - Cyprus
		/// CZ - Czech Republic
		/// DK - Denmark
		/// EE - Estonia
		/// FI - Finland
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HU - Hungary
		/// IT - Italy
		/// LV - Latvia
		/// LT - Lithuania
		/// LU - Luxembourg
		/// MT - Malta
		/// NL - Netherlands
		/// PL - Poland
		/// PT - Portugal
		/// SK - Slovak Republic
		/// SI - Slovenia
		/// ES - Spain
		/// SE - Sweden
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="createAccountRequest"></param>
	 	
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest)
	 	{
	 		return CreateAccount(createAccountRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// Coutries Supported:
		/// AU - Australia
		/// CA - Canada
		/// CY - Cyprus
		/// CZ - Czech Republic
		/// DK - Denmark
		/// EE - Estonia
		/// FI - Finland
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HU - Hungary
		/// IT - Italy
		/// LV - Latvia
		/// LT - Lithuania
		/// LU - Luxembourg
		/// MT - Malta
		/// NL - Netherlands
		/// PL - Poland
		/// PT - Portugal
		/// SK - Slovak Republic
		/// SI - Slovenia
		/// ES - Spain
		/// SE - Sweden
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="createAccountRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, createAccountRequest.ToNVPString(string.Empty), ServiceName, "CreateAccount", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return CreateAccountResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// CA - Canada
		/// CZ - Czech Republic
		/// EU - European Union *
		/// FR - France
		/// DE - Germany
		/// GB - Great Britain
		/// GR - Greece
		/// IE - Ireland
		/// IL - Israel
		/// IT - Italy
		/// JP - Japan
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// US - United States
		/// * technically a group of countries
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="getUserAgreementRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest getUserAgreementRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getUserAgreementRequest.ToNVPString(string.Empty), ServiceName, "GetUserAgreement", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return GetUserAgreementResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// CA - Canada
		/// CZ - Czech Republic
		/// EU - European Union *
		/// FR - France
		/// DE - Germany
		/// GB - Great Britain
		/// GR - Greece
		/// IE - Ireland
		/// IL - Israel
		/// IT - Italy
		/// JP - Japan
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// US - United States
		/// * technically a group of countries
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="getUserAgreementRequest"></param>
	 	
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest getUserAgreementRequest)
	 	{
	 		return GetUserAgreement(getUserAgreementRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// CA - Canada
		/// CZ - Czech Republic
		/// EU - European Union *
		/// FR - France
		/// DE - Germany
		/// GB - Great Britain
		/// GR - Greece
		/// IE - Ireland
		/// IL - Israel
		/// IT - Italy
		/// JP - Japan
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// US - United States
		/// * technically a group of countries
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="getUserAgreementRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest getUserAgreementRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getUserAgreementRequest.ToNVPString(string.Empty), ServiceName, "GetUserAgreement", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return GetUserAgreementResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// All countries are supported.
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="getVerifiedStatusRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest getVerifiedStatusRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getVerifiedStatusRequest.ToNVPString(string.Empty), ServiceName, "GetVerifiedStatus", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return GetVerifiedStatusResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// All countries are supported.
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="getVerifiedStatusRequest"></param>
	 	
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest getVerifiedStatusRequest)
	 	{
	 		return GetVerifiedStatus(getVerifiedStatusRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// All countries are supported.
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="getVerifiedStatusRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest getVerifiedStatusRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, getVerifiedStatusRequest.ToNVPString(string.Empty), ServiceName, "GetVerifiedStatus", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return GetVerifiedStatusResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// Countries Supported:
		/// AU - Australia
		/// CA - Canada
		/// FR - France
		/// DE - Germany
		/// IL - Israel
		/// IT - Italy
		/// NL - Netherlands
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addBankAccountRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest addBankAccountRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, addBankAccountRequest.ToNVPString(string.Empty), ServiceName, "AddBankAccount", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return AddBankAccountResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// Countries Supported:
		/// AU - Australia
		/// CA - Canada
		/// FR - France
		/// DE - Germany
		/// IL - Israel
		/// IT - Italy
		/// NL - Netherlands
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addBankAccountRequest"></param>
	 	
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest addBankAccountRequest)
	 	{
	 		return AddBankAccount(addBankAccountRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// Countries Supported:
		/// AU - Australia
		/// CA - Canada
		/// FR - France
		/// DE - Germany
		/// IL - Israel
		/// IT - Italy
		/// NL - Netherlands
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addBankAccountRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest addBankAccountRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, addBankAccountRequest.ToNVPString(string.Empty), ServiceName, "AddBankAccount", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return AddBankAccountResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// BE - Belgium
		/// BR - Brazil
		/// CA - Canada
		/// CZ - Czech Republic
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HK - Hong Kong
		/// IE - Ireland
		/// IT - Italy
		/// JP - Japan
		/// LU - Luxembourg
		/// MX - Mexico
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addPaymentCardRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest addPaymentCardRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, addPaymentCardRequest.ToNVPString(string.Empty), ServiceName, "AddPaymentCard", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return AddPaymentCardResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// BE - Belgium
		/// BR - Brazil
		/// CA - Canada
		/// CZ - Czech Republic
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HK - Hong Kong
		/// IE - Ireland
		/// IT - Italy
		/// JP - Japan
		/// LU - Luxembourg
		/// MX - Mexico
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addPaymentCardRequest"></param>
	 	
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest addPaymentCardRequest)
	 	{
	 		return AddPaymentCard(addPaymentCardRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// BE - Belgium
		/// BR - Brazil
		/// CA - Canada
		/// CZ - Czech Republic
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HK - Hong Kong
		/// IE - Ireland
		/// IT - Italy
		/// JP - Japan
		/// LU - Luxembourg
		/// MX - Mexico
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addPaymentCardRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest addPaymentCardRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, addPaymentCardRequest.ToNVPString(string.Empty), ServiceName, "AddPaymentCard", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return AddPaymentCardResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// To be updated.
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// BE - Belgium
		/// BR - Brazil
		/// CA - Canada
		/// CZ - Czech Republic
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HK - Hong Kong
		/// IE - Ireland
		/// IT - Italy
		/// JP - Japan
		/// LU - Luxembourg
		/// MX - Mexico
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="setFundingSourceConfirmedRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest setFundingSourceConfirmedRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, setFundingSourceConfirmedRequest.ToNVPString(string.Empty), ServiceName, "SetFundingSourceConfirmed", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return SetFundingSourceConfirmedResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// To be updated.
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// BE - Belgium
		/// BR - Brazil
		/// CA - Canada
		/// CZ - Czech Republic
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HK - Hong Kong
		/// IE - Ireland
		/// IT - Italy
		/// JP - Japan
		/// LU - Luxembourg
		/// MX - Mexico
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="setFundingSourceConfirmedRequest"></param>
	 	
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest setFundingSourceConfirmedRequest)
	 	{
	 		return SetFundingSourceConfirmed(setFundingSourceConfirmedRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// To be updated.
		/// Countries Supported:
		/// AU - Australia
		/// AT - Austria  
		/// BE - Belgium
		/// BR - Brazil
		/// CA - Canada
		/// CZ - Czech Republic
		/// FR - France
		/// DE - Germany
		/// GR - Greece
		/// HK - Hong Kong
		/// IE - Ireland
		/// IT - Italy
		/// JP - Japan
		/// LU - Luxembourg
		/// MX - Mexico
		/// NL - Netherlands
		/// NZ - New Zealand (Aotearoa)
		/// PL - Poland
		/// PT - Portugal
		/// RU - Russian Federation
		/// SG - Singapore
		/// ZA - South Africa
		/// ES - Spain
		/// CH - Switzerland  
		/// UK - United Kingdom
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="setFundingSourceConfirmedRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest setFundingSourceConfirmedRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, setFundingSourceConfirmedRequest.ToNVPString(string.Empty), ServiceName, "SetFundingSourceConfirmed", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return SetFundingSourceConfirmedResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// To be updated.
		/// Countries Supported:
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="checkComplianceStatusRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest checkComplianceStatusRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, checkComplianceStatusRequest.ToNVPString(string.Empty), ServiceName, "CheckComplianceStatus", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return CheckComplianceStatusResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// To be updated.
		/// Countries Supported:
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="checkComplianceStatusRequest"></param>
	 	
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest checkComplianceStatusRequest)
	 	{
	 		return CheckComplianceStatus(checkComplianceStatusRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// To be updated.
		/// Countries Supported:
		/// US - United States
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="checkComplianceStatusRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest checkComplianceStatusRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, checkComplianceStatusRequest.ToNVPString(string.Empty), ServiceName, "CheckComplianceStatus", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return CheckComplianceStatusResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// To be updated.
		/// Countries Supported:
		/// US - United States
		/// Supported FinancialProduct: PayPal netSpend Master Prepaid
		/// Card
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addPartnerFinancialProductRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public AddPartnerFinancialProductResponse AddPartnerFinancialProduct(AddPartnerFinancialProductRequest addPartnerFinancialProductRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, addPartnerFinancialProductRequest.ToNVPString(string.Empty), ServiceName, "AddPartnerFinancialProduct", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return AddPartnerFinancialProductResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// To be updated.
		/// Countries Supported:
		/// US - United States
		/// Supported FinancialProduct: PayPal netSpend Master Prepaid
		/// Card
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addPartnerFinancialProductRequest"></param>
	 	
	 	public AddPartnerFinancialProductResponse AddPartnerFinancialProduct(AddPartnerFinancialProductRequest addPartnerFinancialProductRequest)
	 	{
	 		return AddPartnerFinancialProduct(addPartnerFinancialProductRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// To be updated.
		/// Countries Supported:
		/// US - United States
		/// Supported FinancialProduct: PayPal netSpend Master Prepaid
		/// Card
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="addPartnerFinancialProductRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public AddPartnerFinancialProductResponse AddPartnerFinancialProduct(AddPartnerFinancialProductRequest addPartnerFinancialProductRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, addPartnerFinancialProductRequest.ToNVPString(string.Empty), ServiceName, "AddPartnerFinancialProduct", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return AddPartnerFinancialProductResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// To Activate POS - For a POC - Internal Purposes
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="activateProductRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public ActivateProductResponse ActivateProduct(ActivateProductRequest activateProductRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, activateProductRequest.ToNVPString(string.Empty), ServiceName, "ActivateProduct", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return ActivateProductResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// To Activate POS - For a POC - Internal Purposes
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="activateProductRequest"></param>
	 	
	 	public ActivateProductResponse ActivateProduct(ActivateProductRequest activateProductRequest)
	 	{
	 		return ActivateProduct(activateProductRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// To Activate POS - For a POC - Internal Purposes
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="activateProductRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public ActivateProductResponse ActivateProduct(ActivateProductRequest activateProductRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, activateProductRequest.ToNVPString(string.Empty), ServiceName, "ActivateProduct", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return ActivateProductResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}

		/// <summary>
		/// To Update the Compliance Status (CIP, KYC, EDD) called from
		/// Authorized Third Party Vendor.
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="updateComplianceStatusRequest"></param>
		///<param name="apiUserName">API Username that you want to authenticate this call against. This username and the corresponding 3-token/certificate credentials must be available in Web.Config/App.Config</param>
	 	public UpdateComplianceStatusResponse UpdateComplianceStatus(UpdateComplianceStatusRequest updateComplianceStatusRequest, string apiUserName)
	 	{	 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, updateComplianceStatusRequest.ToNVPString(string.Empty), ServiceName, "UpdateComplianceStatus", apiUserName, getAccessToken(), getAccessTokenSecret());
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";
			
			NVPUtil util = new NVPUtil();
			return UpdateComplianceStatusResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	 
	 	/// <summary> 
		/// To Update the Compliance Status (CIP, KYC, EDD) called from
		/// Authorized Third Party Vendor.
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="updateComplianceStatusRequest"></param>
	 	
	 	public UpdateComplianceStatusResponse UpdateComplianceStatus(UpdateComplianceStatusRequest updateComplianceStatusRequest)
	 	{
	 		return UpdateComplianceStatus(updateComplianceStatusRequest,(string) null);
	 	}
	 	
	 	/// <summary>
		/// To Update the Compliance Status (CIP, KYC, EDD) called from
		/// Authorized Third Party Vendor.
		/// 
		/// 
		/// 
		/// 
		/// 
	 	/// </summary>
		///<param name="updateComplianceStatusRequest"></param>
		///<param name="credential">An explicit ICredential object that you want to authenticate this call against</param> 
	 	public UpdateComplianceStatusResponse UpdateComplianceStatus(UpdateComplianceStatusRequest updateComplianceStatusRequest, ICredential credential)
	 	{	 			 		
			IAPICallPreHandler apiCallPreHandler = new PlatformAPICallPreHandler(this.config, updateComplianceStatusRequest.ToNVPString(string.Empty), ServiceName, "UpdateComplianceStatus", credential);
	   	 	((PlatformAPICallPreHandler) apiCallPreHandler).SDKName = SDKName;
			((PlatformAPICallPreHandler) apiCallPreHandler).SDKVersion = SDKVersion;
			((PlatformAPICallPreHandler) apiCallPreHandler).PortName = "AdaptiveAccounts";

			NVPUtil util = new NVPUtil();
			return UpdateComplianceStatusResponse.CreateInstance(util.ParseNVPString(Call(apiCallPreHandler)), string.Empty, -1);
			
	 	}
	}
}
