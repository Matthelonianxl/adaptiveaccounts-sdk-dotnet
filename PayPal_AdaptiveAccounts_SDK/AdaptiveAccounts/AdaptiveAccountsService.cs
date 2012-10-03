using System.Xml;
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
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest, string apiUserName)
	 	{
			string response = Call("CreateAccount", createAccountRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return CreateAccountResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
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
	 	public CreateAccountResponse CreateAccount(CreateAccountRequest createAccountRequest)
	 	{
	 		return CreateAccount(createAccountRequest, null);
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
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest getUserAgreementRequest, string apiUserName)
	 	{
			string response = Call("GetUserAgreement", getUserAgreementRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetUserAgreementResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
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
	 	public GetUserAgreementResponse GetUserAgreement(GetUserAgreementRequest getUserAgreementRequest)
	 	{
	 		return GetUserAgreement(getUserAgreementRequest, null);
	 	}

		/**	
          * All countries are supported.
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest getVerifiedStatusRequest, string apiUserName)
	 	{
			string response = Call("GetVerifiedStatus", getVerifiedStatusRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return GetVerifiedStatusResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          * All countries are supported.
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public GetVerifiedStatusResponse GetVerifiedStatus(GetVerifiedStatusRequest getVerifiedStatusRequest)
	 	{
	 		return GetVerifiedStatus(getVerifiedStatusRequest, null);
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
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest addBankAccountRequest, string apiUserName)
	 	{
			string response = Call("AddBankAccount", addBankAccountRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return AddBankAccountResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
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
	 	public AddBankAccountResponse AddBankAccount(AddBankAccountRequest addBankAccountRequest)
	 	{
	 		return AddBankAccount(addBankAccountRequest, null);
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
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest addPaymentCardRequest, string apiUserName)
	 	{
			string response = Call("AddPaymentCard", addPaymentCardRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return AddPaymentCardResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
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
	 	public AddPaymentCardResponse AddPaymentCard(AddPaymentCardRequest addPaymentCardRequest)
	 	{
	 		return AddPaymentCard(addPaymentCardRequest, null);
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
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest setFundingSourceConfirmedRequest, string apiUserName)
	 	{
			string response = Call("SetFundingSourceConfirmed", setFundingSourceConfirmedRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return SetFundingSourceConfirmedResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
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
	 	public SetFundingSourceConfirmedResponse SetFundingSourceConfirmed(SetFundingSourceConfirmedRequest setFundingSourceConfirmedRequest)
	 	{
	 		return SetFundingSourceConfirmed(setFundingSourceConfirmedRequest, null);
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
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest checkComplianceStatusRequest, string apiUserName)
	 	{
			string response = Call("CheckComplianceStatus", checkComplianceStatusRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return CheckComplianceStatusResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
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
	 	public CheckComplianceStatusResponse CheckComplianceStatus(CheckComplianceStatusRequest checkComplianceStatusRequest)
	 	{
	 		return CheckComplianceStatus(checkComplianceStatusRequest, null);
	 	}

		/**	
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *    Supported FinancialProduct: PayPal netSpend Master
          *Prepaid Card
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPartnerFinancialProductResponse AddPartnerFinancialProduct(AddPartnerFinancialProductRequest addPartnerFinancialProductRequest, string apiUserName)
	 	{
			string response = Call("AddPartnerFinancialProduct", addPartnerFinancialProductRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return AddPartnerFinancialProductResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          * To be updated.
          *    Countries Supported:
          *     US - United States
          *    Supported FinancialProduct: PayPal netSpend Master
          *Prepaid Card
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public AddPartnerFinancialProductResponse AddPartnerFinancialProduct(AddPartnerFinancialProductRequest addPartnerFinancialProductRequest)
	 	{
	 		return AddPartnerFinancialProduct(addPartnerFinancialProductRequest, null);
	 	}

		/**	
          * To Activate POS - For a POC - Internal Purposes
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public ActivateProductResponse ActivateProduct(ActivateProductRequest activateProductRequest, string apiUserName)
	 	{
			string response = Call("ActivateProduct", activateProductRequest.ToNVPString(""), apiUserName);
			NVPUtil util = new NVPUtil();
			return ActivateProductResponse.CreateInstance(util.ParseNVPString(response), "", -1);
			
	 	}
	 
	 	/** 
          * To Activate POS - For a POC - Internal Purposes
          *   
          *   
          *   
          *   
          *  
	 	  */
	 	public ActivateProductResponse ActivateProduct(ActivateProductRequest activateProductRequest)
	 	{
	 		return ActivateProduct(activateProductRequest, null);
	 	}
	}
}
