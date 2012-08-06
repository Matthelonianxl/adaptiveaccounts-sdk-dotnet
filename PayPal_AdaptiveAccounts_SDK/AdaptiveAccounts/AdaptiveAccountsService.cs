using PayPal;
using PayPal.Authentication;
using PayPal.Util;
using PayPal.Manager;
using PayPal.AdaptiveAccounts.Model;

namespace PayPal.AdaptiveAccounts {
	public partial class AdaptiveAccountsService : BasePayPalService {

		// Service Version
		private static string ServiceVersion = "1.0.3";

		// Service Name
		private static string ServiceName = "AdaptiveAccounts";

		public AdaptiveAccountsService() : base(ServiceName, ServiceVersion)
		{
		}

		/**	
          * Coutries Supported:
          *     AU - Australia
          *     CA - Canada
          *     CY - Cyprus
          *     CZ - Czech Republic
          *     DK - Denmark
          *     EE - Estonia
          *     FI - Finland
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HU - Hungary
          *     IT - Italy
          *     LV - Latvia
          *     LT - Lithuania
          *     LU - Luxembourg
          *     MT - Malta
          *     NL - Netherlands
          *     PL - Poland
          *     PT - Portugal
          *     SK - Slovak Republic
          *     SI - Slovenia
          *     ES - Spain
          *     SE - Sweden
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest CreateAccountRequest, string apiUsername)
	 	{
			string resp = call("CreateAccount", CreateAccountRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return CreateAccountResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          * Coutries Supported:
          *     AU - Australia
          *     CA - Canada
          *     CY - Cyprus
          *     CZ - Czech Republic
          *     DK - Denmark
          *     EE - Estonia
          *     FI - Finland
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HU - Hungary
          *     IT - Italy
          *     LV - Latvia
          *     LT - Lithuania
          *     LU - Luxembourg
          *     MT - Malta
          *     NL - Netherlands
          *     PL - Poland
          *     PT - Portugal
          *     SK - Slovak Republic
          *     SI - Slovenia
          *     ES - Spain
          *     SE - Sweden
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest CreateAccountRequest)
	 	{
	 		return CreateAccount(CreateAccountRequest, null);
	 	}

		/**	
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     CA - Canada
          *     CZ - Czech Republic
          *     EU - European Union *
          *     FR - France
          *     DE - Germany
          *     GB - Great Britain
          *     GR - Greece
          *     IE - Ireland
          *     IL - Israel
          *     IT - Italy
          *     JP - Japan
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     US - United States
          *     * technically a group of countries
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest GetUserAgreementRequest, string apiUsername)
	 	{
			string resp = call("GetUserAgreement", GetUserAgreementRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetUserAgreementResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     CA - Canada
          *     CZ - Czech Republic
          *     EU - European Union *
          *     FR - France
          *     DE - Germany
          *     GB - Great Britain
          *     GR - Greece
          *     IE - Ireland
          *     IL - Israel
          *     IT - Italy
          *     JP - Japan
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     US - United States
          *     * technically a group of countries
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest GetUserAgreementRequest)
	 	{
	 		return GetUserAgreement(GetUserAgreementRequest, null);
	 	}

		/**	
          * All countries are supported.
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest GetVerifiedStatusRequest, string apiUsername)
	 	{
			string resp = call("GetVerifiedStatus", GetVerifiedStatusRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return GetVerifiedStatusResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          * All countries are supported.
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest GetVerifiedStatusRequest)
	 	{
	 		return GetVerifiedStatus(GetVerifiedStatusRequest, null);
	 	}

		/**	
          * Countries Supported:
          *     AU - Australia
          *     CA - Canada
          *     FR - France
          *     DE - Germany
          *     IL - Israel
          *     IT - Italy
          *     NL - Netherlands
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest AddBankAccountRequest, string apiUsername)
	 	{
			string resp = call("AddBankAccount", AddBankAccountRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return AddBankAccountResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          * Countries Supported:
          *     AU - Australia
          *     CA - Canada
          *     FR - France
          *     DE - Germany
          *     IL - Israel
          *     IT - Italy
          *     NL - Netherlands
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest AddBankAccountRequest)
	 	{
	 		return AddBankAccount(AddBankAccountRequest, null);
	 	}

		/**	
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest AddPaymentCardRequest, string apiUsername)
	 	{
			string resp = call("AddPaymentCard", AddPaymentCardRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return AddPaymentCardResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          * Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest AddPaymentCardRequest)
	 	{
	 		return AddPaymentCard(AddPaymentCardRequest, null);
	 	}

		/**	
          * To be updated.
          *    Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest SetFundingSourceConfirmedRequest, string apiUsername)
	 	{
			string resp = call("SetFundingSourceConfirmed", SetFundingSourceConfirmedRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return SetFundingSourceConfirmedResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          * To be updated.
          *    Countries Supported:
          *     AU - Australia
          *     AT - Austria  
          *     BE - Belgium
          *     BR - Brazil
          *     CA - Canada
          *     CZ - Czech Republic
          *     FR - France
          *     DE - Germany
          *     GR - Greece
          *     HK - Hong Kong
          *     IE - Ireland
          *     IT - Italy
          *     JP - Japan
          *     LU - Luxembourg
          *     MX - Mexico
          *     NL - Netherlands
          *     NZ - New Zealand (Aotearoa)
          *     PL - Poland
          *     PT - Portugal
          *     RU - Russian Federation
          *     SG - Singapore
          *     ZA - South Africa
          *     ES - Spain
          *     CH - Switzerland  
          *     UK - United Kingdom
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest SetFundingSourceConfirmedRequest)
	 	{
	 		return SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest, null);
	 	}

		/**	
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest CheckComplianceStatusRequest, string apiUsername)
	 	{
			string resp = call("CheckComplianceStatus", CheckComplianceStatusRequest.toNVPString(""), apiUsername);
			NVPUtil util = new NVPUtil();
			return CheckComplianceStatusResponse.createInstance(util.parseNVPString(resp), "", -1);
			
	 	}
	 
	 	/** 
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest CheckComplianceStatusRequest)
	 	{
	 		return CheckComplianceStatus(CheckComplianceStatusRequest, null);
	 	}
	}
}
