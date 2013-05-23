/*
 * Stub objects for AdaptiveAccounts 
 * AUTO_GENERATED_CODE 
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml;
using PayPal.Util;

namespace PayPal.AdaptiveAccounts.Model
{

	/// <summary>
	/// Utility class for Enums with descriptions
	/// </summary>
	public static class EnumUtils
	{
		/// <summary>
		/// Get description for a give enum value
		/// </summary>	
		public static string GetDescription(Enum value)
		{
			string description = "";
			DescriptionAttribute[] attributes = (DescriptionAttribute[])value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
			{
				description= attributes[0].Description;
			}
			return description;
		}
		
		/// <summary>
		/// Convert a string to an enum object
		/// </summary>	
		public static object GetValue(string value,Type enumType)
		{
			string[] names = Enum.GetNames(enumType);
			foreach(string name in names)
            {
            	if (GetDescription((Enum)Enum.Parse(enumType, name)).Equals(value))
            	{
					return Enum.Parse(enumType, name);
				}
			}
			return null;
		}
	}


	/// <summary>
	/// This type contains the detailed error information resulting
	/// from the service operation. 
    /// </summary>
	public partial class ErrorData	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private int? errorIdField;
		public int? errorId
		{
			get
			{
				return this.errorIdField;
			}
			set
			{
				this.errorIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string domainField;
		public string domain
		{
			get
			{
				return this.domainField;
			}
			set
			{
				this.domainField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string subdomainField;
		public string subdomain
		{
			get
			{
				return this.subdomainField;
			}
			set
			{
				this.subdomainField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private ErrorSeverity? severityField;
		public ErrorSeverity? severity
		{
			get
			{
				return this.severityField;
			}
			set
			{
				this.severityField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private ErrorCategory? categoryField;
		public ErrorCategory? category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string messageField;
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string exceptionIdField;
		public string exceptionId
		{
			get
			{
				return this.exceptionIdField;
			}
			set
			{
				this.exceptionIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorParameter> parameterField = new List<ErrorParameter>();
		public List<ErrorParameter> parameter
		{
			get
			{
				return this.parameterField;
			}
			set
			{
				this.parameterField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ErrorData()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new ErrorData object created from the passed in NVP map
	 	/// </returns>
		public static ErrorData CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorData errorData = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "errorId";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.errorId = System.Convert.ToInt32(map[key]);
			}
			key = prefix + "domain";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.domain = map[key];
			}
			key = prefix + "subdomain";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.subdomain = map[key];
			}
			key = prefix + "severity";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.severity = (ErrorSeverity)EnumUtils.GetValue(map[key],typeof(ErrorSeverity));
			}
			key = prefix + "category";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.category = (ErrorCategory)EnumUtils.GetValue(map[key],typeof(ErrorCategory));
			}
			key = prefix + "message";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.message = map[key];
			}
			key = prefix + "exceptionId";
			if (map.ContainsKey(key))
			{
				errorData = (errorData == null) ? new ErrorData() : errorData;
				errorData.exceptionId = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorParameter parameter =  ErrorParameter.CreateInstance(map, prefix + "parameter", i);
				if (parameter != null)
				{
					errorData = (errorData == null) ? new ErrorData() : errorData;
					errorData.parameter.Add(parameter);
					i++;
				} 
				else
				{
					break;
				}
			}
			return errorData;
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class ErrorParameter	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string nameField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string valueField;
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ErrorParameter()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new ErrorParameter object created from the passed in NVP map
	 	/// </returns>
		public static ErrorParameter CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ErrorParameter errorParameter = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "name";
			if (map.ContainsKey(key))
			{
				errorParameter = (errorParameter == null) ? new ErrorParameter() : errorParameter;
				errorParameter.name = map[key];
			}
			key = prefix.Substring(0, prefix.Length - 1);
			if (map.ContainsKey(key))
			{
				errorParameter = (errorParameter == null) ? new ErrorParameter() : errorParameter;
				errorParameter.value = map[key];
			}
			return errorParameter;
		}
	}




	/// <summary>
	/// This specifies the list of parameters with every request to
	/// the service. 
    /// </summary>
	public partial class RequestEnvelope	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private DetailLevelCode? detailLevelField;
		public DetailLevelCode? detailLevel
		{
			get
			{
				return this.detailLevelField;
			}
			set
			{
				this.detailLevelField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string errorLanguageField;
		public string errorLanguage
		{
			get
			{
				return this.errorLanguageField;
			}
			set
			{
				this.errorLanguageField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public RequestEnvelope()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.detailLevel != null)
			{
					sb.Append(prefix).Append("detailLevel").Append("=").Append(EnumUtils.GetDescription(this.detailLevel));
					sb.Append("&");
			}
			if (this.errorLanguage != null)
			{
					sb.Append(prefix).Append("errorLanguage").Append("=").Append(HttpUtility.UrlEncode(this.errorLanguage, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// This specifies a list of parameters with every response from
	/// a service. 
    /// </summary>
	public partial class ResponseEnvelope	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string timestampField;
		public string timestamp
		{
			get
			{
				return this.timestampField;
			}
			set
			{
				this.timestampField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AckCode? ackField;
		public AckCode? ack
		{
			get
			{
				return this.ackField;
			}
			set
			{
				this.ackField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string correlationIdField;
		public string correlationId
		{
			get
			{
				return this.correlationIdField;
			}
			set
			{
				this.correlationIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string buildField;
		public string build
		{
			get
			{
				return this.buildField;
			}
			set
			{
				this.buildField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ResponseEnvelope()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new ResponseEnvelope object created from the passed in NVP map
	 	/// </returns>
		public static ResponseEnvelope CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ResponseEnvelope responseEnvelope = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "timestamp";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.timestamp = map[key];
			}
			key = prefix + "ack";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.ack = (AckCode)EnumUtils.GetValue(map[key],typeof(AckCode));
			}
			key = prefix + "correlationId";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.correlationId = map[key];
			}
			key = prefix + "build";
			if (map.ContainsKey(key))
			{
				responseEnvelope = (responseEnvelope == null) ? new ResponseEnvelope() : responseEnvelope;
				responseEnvelope.build = map[key];
			}
			return responseEnvelope;
		}
	}




	/// <summary>
	/// This elements in this type refers to the end user of the
	/// application invoking this service. 
    /// </summary>
	public partial class ClientDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string ipAddressField;
		public string ipAddress
		{
			get
			{
				return this.ipAddressField;
			}
			set
			{
				this.ipAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string deviceIdField;
		public string deviceId
		{
			get
			{
				return this.deviceIdField;
			}
			set
			{
				this.deviceIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string applicationIdField;
		public string applicationId
		{
			get
			{
				return this.applicationIdField;
			}
			set
			{
				this.applicationIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string modelField;
		public string model
		{
			get
			{
				return this.modelField;
			}
			set
			{
				this.modelField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string geoLocationField;
		public string geoLocation
		{
			get
			{
				return this.geoLocationField;
			}
			set
			{
				this.geoLocationField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string customerTypeField;
		public string customerType
		{
			get
			{
				return this.customerTypeField;
			}
			set
			{
				this.customerTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string partnerNameField;
		public string partnerName
		{
			get
			{
				return this.partnerNameField;
			}
			set
			{
				this.partnerNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string customerIdField;
		public string customerId
		{
			get
			{
				return this.customerIdField;
			}
			set
			{
				this.customerIdField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ClientDetailsType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.ipAddress != null)
			{
					sb.Append(prefix).Append("ipAddress").Append("=").Append(HttpUtility.UrlEncode(this.ipAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.deviceId != null)
			{
					sb.Append(prefix).Append("deviceId").Append("=").Append(HttpUtility.UrlEncode(this.deviceId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.applicationId != null)
			{
					sb.Append(prefix).Append("applicationId").Append("=").Append(HttpUtility.UrlEncode(this.applicationId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.model != null)
			{
					sb.Append(prefix).Append("model").Append("=").Append(HttpUtility.UrlEncode(this.model, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.geoLocation != null)
			{
					sb.Append(prefix).Append("geoLocation").Append("=").Append(HttpUtility.UrlEncode(this.geoLocation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerType != null)
			{
					sb.Append(prefix).Append("customerType").Append("=").Append(HttpUtility.UrlEncode(this.customerType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerName != null)
			{
					sb.Append(prefix).Append("partnerName").Append("=").Append(HttpUtility.UrlEncode(this.partnerName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerId != null)
			{
					sb.Append(prefix).Append("customerId").Append("=").Append(HttpUtility.UrlEncode(this.customerId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// This specifies a fault, encapsulating error data, with
	/// specific error codes. 
    /// </summary>
	public partial class FaultMessage	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public FaultMessage()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new FaultMessage object created from the passed in NVP map
	 	/// </returns>
		public static FaultMessage CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			FaultMessage faultMessage = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
				faultMessage.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					faultMessage = (faultMessage == null) ? new FaultMessage() : faultMessage;
					faultMessage.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return faultMessage;
		}
	}




	/// <summary>
	/// 
	/// </summary>
    [Serializable]
	public enum ErrorSeverity {
		[Description("Error")]ERROR,	
		[Description("Warning")]WARNING	
	}




	/// <summary>
	/// 
	/// </summary>
    [Serializable]
	public enum ErrorCategory {
		[Description("System")]SYSTEM,	
		[Description("Application")]APPLICATION,	
		[Description("Request")]REQUEST	
	}




	/// <summary>
	/// AckCodeType This code identifies the
	///  acknowledgement code types that could be used to
	///  communicate the status of processing a (request)
	///  message to an application. This code would be
	///  used as part of a response message that contains
	///  an application level acknowledgement element.
	///  
	/// </summary>
    [Serializable]
	public enum AckCode {
		[Description("Success")]SUCCESS,	
		[Description("Failure")]FAILURE,	
		[Description("Warning")]WARNING,	
		[Description("SuccessWithWarning")]SUCCESSWITHWARNING,	
		[Description("FailureWithWarning")]FAILUREWITHWARNING	
	}




	/// <summary>
	/// DetailLevelCodeType
	///  
	/// </summary>
    [Serializable]
	public enum DetailLevelCode {
		[Description("ReturnAll")]RETURNALL,	
		[Description("ReturnAttributes")]RETURNATTRIBUTES	
	}




	/// <summary>
	/// Bank account type should be CHECKING,
	///  SAVINGS,BUSINESS_CHECKING,
	///  BUSINESS_SAVINGS,NORMAL, or UNKNOWN.
	///  
	/// </summary>
    [Serializable]
	public enum BankAccountType {
		[Description("CHECKING")]CHECKING,	
		[Description("SAVINGS")]SAVINGS,	
		[Description("BUSINESS_CHECKING")]BUSINESSCHECKING,	
		[Description("BUSINESS_SAVINGS")]BUSINESSSAVINGS,	
		[Description("NORMAL")]NORMAL,	
		[Description("UNKNOWN")]UNKNOWN	
	}




	/// <summary>
	/// API confirmation type currently
	///  Valid values are: NONE, MOBILE and
	///  WEB. WEB: Returns a URL to complete the
	///  registration.
	///  
	/// </summary>
    [Serializable]
	public enum ConfirmationType {
		[Description("WEB")]WEB,	
		[Description("MOBILE")]MOBILE,	
		[Description("NONE")]NONE	
	}




	/// <summary>
	/// Business Types
	///  
	/// </summary>
    [Serializable]
	public enum BusinessType {
		[Description("ASSOCIATION")]ASSOCIATION,	
		[Description("CORPORATION")]CORPORATION,	
		[Description("GENERAL_PARTNERSHIP")]GENERALPARTNERSHIP,	
		[Description("GOVERNMENT")]GOVERNMENT,	
		[Description("INDIVIDUAL")]INDIVIDUAL,	
		[Description("LIMITED_LIABILITY_PARTNERSHIP")]LIMITEDLIABILITYPARTNERSHIP,	
		[Description("LIMITED_LIABILITY_PRIVATE_CORPORATION")]LIMITEDLIABILITYPRIVATECORPORATION,	
		[Description("LIMITED_LIABILITY_PROPRIETORS")]LIMITEDLIABILITYPROPRIETORS,	
		[Description("LIMITED_PARTNERSHIP")]LIMITEDPARTNERSHIP,	
		[Description("LIMITED_PARTNERSHIP_PRIVATE_CORPORATION")]LIMITEDPARTNERSHIPPRIVATECORPORATION,	
		[Description("NONPROFIT")]NONPROFIT,	
		[Description("OTHER_CORPORATE_BODY")]OTHERCORPORATEBODY,	
		[Description("PARTNERSHIP")]PARTNERSHIP,	
		[Description("PRIVATE_CORPORATION")]PRIVATECORPORATION,	
		[Description("PRIVATE_PARTNERSHIP")]PRIVATEPARTNERSHIP,	
		[Description("PROPRIETORSHIP")]PROPRIETORSHIP,	
		[Description("PROPRIETORSHIP_CRAFTSMAN")]PROPRIETORSHIPCRAFTSMAN,	
		[Description("PROPRIETARY_COMPANY")]PROPRIETARYCOMPANY,	
		[Description("PUBLIC_COMPANY")]PUBLICCOMPANY,	
		[Description("PUBLIC_CORPORATION")]PUBLICCORPORATION,	
		[Description("PUBLIC_PARTNERSHIP")]PUBLICPARTNERSHIP	
	}




	/// <summary>
	/// Subtype required only for Business Type GOVERNMENT and
	/// ASSOCIATION 
	///  GOVERNMENT: ENTITY, EMANATION,ESTD_COMMONWEALTH,
	/// ESTD_UNDER_STATE_TERRITORY, 
	///  ESTD_UNDER_FOREIGN_COUNTRY 
	///  ASSOCIATION: INCORPORATED, NON_INCORPORATED
	///  
	/// </summary>
    [Serializable]
	public enum BusinessSubtypeType {
		[Description("ENTITY")]ENTITY,	
		[Description("EMANATION")]EMANATION,	
		[Description("ESTD_COMMONWEALTH")]ESTDCOMMONWEALTH,	
		[Description("ESTD_UNDER_STATE_TERRITORY")]ESTDUNDERSTATETERRITORY,	
		[Description("ESTD_UNDER_FOREIGN_COUNTRY")]ESTDUNDERFOREIGNCOUNTRY,	
		[Description("INCORPORATED")]INCORPORATED,	
		[Description("NON_INCORPORATED")]NONINCORPORATED	
	}




	/// <summary>
	/// Sales venue / store front type
	///  
	/// </summary>
    [Serializable]
	public enum SalesVenueType {
		[Description("WEB")]WEB,	
		[Description("EBAY")]EBAY,	
		[Description("OTHER_MARKETPLACE")]OTHERMARKETPLACE,	
		[Description("OTHER")]OTHER	
	}




	/// <summary>
	/// Stake holder role 
	///  
	/// </summary>
    [Serializable]
	public enum StakeholderRoleType {
		[Description("CHAIRMAN")]CHAIRMAN,	
		[Description("SECRETARY")]SECRETARY,	
		[Description("TREASURER")]TREASURER,	
		[Description("BENEFICIAL_OWNER")]BENEFICIALOWNER,	
		[Description("PRIMARY_CONTACT")]PRIMARYCONTACT,	
		[Description("INDIVIDUAL_PARTNER")]INDIVIDUALPARTNER,	
		[Description("NON_INDIVIDUAL_PARTNER")]NONINDIVIDUALPARTNER,	
		[Description("PRIMARY_INDIVIDUAL_PARTNER")]PRIMARYINDIVIDUALPARTNER,	
		[Description("DIRECTOR")]DIRECTOR,	
		[Description("NO_BENEFICIAL_OWNER")]NOBENEFICIALOWNER	
	}




	/// <summary>
	/// SwitchMaestro, deprecated card type, use UKMaestro instead
	///              
	/// </summary>
    [Serializable]
	public enum CardTypeType {
		[Description("Visa")]VISA,	
		[Description("MasterCard")]MASTERCARD,	
		[Description("AmericanExpress")]AMERICANEXPRESS,	
		[Description("Discover")]DISCOVER,	
		[Description("SwitchMaestro")]SWITCHMAESTRO,	
		[Description("UKMaestro")]UKMAESTRO,	
		[Description("CarteAurore")]CARTEAURORE,	
		[Description("CarteBleue")]CARTEBLEUE,	
		[Description("Cofinoga")]COFINOGA,	
		[Description("4etoiles")]ETOILES,	
		[Description("CartaAura")]CARTAAURA,	
		[Description("TarjetaAurora")]TARJETAAURORA,	
		[Description("JCB")]JCB,	
		[Description("Maestro")]MAESTRO	
	}




	/// <summary>
	/// Generic Yes or No input validation type.
	///  
	/// </summary>
    [Serializable]
	public enum YesNoType {
		[Description("YES")]YES,	
		[Description("NO")]NO	
	}




	/// <summary>
	/// Government ID Types 
	///  
	/// </summary>
    [Serializable]
	public enum GovernmentIDTypes {
		[Description("SIN")]SIN	
	}




	/// <summary>
	/// Legal Agreement Types 
	///  
	/// </summary>
    [Serializable]
	public enum LegalAgreementTypes {
		[Description("FINANCIAL_BINDING_AUTHORITY")]FINANCIALBINDINGAUTHORITY	
	}




	/// <summary>
	/// 
	/// </summary>
    [Serializable]
	public enum ProductActivationErrors {
		[Description("NOT_ALLOWED")]NOTALLOWED,	
		[Description("MISSING_CC")]MISSINGCC,	
		[Description("MISSING_MOBILE_PHONE")]MISSINGMOBILEPHONE,	
		[Description("MISSING_PIN")]MISSINGPIN,	
		[Description("MOBILE_PHONE_NOT_ACTIVATED")]MOBILEPHONENOTACTIVATED,	
		[Description("PRODUCT_EXISTS")]PRODUCTEXISTS,	
		[Description("UNCONFIRMED_MOBILE")]UNCONFIRMEDMOBILE,	
		[Description("INTERNAL_ERROR")]INTERNALERROR	
	}




	/// <summary>
	/// Identifies a PayPal account to which this request is
	/// targeted. Caller of this API has to provide ONLY one of
	/// these inputs: emailAddress, accountId or phoneNumber. 
    /// </summary>
	public partial class AccountIdentifierType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string mobilePhoneNumberField;
		public string mobilePhoneNumber
		{
			get
			{
				return this.mobilePhoneNumberField;
			}
			set
			{
				this.mobilePhoneNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public AccountIdentifierType(string emailAddress, string mobilePhoneNumber, string accountId)
	 	{
			this.emailAddress = emailAddress;
			this.mobilePhoneNumber = mobilePhoneNumber;
			this.accountId = accountId;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AccountIdentifierType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.mobilePhoneNumber != null)
			{
					sb.Append(prefix).Append("mobilePhoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.mobilePhoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountId != null)
			{
					sb.Append(prefix).Append("accountId").Append("=").Append(HttpUtility.UrlEncode(this.accountId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Valid values are: Personal, Premier, and Business. Flag="2"
	/// corresponds to java.util.regex.Pattern.CASE_INSENSITIVE,
	/// meaning the strings are not case-sensitive 
    /// </summary>
	public partial class CreateAccountRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private ClientDetailsType clientDetailsField;
		public ClientDetailsType clientDetails
		{
			get
			{
				return this.clientDetailsField;
			}
			set
			{
				this.clientDetailsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountTypeField;
		public string accountType
		{
			get
			{
				return this.accountTypeField;
			}
			set
			{
				this.accountTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private NameType nameField;
		public NameType name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dateOfBirthField;
		public string dateOfBirth
		{
			get
			{
				return this.dateOfBirthField;
			}
			set
			{
				this.dateOfBirthField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AddressType addressField;
		public AddressType address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string contactPhoneNumberField;
		public string contactPhoneNumber
		{
			get
			{
				return this.contactPhoneNumberField;
			}
			set
			{
				this.contactPhoneNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string homePhoneNumberField;
		public string homePhoneNumber
		{
			get
			{
				return this.homePhoneNumberField;
			}
			set
			{
				this.homePhoneNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string mobilePhoneNumberField;
		public string mobilePhoneNumber
		{
			get
			{
				return this.mobilePhoneNumberField;
			}
			set
			{
				this.mobilePhoneNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string currencyCodeField;
		public string currencyCode
		{
			get
			{
				return this.currencyCodeField;
			}
			set
			{
				this.currencyCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string citizenshipCountryCodeField;
		public string citizenshipCountryCode
		{
			get
			{
				return this.citizenshipCountryCodeField;
			}
			set
			{
				this.citizenshipCountryCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string preferredLanguageCodeField;
		public string preferredLanguageCode
		{
			get
			{
				return this.preferredLanguageCodeField;
			}
			set
			{
				this.preferredLanguageCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string notificationURLField;
		public string notificationURL
		{
			get
			{
				return this.notificationURLField;
			}
			set
			{
				this.notificationURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string registrationTypeField;
		public string registrationType
		{
			get
			{
				return this.registrationTypeField;
			}
			set
			{
				this.registrationTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private CreateAccountWebOptionsType createAccountWebOptionsField;
		public CreateAccountWebOptionsType createAccountWebOptions
		{
			get
			{
				return this.createAccountWebOptionsField;
			}
			set
			{
				this.createAccountWebOptionsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private bool? suppressWelcomeEmailField;
		public bool? suppressWelcomeEmail
		{
			get
			{
				return this.suppressWelcomeEmailField;
			}
			set
			{
				this.suppressWelcomeEmailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private bool? performExtraVettingOnThisAccountField;
		public bool? performExtraVettingOnThisAccount
		{
			get
			{
				return this.performExtraVettingOnThisAccountField;
			}
			set
			{
				this.performExtraVettingOnThisAccountField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string taxIdField;
		public string taxId
		{
			get
			{
				return this.taxIdField;
			}
			set
			{
				this.taxIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string partnerField1Field;
		public string partnerField1
		{
			get
			{
				return this.partnerField1Field;
			}
			set
			{
				this.partnerField1Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string partnerField2Field;
		public string partnerField2
		{
			get
			{
				return this.partnerField2Field;
			}
			set
			{
				this.partnerField2Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string partnerField3Field;
		public string partnerField3
		{
			get
			{
				return this.partnerField3Field;
			}
			set
			{
				this.partnerField3Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string partnerField4Field;
		public string partnerField4
		{
			get
			{
				return this.partnerField4Field;
			}
			set
			{
				this.partnerField4Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string partnerField5Field;
		public string partnerField5
		{
			get
			{
				return this.partnerField5Field;
			}
			set
			{
				this.partnerField5Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BusinessInfoType businessInfoField;
		public BusinessInfoType businessInfo
		{
			get
			{
				return this.businessInfoField;
			}
			set
			{
				this.businessInfoField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<GovernmentIDPair> governmentIdField = new List<GovernmentIDPair>();
		public List<GovernmentIDPair> governmentId
		{
			get
			{
				return this.governmentIdField;
			}
			set
			{
				this.governmentIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string professionField;
		public string profession
		{
			get
			{
				return this.professionField;
			}
			set
			{
				this.professionField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string occupationField;
		public string occupation
		{
			get
			{
				return this.occupationField;
			}
			set
			{
				this.occupationField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string functionalAreaField;
		public string functionalArea
		{
			get
			{
				return this.functionalAreaField;
			}
			set
			{
				this.functionalAreaField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<LegalAgreementType> legalAgreementField = new List<LegalAgreementType>();
		public List<LegalAgreementType> legalAgreement
		{
			get
			{
				return this.legalAgreementField;
			}
			set
			{
				this.legalAgreementField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string purposeOfAccountField;
		public string purposeOfAccount
		{
			get
			{
				return this.purposeOfAccountField;
			}
			set
			{
				this.purposeOfAccountField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public CreateAccountRequest(RequestEnvelope requestEnvelope, NameType name, AddressType address, string preferredLanguageCode)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.name = name;
			this.address = address;
			this.preferredLanguageCode = preferredLanguageCode;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CreateAccountRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.clientDetails != null)
			{
					string newPrefix = prefix + "clientDetails" + ".";
					sb.Append(this.clientDetailsField.ToNVPString(newPrefix));
			}
			if (this.accountType != null)
			{
					sb.Append(prefix).Append("accountType").Append("=").Append(HttpUtility.UrlEncode(this.accountType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.name != null)
			{
					string newPrefix = prefix + "name" + ".";
					sb.Append(this.nameField.ToNVPString(newPrefix));
			}
			if (this.dateOfBirth != null)
			{
					sb.Append(prefix).Append("dateOfBirth").Append("=").Append(this.dateOfBirth).Append("&");
			}
			if (this.address != null)
			{
					string newPrefix = prefix + "address" + ".";
					sb.Append(this.addressField.ToNVPString(newPrefix));
			}
			if (this.contactPhoneNumber != null)
			{
					sb.Append(prefix).Append("contactPhoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.contactPhoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.homePhoneNumber != null)
			{
					sb.Append(prefix).Append("homePhoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.homePhoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.mobilePhoneNumber != null)
			{
					sb.Append(prefix).Append("mobilePhoneNumber").Append("=").Append(HttpUtility.UrlEncode(this.mobilePhoneNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.currencyCode != null)
			{
					sb.Append(prefix).Append("currencyCode").Append("=").Append(HttpUtility.UrlEncode(this.currencyCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.citizenshipCountryCode != null)
			{
					sb.Append(prefix).Append("citizenshipCountryCode").Append("=").Append(HttpUtility.UrlEncode(this.citizenshipCountryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.preferredLanguageCode != null)
			{
					sb.Append(prefix).Append("preferredLanguageCode").Append("=").Append(HttpUtility.UrlEncode(this.preferredLanguageCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.notificationURL != null)
			{
					sb.Append(prefix).Append("notificationURL").Append("=").Append(HttpUtility.UrlEncode(this.notificationURL, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.registrationType != null)
			{
					sb.Append(prefix).Append("registrationType").Append("=").Append(HttpUtility.UrlEncode(this.registrationType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.createAccountWebOptions != null)
			{
					string newPrefix = prefix + "createAccountWebOptions" + ".";
					sb.Append(this.createAccountWebOptionsField.ToNVPString(newPrefix));
			}
			if (this.suppressWelcomeEmail != null)
			{
					sb.Append(prefix).Append("suppressWelcomeEmail").Append("=").Append(this.suppressWelcomeEmail.ToString().ToLower()).Append("&");
			}
			if (this.performExtraVettingOnThisAccount != null)
			{
					sb.Append(prefix).Append("performExtraVettingOnThisAccount").Append("=").Append(this.performExtraVettingOnThisAccount.ToString().ToLower()).Append("&");
			}
			if (this.taxId != null)
			{
					sb.Append(prefix).Append("taxId").Append("=").Append(HttpUtility.UrlEncode(this.taxId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField1 != null)
			{
					sb.Append(prefix).Append("partnerField1").Append("=").Append(HttpUtility.UrlEncode(this.partnerField1, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField2 != null)
			{
					sb.Append(prefix).Append("partnerField2").Append("=").Append(HttpUtility.UrlEncode(this.partnerField2, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField3 != null)
			{
					sb.Append(prefix).Append("partnerField3").Append("=").Append(HttpUtility.UrlEncode(this.partnerField3, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField4 != null)
			{
					sb.Append(prefix).Append("partnerField4").Append("=").Append(HttpUtility.UrlEncode(this.partnerField4, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.partnerField5 != null)
			{
					sb.Append(prefix).Append("partnerField5").Append("=").Append(HttpUtility.UrlEncode(this.partnerField5, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.businessInfo != null)
			{
					string newPrefix = prefix + "businessInfo" + ".";
					sb.Append(this.businessInfoField.ToNVPString(newPrefix));
			}
			for (int i = 0; i < this.governmentId.Count; i++)
			{
				if (this.governmentId[i] != null)
				{
					string newPrefix = prefix + "governmentId" + "(" + i + ").";
					sb.Append(this.governmentId[i].ToNVPString(newPrefix));
				}
			}
			if (this.profession != null)
			{
					sb.Append(prefix).Append("profession").Append("=").Append(HttpUtility.UrlEncode(this.profession, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.occupation != null)
			{
					sb.Append(prefix).Append("occupation").Append("=").Append(HttpUtility.UrlEncode(this.occupation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.functionalArea != null)
			{
					sb.Append(prefix).Append("functionalArea").Append("=").Append(HttpUtility.UrlEncode(this.functionalArea, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			for (int i = 0; i < this.legalAgreement.Count; i++)
			{
				if (this.legalAgreement[i] != null)
				{
					string newPrefix = prefix + "legalAgreement" + "(" + i + ").";
					sb.Append(this.legalAgreement[i].ToNVPString(newPrefix));
				}
			}
			if (this.purposeOfAccount != null)
			{
					sb.Append(prefix).Append("purposeOfAccount").Append("=").Append(HttpUtility.UrlEncode(this.purposeOfAccount, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Valid values are: COMPLETED 
    /// </summary>
	public partial class CreateAccountResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string createAccountKeyField;
		public string createAccountKey
		{
			get
			{
				return this.createAccountKeyField;
			}
			set
			{
				this.createAccountKeyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string redirectURLField;
		public string redirectURL
		{
			get
			{
				return this.redirectURLField;
			}
			set
			{
				this.redirectURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CreateAccountResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new CreateAccountResponse object created from the passed in NVP map
	 	/// </returns>
		public static CreateAccountResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CreateAccountResponse createAccountResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "createAccountKey";
			if (map.ContainsKey(key))
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.createAccountKey = map[key];
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.execStatus = map[key];
			}
			key = prefix + "redirectURL";
			if (map.ContainsKey(key))
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.redirectURL = map[key];
			}
			key = prefix + "accountId";
			if (map.ContainsKey(key))
			{
				createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
				createAccountResponse.accountId = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					createAccountResponse = (createAccountResponse == null) ? new CreateAccountResponse() : createAccountResponse;
					createAccountResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return createAccountResponse;
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class GetUserAgreementRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string createAccountKeyField;
		public string createAccountKey
		{
			get
			{
				return this.createAccountKeyField;
			}
			set
			{
				this.createAccountKeyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string languageCodeField;
		public string languageCode
		{
			get
			{
				return this.languageCodeField;
			}
			set
			{
				this.languageCodeField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public GetUserAgreementRequest(RequestEnvelope requestEnvelope)
	 	{
			this.requestEnvelope = requestEnvelope;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public GetUserAgreementRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.createAccountKey != null)
			{
					sb.Append(prefix).Append("createAccountKey").Append("=").Append(HttpUtility.UrlEncode(this.createAccountKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.countryCode != null)
			{
					sb.Append(prefix).Append("countryCode").Append("=").Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.languageCode != null)
			{
					sb.Append(prefix).Append("languageCode").Append("=").Append(HttpUtility.UrlEncode(this.languageCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class GetUserAgreementResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string agreementField;
		public string agreement
		{
			get
			{
				return this.agreementField;
			}
			set
			{
				this.agreementField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public GetUserAgreementResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new GetUserAgreementResponse object created from the passed in NVP map
	 	/// </returns>
		public static GetUserAgreementResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetUserAgreementResponse getUserAgreementResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getUserAgreementResponse = (getUserAgreementResponse == null) ? new GetUserAgreementResponse() : getUserAgreementResponse;
				getUserAgreementResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "agreement";
			if (map.ContainsKey(key))
			{
				getUserAgreementResponse = (getUserAgreementResponse == null) ? new GetUserAgreementResponse() : getUserAgreementResponse;
				getUserAgreementResponse.agreement = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getUserAgreementResponse = (getUserAgreementResponse == null) ? new GetUserAgreementResponse() : getUserAgreementResponse;
					getUserAgreementResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getUserAgreementResponse;
		}
	}




	/// <summary>
	/// Deprecated, use accountIdentifier.emailAddress instead 
    /// </summary>
	public partial class GetVerifiedStatusRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AccountIdentifierType accountIdentifierField;
		public AccountIdentifierType accountIdentifier
		{
			get
			{
				return this.accountIdentifierField;
			}
			set
			{
				this.accountIdentifierField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string matchCriteriaField;
		public string matchCriteria
		{
			get
			{
				return this.matchCriteriaField;
			}
			set
			{
				this.matchCriteriaField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string firstNameField;
		public string firstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string lastNameField;
		public string lastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public GetVerifiedStatusRequest(RequestEnvelope requestEnvelope, string matchCriteria)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.matchCriteria = matchCriteria;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public GetVerifiedStatusRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountIdentifier != null)
			{
					string newPrefix = prefix + "accountIdentifier" + ".";
					sb.Append(this.accountIdentifierField.ToNVPString(newPrefix));
			}
			if (this.matchCriteria != null)
			{
					sb.Append(prefix).Append("matchCriteria").Append("=").Append(HttpUtility.UrlEncode(this.matchCriteria, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.firstName != null)
			{
					sb.Append(prefix).Append("firstName").Append("=").Append(HttpUtility.UrlEncode(this.firstName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.lastName != null)
			{
					sb.Append(prefix).Append("lastName").Append("=").Append(HttpUtility.UrlEncode(this.lastName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Returned values are: VERIFIED|UNVERIFIED. 
    /// </summary>
	public partial class GetVerifiedStatusResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountStatusField;
		public string accountStatus
		{
			get
			{
				return this.accountStatusField;
			}
			set
			{
				this.accountStatusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private UserInfoType userInfoField;
		public UserInfoType userInfo
		{
			get
			{
				return this.userInfoField;
			}
			set
			{
				this.userInfoField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public GetVerifiedStatusResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new GetVerifiedStatusResponse object created from the passed in NVP map
	 	/// </returns>
		public static GetVerifiedStatusResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			GetVerifiedStatusResponse getVerifiedStatusResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
				getVerifiedStatusResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "accountStatus";
			if (map.ContainsKey(key))
			{
				getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
				getVerifiedStatusResponse.accountStatus = map[key];
			}
			key = prefix + "countryCode";
			if (map.ContainsKey(key))
			{
				getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
				getVerifiedStatusResponse.countryCode = map[key];
			}
			UserInfoType userInfo =  UserInfoType.CreateInstance(map, prefix + "userInfo", -1);
			if (userInfo != null)
			{
				getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
				getVerifiedStatusResponse.userInfo = userInfo;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					getVerifiedStatusResponse = (getVerifiedStatusResponse == null) ? new GetVerifiedStatusResponse() : getVerifiedStatusResponse;
					getVerifiedStatusResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return getVerifiedStatusResponse;
		}
	}




	/// <summary>
	/// Identifying the PayPal account to which this request is
	/// targetted to. Caller of this API has to either provided an
	/// emailAddress or an accountId. 
    /// </summary>
	public partial class AddBankAccountRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string createAccountKeyField;
		public string createAccountKey
		{
			get
			{
				return this.createAccountKeyField;
			}
			set
			{
				this.createAccountKeyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string bankCountryCodeField;
		public string bankCountryCode
		{
			get
			{
				return this.bankCountryCodeField;
			}
			set
			{
				this.bankCountryCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string bankNameField;
		public string bankName
		{
			get
			{
				return this.bankNameField;
			}
			set
			{
				this.bankNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string routingNumberField;
		public string routingNumber
		{
			get
			{
				return this.routingNumberField;
			}
			set
			{
				this.routingNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BankAccountType? bankAccountTypeField;
		public BankAccountType? bankAccountType
		{
			get
			{
				return this.bankAccountTypeField;
			}
			set
			{
				this.bankAccountTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string bankAccountNumberField;
		public string bankAccountNumber
		{
			get
			{
				return this.bankAccountNumberField;
			}
			set
			{
				this.bankAccountNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string ibanField;
		public string iban
		{
			get
			{
				return this.ibanField;
			}
			set
			{
				this.ibanField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string clabeField;
		public string clabe
		{
			get
			{
				return this.clabeField;
			}
			set
			{
				this.clabeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string bsbNumberField;
		public string bsbNumber
		{
			get
			{
				return this.bsbNumberField;
			}
			set
			{
				this.bsbNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string branchLocationField;
		public string branchLocation
		{
			get
			{
				return this.branchLocationField;
			}
			set
			{
				this.branchLocationField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string sortCodeField;
		public string sortCode
		{
			get
			{
				return this.sortCodeField;
			}
			set
			{
				this.sortCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string bankTransitNumberField;
		public string bankTransitNumber
		{
			get
			{
				return this.bankTransitNumberField;
			}
			set
			{
				this.bankTransitNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string institutionNumberField;
		public string institutionNumber
		{
			get
			{
				return this.institutionNumberField;
			}
			set
			{
				this.institutionNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string branchCodeField;
		public string branchCode
		{
			get
			{
				return this.branchCodeField;
			}
			set
			{
				this.branchCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string agencyNumberField;
		public string agencyNumber
		{
			get
			{
				return this.agencyNumberField;
			}
			set
			{
				this.agencyNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string bankCodeField;
		public string bankCode
		{
			get
			{
				return this.bankCodeField;
			}
			set
			{
				this.bankCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string ribKeyField;
		public string ribKey
		{
			get
			{
				return this.ribKeyField;
			}
			set
			{
				this.ribKeyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string controlDigitField;
		public string controlDigit
		{
			get
			{
				return this.controlDigitField;
			}
			set
			{
				this.controlDigitField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string taxIdTypeField;
		public string taxIdType
		{
			get
			{
				return this.taxIdTypeField;
			}
			set
			{
				this.taxIdTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string taxIdNumberField;
		public string taxIdNumber
		{
			get
			{
				return this.taxIdNumberField;
			}
			set
			{
				this.taxIdNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountHolderDateOfBirthField;
		public string accountHolderDateOfBirth
		{
			get
			{
				return this.accountHolderDateOfBirthField;
			}
			set
			{
				this.accountHolderDateOfBirthField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private ConfirmationType? confirmationTypeField;
		public ConfirmationType? confirmationType
		{
			get
			{
				return this.confirmationTypeField;
			}
			set
			{
				this.confirmationTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private WebOptionsType webOptionsField;
		public WebOptionsType webOptions
		{
			get
			{
				return this.webOptionsField;
			}
			set
			{
				this.webOptionsField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public AddBankAccountRequest(RequestEnvelope requestEnvelope, string bankCountryCode, ConfirmationType? confirmationType)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.bankCountryCode = bankCountryCode;
			this.confirmationType = confirmationType;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AddBankAccountRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountId != null)
			{
					sb.Append(prefix).Append("accountId").Append("=").Append(HttpUtility.UrlEncode(this.accountId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.createAccountKey != null)
			{
					sb.Append(prefix).Append("createAccountKey").Append("=").Append(HttpUtility.UrlEncode(this.createAccountKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankCountryCode != null)
			{
					sb.Append(prefix).Append("bankCountryCode").Append("=").Append(HttpUtility.UrlEncode(this.bankCountryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankName != null)
			{
					sb.Append(prefix).Append("bankName").Append("=").Append(HttpUtility.UrlEncode(this.bankName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.routingNumber != null)
			{
					sb.Append(prefix).Append("routingNumber").Append("=").Append(HttpUtility.UrlEncode(this.routingNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankAccountType != null)
			{
					sb.Append(prefix).Append("bankAccountType").Append("=").Append(EnumUtils.GetDescription(this.bankAccountType));
					sb.Append("&");
			}
			if (this.bankAccountNumber != null)
			{
					sb.Append(prefix).Append("bankAccountNumber").Append("=").Append(HttpUtility.UrlEncode(this.bankAccountNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.iban != null)
			{
					sb.Append(prefix).Append("iban").Append("=").Append(HttpUtility.UrlEncode(this.iban, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.clabe != null)
			{
					sb.Append(prefix).Append("clabe").Append("=").Append(HttpUtility.UrlEncode(this.clabe, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bsbNumber != null)
			{
					sb.Append(prefix).Append("bsbNumber").Append("=").Append(HttpUtility.UrlEncode(this.bsbNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.branchLocation != null)
			{
					sb.Append(prefix).Append("branchLocation").Append("=").Append(HttpUtility.UrlEncode(this.branchLocation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.sortCode != null)
			{
					sb.Append(prefix).Append("sortCode").Append("=").Append(HttpUtility.UrlEncode(this.sortCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankTransitNumber != null)
			{
					sb.Append(prefix).Append("bankTransitNumber").Append("=").Append(HttpUtility.UrlEncode(this.bankTransitNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.institutionNumber != null)
			{
					sb.Append(prefix).Append("institutionNumber").Append("=").Append(HttpUtility.UrlEncode(this.institutionNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.branchCode != null)
			{
					sb.Append(prefix).Append("branchCode").Append("=").Append(HttpUtility.UrlEncode(this.branchCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.agencyNumber != null)
			{
					sb.Append(prefix).Append("agencyNumber").Append("=").Append(HttpUtility.UrlEncode(this.agencyNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.bankCode != null)
			{
					sb.Append(prefix).Append("bankCode").Append("=").Append(HttpUtility.UrlEncode(this.bankCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.ribKey != null)
			{
					sb.Append(prefix).Append("ribKey").Append("=").Append(HttpUtility.UrlEncode(this.ribKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.controlDigit != null)
			{
					sb.Append(prefix).Append("controlDigit").Append("=").Append(HttpUtility.UrlEncode(this.controlDigit, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.taxIdType != null)
			{
					sb.Append(prefix).Append("taxIdType").Append("=").Append(HttpUtility.UrlEncode(this.taxIdType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.taxIdNumber != null)
			{
					sb.Append(prefix).Append("taxIdNumber").Append("=").Append(HttpUtility.UrlEncode(this.taxIdNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountHolderDateOfBirth != null)
			{
					sb.Append(prefix).Append("accountHolderDateOfBirth").Append("=").Append(this.accountHolderDateOfBirth).Append("&");
			}
			if (this.confirmationType != null)
			{
					sb.Append(prefix).Append("confirmationType").Append("=").Append(EnumUtils.GetDescription(this.confirmationType));
					sb.Append("&");
			}
			if (this.webOptions != null)
			{
					string newPrefix = prefix + "webOptions" + ".";
					sb.Append(this.webOptionsField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Valid values are: FUNDING_SOURCE_ADDED,
	/// WEB_URL_VERIFICATION_NEEDED 
    /// </summary>
	public partial class AddBankAccountResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string redirectURLField;
		public string redirectURL
		{
			get
			{
				return this.redirectURLField;
			}
			set
			{
				this.redirectURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string fundingSourceKeyField;
		public string fundingSourceKey
		{
			get
			{
				return this.fundingSourceKeyField;
			}
			set
			{
				this.fundingSourceKeyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AddBankAccountResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new AddBankAccountResponse object created from the passed in NVP map
	 	/// </returns>
		public static AddBankAccountResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			AddBankAccountResponse addBankAccountResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
				addBankAccountResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
				addBankAccountResponse.execStatus = map[key];
			}
			key = prefix + "redirectURL";
			if (map.ContainsKey(key))
			{
				addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
				addBankAccountResponse.redirectURL = map[key];
			}
			key = prefix + "fundingSourceKey";
			if (map.ContainsKey(key))
			{
				addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
				addBankAccountResponse.fundingSourceKey = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					addBankAccountResponse = (addBankAccountResponse == null) ? new AddBankAccountResponse() : addBankAccountResponse;
					addBankAccountResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return addBankAccountResponse;
		}
	}




	/// <summary>
	/// Identifying the PayPal account to which this request is
	/// targetted to. Caller of this API has to either provided an
	/// emailAddress or an accountId. 
    /// </summary>
	public partial class AddPaymentCardRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string createAccountKeyField;
		public string createAccountKey
		{
			get
			{
				return this.createAccountKeyField;
			}
			set
			{
				this.createAccountKeyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private NameType nameOnCardField;
		public NameType nameOnCard
		{
			get
			{
				return this.nameOnCardField;
			}
			set
			{
				this.nameOnCardField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AddressType billingAddressField;
		public AddressType billingAddress
		{
			get
			{
				return this.billingAddressField;
			}
			set
			{
				this.billingAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cardOwnerDateOfBirthField;
		public string cardOwnerDateOfBirth
		{
			get
			{
				return this.cardOwnerDateOfBirthField;
			}
			set
			{
				this.cardOwnerDateOfBirthField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cardNumberField;
		public string cardNumber
		{
			get
			{
				return this.cardNumberField;
			}
			set
			{
				this.cardNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private CardTypeType? cardTypeField;
		public CardTypeType? cardType
		{
			get
			{
				return this.cardTypeField;
			}
			set
			{
				this.cardTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private CardDateType expirationDateField;
		public CardDateType expirationDate
		{
			get
			{
				return this.expirationDateField;
			}
			set
			{
				this.expirationDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cardVerificationNumberField;
		public string cardVerificationNumber
		{
			get
			{
				return this.cardVerificationNumberField;
			}
			set
			{
				this.cardVerificationNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private CardDateType startDateField;
		public CardDateType startDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string issueNumberField;
		public string issueNumber
		{
			get
			{
				return this.issueNumberField;
			}
			set
			{
				this.issueNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private ConfirmationType? confirmationTypeField;
		public ConfirmationType? confirmationType
		{
			get
			{
				return this.confirmationTypeField;
			}
			set
			{
				this.confirmationTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private WebOptionsType webOptionsField;
		public WebOptionsType webOptions
		{
			get
			{
				return this.webOptionsField;
			}
			set
			{
				this.webOptionsField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public AddPaymentCardRequest(RequestEnvelope requestEnvelope, NameType nameOnCard, AddressType billingAddress, string cardNumber, CardTypeType? cardType, ConfirmationType? confirmationType)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.nameOnCard = nameOnCard;
			this.billingAddress = billingAddress;
			this.cardNumber = cardNumber;
			this.cardType = cardType;
			this.confirmationType = confirmationType;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AddPaymentCardRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountId != null)
			{
					sb.Append(prefix).Append("accountId").Append("=").Append(HttpUtility.UrlEncode(this.accountId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.createAccountKey != null)
			{
					sb.Append(prefix).Append("createAccountKey").Append("=").Append(HttpUtility.UrlEncode(this.createAccountKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.nameOnCard != null)
			{
					string newPrefix = prefix + "nameOnCard" + ".";
					sb.Append(this.nameOnCardField.ToNVPString(newPrefix));
			}
			if (this.billingAddress != null)
			{
					string newPrefix = prefix + "billingAddress" + ".";
					sb.Append(this.billingAddressField.ToNVPString(newPrefix));
			}
			if (this.cardOwnerDateOfBirth != null)
			{
					sb.Append(prefix).Append("cardOwnerDateOfBirth").Append("=").Append(this.cardOwnerDateOfBirth).Append("&");
			}
			if (this.cardNumber != null)
			{
					sb.Append(prefix).Append("cardNumber").Append("=").Append(HttpUtility.UrlEncode(this.cardNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.cardType != null)
			{
					sb.Append(prefix).Append("cardType").Append("=").Append(EnumUtils.GetDescription(this.cardType));
					sb.Append("&");
			}
			if (this.expirationDate != null)
			{
					string newPrefix = prefix + "expirationDate" + ".";
					sb.Append(this.expirationDateField.ToNVPString(newPrefix));
			}
			if (this.cardVerificationNumber != null)
			{
					sb.Append(prefix).Append("cardVerificationNumber").Append("=").Append(HttpUtility.UrlEncode(this.cardVerificationNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.startDate != null)
			{
					string newPrefix = prefix + "startDate" + ".";
					sb.Append(this.startDateField.ToNVPString(newPrefix));
			}
			if (this.issueNumber != null)
			{
					sb.Append(prefix).Append("issueNumber").Append("=").Append(HttpUtility.UrlEncode(this.issueNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.confirmationType != null)
			{
					sb.Append(prefix).Append("confirmationType").Append("=").Append(EnumUtils.GetDescription(this.confirmationType));
					sb.Append("&");
			}
			if (this.webOptions != null)
			{
					string newPrefix = prefix + "webOptions" + ".";
					sb.Append(this.webOptionsField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Valid values are: FUNDING_SOURCE_ADDED,
	/// WEB_URL_VERIFICATION_NEEDED 
    /// </summary>
	public partial class AddPaymentCardResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string redirectURLField;
		public string redirectURL
		{
			get
			{
				return this.redirectURLField;
			}
			set
			{
				this.redirectURLField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string fundingSourceKeyField;
		public string fundingSourceKey
		{
			get
			{
				return this.fundingSourceKeyField;
			}
			set
			{
				this.fundingSourceKeyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AddPaymentCardResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new AddPaymentCardResponse object created from the passed in NVP map
	 	/// </returns>
		public static AddPaymentCardResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			AddPaymentCardResponse addPaymentCardResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
				addPaymentCardResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
				addPaymentCardResponse.execStatus = map[key];
			}
			key = prefix + "redirectURL";
			if (map.ContainsKey(key))
			{
				addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
				addPaymentCardResponse.redirectURL = map[key];
			}
			key = prefix + "fundingSourceKey";
			if (map.ContainsKey(key))
			{
				addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
				addPaymentCardResponse.fundingSourceKey = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					addPaymentCardResponse = (addPaymentCardResponse == null) ? new AddPaymentCardResponse() : addPaymentCardResponse;
					addPaymentCardResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return addPaymentCardResponse;
		}
	}




	/// <summary>
	/// This not considered when
	/// financialProductCategory=PRE_PAID_CARD 
    /// </summary>
	public partial class AddPartnerFinancialProductRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AccountIdentifierType accountIdentifierField;
		public AccountIdentifierType accountIdentifier
		{
			get
			{
				return this.accountIdentifierField;
			}
			set
			{
				this.accountIdentifierField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private NameType nameOnCardField;
		public NameType nameOnCard
		{
			get
			{
				return this.nameOnCardField;
			}
			set
			{
				this.nameOnCardField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AddressType billingAddressField;
		public AddressType billingAddress
		{
			get
			{
				return this.billingAddressField;
			}
			set
			{
				this.billingAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cardOwnerDateOfBirthField;
		public string cardOwnerDateOfBirth
		{
			get
			{
				return this.cardOwnerDateOfBirthField;
			}
			set
			{
				this.cardOwnerDateOfBirthField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cardNumberField;
		public string cardNumber
		{
			get
			{
				return this.cardNumberField;
			}
			set
			{
				this.cardNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string financialProductCategoryField;
		public string financialProductCategory
		{
			get
			{
				return this.financialProductCategoryField;
			}
			set
			{
				this.financialProductCategoryField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private CardDateType expirationDateField;
		public CardDateType expirationDate
		{
			get
			{
				return this.expirationDateField;
			}
			set
			{
				this.expirationDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cardVerificationNumberField;
		public string cardVerificationNumber
		{
			get
			{
				return this.cardVerificationNumberField;
			}
			set
			{
				this.cardVerificationNumberField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private CardDateType startDateField;
		public CardDateType startDate
		{
			get
			{
				return this.startDateField;
			}
			set
			{
				this.startDateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string issueNumberField;
		public string issueNumber
		{
			get
			{
				return this.issueNumberField;
			}
			set
			{
				this.issueNumberField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public AddPartnerFinancialProductRequest(RequestEnvelope requestEnvelope, AccountIdentifierType accountIdentifier, string cardNumber, string financialProductCategory, CardDateType expirationDate)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.accountIdentifier = accountIdentifier;
			this.cardNumber = cardNumber;
			this.financialProductCategory = financialProductCategory;
			this.expirationDate = expirationDate;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AddPartnerFinancialProductRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.accountIdentifier != null)
			{
					string newPrefix = prefix + "accountIdentifier" + ".";
					sb.Append(this.accountIdentifierField.ToNVPString(newPrefix));
			}
			if (this.nameOnCard != null)
			{
					string newPrefix = prefix + "nameOnCard" + ".";
					sb.Append(this.nameOnCardField.ToNVPString(newPrefix));
			}
			if (this.billingAddress != null)
			{
					string newPrefix = prefix + "billingAddress" + ".";
					sb.Append(this.billingAddressField.ToNVPString(newPrefix));
			}
			if (this.cardOwnerDateOfBirth != null)
			{
					sb.Append(prefix).Append("cardOwnerDateOfBirth").Append("=").Append(this.cardOwnerDateOfBirth).Append("&");
			}
			if (this.cardNumber != null)
			{
					sb.Append(prefix).Append("cardNumber").Append("=").Append(HttpUtility.UrlEncode(this.cardNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.financialProductCategory != null)
			{
					sb.Append(prefix).Append("financialProductCategory").Append("=").Append(HttpUtility.UrlEncode(this.financialProductCategory, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.expirationDate != null)
			{
					string newPrefix = prefix + "expirationDate" + ".";
					sb.Append(this.expirationDateField.ToNVPString(newPrefix));
			}
			if (this.cardVerificationNumber != null)
			{
					sb.Append(prefix).Append("cardVerificationNumber").Append("=").Append(HttpUtility.UrlEncode(this.cardVerificationNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.startDate != null)
			{
					string newPrefix = prefix + "startDate" + ".";
					sb.Append(this.startDateField.ToNVPString(newPrefix));
			}
			if (this.issueNumber != null)
			{
					sb.Append(prefix).Append("issueNumber").Append("=").Append(HttpUtility.UrlEncode(this.issueNumber, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Valid values are: CARD_ADDED 
    /// </summary>
	public partial class AddPartnerFinancialProductResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AddPartnerFinancialProductResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new AddPartnerFinancialProductResponse object created from the passed in NVP map
	 	/// </returns>
		public static AddPartnerFinancialProductResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			AddPartnerFinancialProductResponse addPartnerFinancialProductResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				addPartnerFinancialProductResponse = (addPartnerFinancialProductResponse == null) ? new AddPartnerFinancialProductResponse() : addPartnerFinancialProductResponse;
				addPartnerFinancialProductResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				addPartnerFinancialProductResponse = (addPartnerFinancialProductResponse == null) ? new AddPartnerFinancialProductResponse() : addPartnerFinancialProductResponse;
				addPartnerFinancialProductResponse.execStatus = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					addPartnerFinancialProductResponse = (addPartnerFinancialProductResponse == null) ? new AddPartnerFinancialProductResponse() : addPartnerFinancialProductResponse;
					addPartnerFinancialProductResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return addPartnerFinancialProductResponse;
		}
	}




	/// <summary>
	/// Identifying the PayPal account to which this request is
	/// targetted to. Caller of this API has to either provided an
	/// emailAddress or an accountId. 
    /// </summary>
	public partial class SetFundingSourceConfirmedRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string fundingSourceKeyField;
		public string fundingSourceKey
		{
			get
			{
				return this.fundingSourceKeyField;
			}
			set
			{
				this.fundingSourceKeyField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public SetFundingSourceConfirmedRequest(RequestEnvelope requestEnvelope, string fundingSourceKey)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.fundingSourceKey = fundingSourceKey;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public SetFundingSourceConfirmedRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.emailAddress != null)
			{
					sb.Append(prefix).Append("emailAddress").Append("=").Append(HttpUtility.UrlEncode(this.emailAddress, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.accountId != null)
			{
					sb.Append(prefix).Append("accountId").Append("=").Append(HttpUtility.UrlEncode(this.accountId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.fundingSourceKey != null)
			{
					sb.Append(prefix).Append("fundingSourceKey").Append("=").Append(HttpUtility.UrlEncode(this.fundingSourceKey, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class SetFundingSourceConfirmedResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public SetFundingSourceConfirmedResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new SetFundingSourceConfirmedResponse object created from the passed in NVP map
	 	/// </returns>
		public static SetFundingSourceConfirmedResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			SetFundingSourceConfirmedResponse setFundingSourceConfirmedResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				setFundingSourceConfirmedResponse = (setFundingSourceConfirmedResponse == null) ? new SetFundingSourceConfirmedResponse() : setFundingSourceConfirmedResponse;
				setFundingSourceConfirmedResponse.responseEnvelope = responseEnvelope;
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					setFundingSourceConfirmedResponse = (setFundingSourceConfirmedResponse == null) ? new SetFundingSourceConfirmedResponse() : setFundingSourceConfirmedResponse;
					setFundingSourceConfirmedResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return setFundingSourceConfirmedResponse;
		}
	}




	/// <summary>
	/// Identifies a PayPal account to which this request is
	/// targeted. Caller of this API has to provide ONLY one of
	/// these inputs: emailAddress, accountId or mobilePhoneNumber. 
    /// </summary>
	public partial class CheckComplianceStatusRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AccountIdentifierType accountIdentifierField;
		public AccountIdentifierType accountIdentifier
		{
			get
			{
				return this.accountIdentifierField;
			}
			set
			{
				this.accountIdentifierField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public CheckComplianceStatusRequest(RequestEnvelope requestEnvelope, AccountIdentifierType accountIdentifier)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.accountIdentifier = accountIdentifier;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CheckComplianceStatusRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.accountIdentifier != null)
			{
					string newPrefix = prefix + "accountIdentifier" + ".";
					sb.Append(this.accountIdentifierField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Returned values are: ALLOW|DENY 
    /// </summary>
	public partial class CheckComplianceStatusResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string denialReasonField;
		public string denialReason
		{
			get
			{
				return this.denialReasonField;
			}
			set
			{
				this.denialReasonField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CheckComplianceStatusResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new CheckComplianceStatusResponse object created from the passed in NVP map
	 	/// </returns>
		public static CheckComplianceStatusResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			CheckComplianceStatusResponse checkComplianceStatusResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				checkComplianceStatusResponse = (checkComplianceStatusResponse == null) ? new CheckComplianceStatusResponse() : checkComplianceStatusResponse;
				checkComplianceStatusResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				checkComplianceStatusResponse = (checkComplianceStatusResponse == null) ? new CheckComplianceStatusResponse() : checkComplianceStatusResponse;
				checkComplianceStatusResponse.execStatus = map[key];
			}
			key = prefix + "denialReason";
			if (map.ContainsKey(key))
			{
				checkComplianceStatusResponse = (checkComplianceStatusResponse == null) ? new CheckComplianceStatusResponse() : checkComplianceStatusResponse;
				checkComplianceStatusResponse.denialReason = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					checkComplianceStatusResponse = (checkComplianceStatusResponse == null) ? new CheckComplianceStatusResponse() : checkComplianceStatusResponse;
					checkComplianceStatusResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return checkComplianceStatusResponse;
		}
	}




	/// <summary>
	/// This operation is for internal purposes developed for a POC.
	/// 
    /// </summary>
	public partial class ActivateProductRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AccountIdentifierType accountIdentifierField;
		public AccountIdentifierType accountIdentifier
		{
			get
			{
				return this.accountIdentifierField;
			}
			set
			{
				this.accountIdentifierField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public ActivateProductRequest(RequestEnvelope requestEnvelope, AccountIdentifierType accountIdentifier)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.accountIdentifier = accountIdentifier;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ActivateProductRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.accountIdentifier != null)
			{
					string newPrefix = prefix + "accountIdentifier" + ".";
					sb.Append(this.accountIdentifierField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Valid values are: SUCCESS, FAILED 
    /// </summary>
	public partial class ActivateProductResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ProductActivationErrors?> productActivationErrorsField = new List<ProductActivationErrors?>();
		public List<ProductActivationErrors?> productActivationErrors
		{
			get
			{
				return this.productActivationErrorsField;
			}
			set
			{
				this.productActivationErrorsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public ActivateProductResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new ActivateProductResponse object created from the passed in NVP map
	 	/// </returns>
		public static ActivateProductResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			ActivateProductResponse activateProductResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				activateProductResponse = (activateProductResponse == null) ? new ActivateProductResponse() : activateProductResponse;
				activateProductResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				activateProductResponse = (activateProductResponse == null) ? new ActivateProductResponse() : activateProductResponse;
				activateProductResponse.execStatus = map[key];
			}
			i = 0;
			while(true)
			{
				key = prefix + "productActivationErrors" + "(" + i + ")";
				if (map.ContainsKey(key))
				{
					activateProductResponse = (activateProductResponse == null) ? new ActivateProductResponse() : activateProductResponse;
					activateProductResponse.productActivationErrors.Add((ProductActivationErrors)EnumUtils.GetValue(map[key],typeof(ProductActivationErrors)));
					i++;
				}
				else
				{
					break;
				}
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					activateProductResponse = (activateProductResponse == null) ? new ActivateProductResponse() : activateProductResponse;
					activateProductResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return activateProductResponse;
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class UpdateComplianceStatusRequest	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private RequestEnvelope requestEnvelopeField;
		public RequestEnvelope requestEnvelope
		{
			get
			{
				return this.requestEnvelopeField;
			}
			set
			{
				this.requestEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AuditeeInfoType auditeeInfoField;
		public AuditeeInfoType auditeeInfo
		{
			get
			{
				return this.auditeeInfoField;
			}
			set
			{
				this.auditeeInfoField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AuditorList auditorListField;
		public AuditorList auditorList
		{
			get
			{
				return this.auditorListField;
			}
			set
			{
				this.auditorListField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AuditDetailsType auditDetailsField;
		public AuditDetailsType auditDetails
		{
			get
			{
				return this.auditDetailsField;
			}
			set
			{
				this.auditDetailsField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public UpdateComplianceStatusRequest(RequestEnvelope requestEnvelope, AuditeeInfoType auditeeInfo, AuditDetailsType auditDetails)
	 	{
			this.requestEnvelope = requestEnvelope;
			this.auditeeInfo = auditeeInfo;
			this.auditDetails = auditDetails;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public UpdateComplianceStatusRequest()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.requestEnvelope != null)
			{
					string newPrefix = prefix + "requestEnvelope" + ".";
					sb.Append(this.requestEnvelopeField.ToNVPString(newPrefix));
			}
			if (this.auditeeInfo != null)
			{
					string newPrefix = prefix + "auditeeInfo" + ".";
					sb.Append(this.auditeeInfoField.ToNVPString(newPrefix));
			}
			if (this.auditorList != null)
			{
					string newPrefix = prefix + "auditorList" + ".";
					sb.Append(this.auditorListField.ToNVPString(newPrefix));
			}
			if (this.auditDetails != null)
			{
					string newPrefix = prefix + "auditDetails" + ".";
					sb.Append(this.auditDetailsField.ToNVPString(newPrefix));
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class UpdateComplianceStatusResponse	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private ResponseEnvelope responseEnvelopeField;
		public ResponseEnvelope responseEnvelope
		{
			get
			{
				return this.responseEnvelopeField;
			}
			set
			{
				this.responseEnvelopeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string execStatusField;
		public string execStatus
		{
			get
			{
				return this.execStatusField;
			}
			set
			{
				this.execStatusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<ErrorData> errorField = new List<ErrorData>();
		public List<ErrorData> error
		{
			get
			{
				return this.errorField;
			}
			set
			{
				this.errorField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public UpdateComplianceStatusResponse()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new UpdateComplianceStatusResponse object created from the passed in NVP map
	 	/// </returns>
		public static UpdateComplianceStatusResponse CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			UpdateComplianceStatusResponse updateComplianceStatusResponse = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			ResponseEnvelope responseEnvelope =  ResponseEnvelope.CreateInstance(map, prefix + "responseEnvelope", -1);
			if (responseEnvelope != null)
			{
				updateComplianceStatusResponse = (updateComplianceStatusResponse == null) ? new UpdateComplianceStatusResponse() : updateComplianceStatusResponse;
				updateComplianceStatusResponse.responseEnvelope = responseEnvelope;
			}
			key = prefix + "execStatus";
			if (map.ContainsKey(key))
			{
				updateComplianceStatusResponse = (updateComplianceStatusResponse == null) ? new UpdateComplianceStatusResponse() : updateComplianceStatusResponse;
				updateComplianceStatusResponse.execStatus = map[key];
			}
			i = 0;
			while(true)
			{
				ErrorData error =  ErrorData.CreateInstance(map, prefix + "error", i);
				if (error != null)
				{
					updateComplianceStatusResponse = (updateComplianceStatusResponse == null) ? new UpdateComplianceStatusResponse() : updateComplianceStatusResponse;
					updateComplianceStatusResponse.error.Add(error);
					i++;
				} 
				else
				{
					break;
				}
			}
			return updateComplianceStatusResponse;
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class NameType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string salutationField;
		public string salutation
		{
			get
			{
				return this.salutationField;
			}
			set
			{
				this.salutationField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string firstNameField;
		public string firstName
		{
			get
			{
				return this.firstNameField;
			}
			set
			{
				this.firstNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string middleNameField;
		public string middleName
		{
			get
			{
				return this.middleNameField;
			}
			set
			{
				this.middleNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string lastNameField;
		public string lastName
		{
			get
			{
				return this.lastNameField;
			}
			set
			{
				this.lastNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string suffixField;
		public string suffix
		{
			get
			{
				return this.suffixField;
			}
			set
			{
				this.suffixField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public NameType(string firstName, string lastName)
	 	{
			this.firstName = firstName;
			this.lastName = lastName;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public NameType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.salutation != null)
			{
					sb.Append(prefix).Append("salutation").Append("=").Append(HttpUtility.UrlEncode(this.salutation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.firstName != null)
			{
					sb.Append(prefix).Append("firstName").Append("=").Append(HttpUtility.UrlEncode(this.firstName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.middleName != null)
			{
					sb.Append(prefix).Append("middleName").Append("=").Append(HttpUtility.UrlEncode(this.middleName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.lastName != null)
			{
					sb.Append(prefix).Append("lastName").Append("=").Append(HttpUtility.UrlEncode(this.lastName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.suffix != null)
			{
					sb.Append(prefix).Append("suffix").Append("=").Append(HttpUtility.UrlEncode(this.suffix, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new NameType object created from the passed in NVP map
	 	/// </returns>
		public static NameType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			NameType nameType = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "salutation";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.salutation = map[key];
			}
			key = prefix + "firstName";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.firstName = map[key];
			}
			key = prefix + "middleName";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.middleName = map[key];
			}
			key = prefix + "lastName";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.lastName = map[key];
			}
			key = prefix + "suffix";
			if (map.ContainsKey(key))
			{
				nameType = (nameType == null) ? new NameType() : nameType;
				nameType.suffix = map[key];
			}
			return nameType;
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class AddressType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string line1Field;
		public string line1
		{
			get
			{
				return this.line1Field;
			}
			set
			{
				this.line1Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string line2Field;
		public string line2
		{
			get
			{
				return this.line2Field;
			}
			set
			{
				this.line2Field = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cityField;
		public string city
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string stateField;
		public string state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string postalCodeField;
		public string postalCode
		{
			get
			{
				return this.postalCodeField;
			}
			set
			{
				this.postalCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string countryCodeField;
		public string countryCode
		{
			get
			{
				return this.countryCodeField;
			}
			set
			{
				this.countryCodeField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public AddressType(string line1, string countryCode)
	 	{
			this.line1 = line1;
			this.countryCode = countryCode;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AddressType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.line1 != null)
			{
					sb.Append(prefix).Append("line1").Append("=").Append(HttpUtility.UrlEncode(this.line1, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.line2 != null)
			{
					sb.Append(prefix).Append("line2").Append("=").Append(HttpUtility.UrlEncode(this.line2, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.city != null)
			{
					sb.Append(prefix).Append("city").Append("=").Append(HttpUtility.UrlEncode(this.city, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.state != null)
			{
					sb.Append(prefix).Append("state").Append("=").Append(HttpUtility.UrlEncode(this.state, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.postalCode != null)
			{
					sb.Append(prefix).Append("postalCode").Append("=").Append(HttpUtility.UrlEncode(this.postalCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.countryCode != null)
			{
					sb.Append(prefix).Append("countryCode").Append("=").Append(HttpUtility.UrlEncode(this.countryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Ask end-user to also initiate confirmation of their mobile
	/// phone. This number must be supplied by the API caller (using
	/// mobilePhoneNumber) Default=false. 
    /// </summary>
	public partial class CreateAccountWebOptionsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string returnUrlField;
		public string returnUrl
		{
			get
			{
				return this.returnUrlField;
			}
			set
			{
				this.returnUrlField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private bool? showAddCreditCardField;
		public bool? showAddCreditCard
		{
			get
			{
				return this.showAddCreditCardField;
			}
			set
			{
				this.showAddCreditCardField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private bool? showMobileConfirmField;
		public bool? showMobileConfirm
		{
			get
			{
				return this.showMobileConfirmField;
			}
			set
			{
				this.showMobileConfirmField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string returnUrlDescriptionField;
		public string returnUrlDescription
		{
			get
			{
				return this.returnUrlDescriptionField;
			}
			set
			{
				this.returnUrlDescriptionField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private bool? useMiniBrowserField;
		public bool? useMiniBrowser
		{
			get
			{
				return this.useMiniBrowserField;
			}
			set
			{
				this.useMiniBrowserField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string reminderEmailFrequencyField;
		public string reminderEmailFrequency
		{
			get
			{
				return this.reminderEmailFrequencyField;
			}
			set
			{
				this.reminderEmailFrequencyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string confirmEmailField;
		public string confirmEmail
		{
			get
			{
				return this.confirmEmailField;
			}
			set
			{
				this.confirmEmailField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CreateAccountWebOptionsType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.returnUrl != null)
			{
					sb.Append(prefix).Append("returnUrl").Append("=").Append(HttpUtility.UrlEncode(this.returnUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.showAddCreditCard != null)
			{
					sb.Append(prefix).Append("showAddCreditCard").Append("=").Append(this.showAddCreditCard.ToString().ToLower()).Append("&");
			}
			if (this.showMobileConfirm != null)
			{
					sb.Append(prefix).Append("showMobileConfirm").Append("=").Append(this.showMobileConfirm.ToString().ToLower()).Append("&");
			}
			if (this.returnUrlDescription != null)
			{
					sb.Append(prefix).Append("returnUrlDescription").Append("=").Append(HttpUtility.UrlEncode(this.returnUrlDescription, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.useMiniBrowser != null)
			{
					sb.Append(prefix).Append("useMiniBrowser").Append("=").Append(this.useMiniBrowser.ToString().ToLower()).Append("&");
			}
			if (this.reminderEmailFrequency != null)
			{
					sb.Append(prefix).Append("reminderEmailFrequency").Append("=").Append(HttpUtility.UrlEncode(this.reminderEmailFrequency, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.confirmEmail != null)
			{
					sb.Append(prefix).Append("confirmEmail").Append("=").Append(HttpUtility.UrlEncode(this.confirmEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// PayPal Business Category. i.e., baby - 1004 
    /// </summary>
	public partial class BusinessInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string businessNameField;
		public string businessName
		{
			get
			{
				return this.businessNameField;
			}
			set
			{
				this.businessNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AddressType businessAddressField;
		public AddressType businessAddress
		{
			get
			{
				return this.businessAddressField;
			}
			set
			{
				this.businessAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string workPhoneField;
		public string workPhone
		{
			get
			{
				return this.workPhoneField;
			}
			set
			{
				this.workPhoneField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? categoryField;
		public int? category
		{
			get
			{
				return this.categoryField;
			}
			set
			{
				this.categoryField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? subCategoryField;
		public int? subCategory
		{
			get
			{
				return this.subCategoryField;
			}
			set
			{
				this.subCategoryField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? merchantCategoryCodeField;
		public int? merchantCategoryCode
		{
			get
			{
				return this.merchantCategoryCodeField;
			}
			set
			{
				this.merchantCategoryCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string doingBusinessAsField;
		public string doingBusinessAs
		{
			get
			{
				return this.doingBusinessAsField;
			}
			set
			{
				this.doingBusinessAsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string customerServicePhoneField;
		public string customerServicePhone
		{
			get
			{
				return this.customerServicePhoneField;
			}
			set
			{
				this.customerServicePhoneField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string customerServiceEmailField;
		public string customerServiceEmail
		{
			get
			{
				return this.customerServiceEmailField;
			}
			set
			{
				this.customerServiceEmailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string disputeEmailField;
		public string disputeEmail
		{
			get
			{
				return this.disputeEmailField;
			}
			set
			{
				this.disputeEmailField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string webSiteField;
		public string webSite
		{
			get
			{
				return this.webSiteField;
			}
			set
			{
				this.webSiteField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string companyIdField;
		public string companyId
		{
			get
			{
				return this.companyIdField;
			}
			set
			{
				this.companyIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dateOfEstablishmentField;
		public string dateOfEstablishment
		{
			get
			{
				return this.dateOfEstablishmentField;
			}
			set
			{
				this.dateOfEstablishmentField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BusinessType? businessTypeField;
		public BusinessType? businessType
		{
			get
			{
				return this.businessTypeField;
			}
			set
			{
				this.businessTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BusinessSubtypeType? businessSubtypeField;
		public BusinessSubtypeType? businessSubtype
		{
			get
			{
				return this.businessSubtypeField;
			}
			set
			{
				this.businessSubtypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string incorporationIdField;
		public string incorporationId
		{
			get
			{
				return this.incorporationIdField;
			}
			set
			{
				this.incorporationIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? averagePriceField;
		public decimal? averagePrice
		{
			get
			{
				return this.averagePriceField;
			}
			set
			{
				this.averagePriceField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private decimal? averageMonthlyVolumeField;
		public decimal? averageMonthlyVolume
		{
			get
			{
				return this.averageMonthlyVolumeField;
			}
			set
			{
				this.averageMonthlyVolumeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? percentageRevenueFromOnlineField;
		public int? percentageRevenueFromOnline
		{
			get
			{
				return this.percentageRevenueFromOnlineField;
			}
			set
			{
				this.percentageRevenueFromOnlineField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<SalesVenueType?> salesVenueField = new List<SalesVenueType?>();
		public List<SalesVenueType?> salesVenue
		{
			get
			{
				return this.salesVenueField;
			}
			set
			{
				this.salesVenueField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string salesVenueDescField;
		public string salesVenueDesc
		{
			get
			{
				return this.salesVenueDescField;
			}
			set
			{
				this.salesVenueDescField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string vatIdField;
		public string vatId
		{
			get
			{
				return this.vatIdField;
			}
			set
			{
				this.vatIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string vatCountryCodeField;
		public string vatCountryCode
		{
			get
			{
				return this.vatCountryCodeField;
			}
			set
			{
				this.vatCountryCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string commercialRegistrationLocationField;
		public string commercialRegistrationLocation
		{
			get
			{
				return this.commercialRegistrationLocationField;
			}
			set
			{
				this.commercialRegistrationLocationField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AddressType principalPlaceOfBusinessAddressField;
		public AddressType principalPlaceOfBusinessAddress
		{
			get
			{
				return this.principalPlaceOfBusinessAddressField;
			}
			set
			{
				this.principalPlaceOfBusinessAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AddressType registeredOfficeAddressField;
		public AddressType registeredOfficeAddress
		{
			get
			{
				return this.registeredOfficeAddressField;
			}
			set
			{
				this.registeredOfficeAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string establishmentCountryCodeField;
		public string establishmentCountryCode
		{
			get
			{
				return this.establishmentCountryCodeField;
			}
			set
			{
				this.establishmentCountryCodeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string establishmentStateField;
		public string establishmentState
		{
			get
			{
				return this.establishmentStateField;
			}
			set
			{
				this.establishmentStateField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<BusinessStakeholderType> businessStakeholderField = new List<BusinessStakeholderType>();
		public List<BusinessStakeholderType> businessStakeholder
		{
			get
			{
				return this.businessStakeholderField;
			}
			set
			{
				this.businessStakeholderField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private BusinessEntityForThirdPartyType businessEntityForThirdPartyField;
		public BusinessEntityForThirdPartyType businessEntityForThirdParty
		{
			get
			{
				return this.businessEntityForThirdPartyField;
			}
			set
			{
				this.businessEntityForThirdPartyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private YesNoType? hasDirectorsField;
		public YesNoType? hasDirectors
		{
			get
			{
				return this.hasDirectorsField;
			}
			set
			{
				this.hasDirectorsField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private YesNoType? hasBeneficialOwnersField;
		public YesNoType? hasBeneficialOwners
		{
			get
			{
				return this.hasBeneficialOwnersField;
			}
			set
			{
				this.hasBeneficialOwnersField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private YesNoType? hasThirdPartyAssociatesField;
		public YesNoType? hasThirdPartyAssociates
		{
			get
			{
				return this.hasThirdPartyAssociatesField;
			}
			set
			{
				this.hasThirdPartyAssociatesField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public BusinessInfoType(string businessName, AddressType businessAddress, string workPhone)
	 	{
			this.businessName = businessName;
			this.businessAddress = businessAddress;
			this.workPhone = workPhone;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public BusinessInfoType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.businessName != null)
			{
					sb.Append(prefix).Append("businessName").Append("=").Append(HttpUtility.UrlEncode(this.businessName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.businessAddress != null)
			{
					string newPrefix = prefix + "businessAddress" + ".";
					sb.Append(this.businessAddressField.ToNVPString(newPrefix));
			}
			if (this.workPhone != null)
			{
					sb.Append(prefix).Append("workPhone").Append("=").Append(HttpUtility.UrlEncode(this.workPhone, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.category != null)
			{
					sb.Append(prefix).Append("category").Append("=").Append(this.category).Append("&");
			}
			if (this.subCategory != null)
			{
					sb.Append(prefix).Append("subCategory").Append("=").Append(this.subCategory).Append("&");
			}
			if (this.merchantCategoryCode != null)
			{
					sb.Append(prefix).Append("merchantCategoryCode").Append("=").Append(this.merchantCategoryCode).Append("&");
			}
			if (this.doingBusinessAs != null)
			{
					sb.Append(prefix).Append("doingBusinessAs").Append("=").Append(HttpUtility.UrlEncode(this.doingBusinessAs, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerServicePhone != null)
			{
					sb.Append(prefix).Append("customerServicePhone").Append("=").Append(HttpUtility.UrlEncode(this.customerServicePhone, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.customerServiceEmail != null)
			{
					sb.Append(prefix).Append("customerServiceEmail").Append("=").Append(HttpUtility.UrlEncode(this.customerServiceEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.disputeEmail != null)
			{
					sb.Append(prefix).Append("disputeEmail").Append("=").Append(HttpUtility.UrlEncode(this.disputeEmail, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.webSite != null)
			{
					sb.Append(prefix).Append("webSite").Append("=").Append(HttpUtility.UrlEncode(this.webSite, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.companyId != null)
			{
					sb.Append(prefix).Append("companyId").Append("=").Append(HttpUtility.UrlEncode(this.companyId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.dateOfEstablishment != null)
			{
					sb.Append(prefix).Append("dateOfEstablishment").Append("=").Append(this.dateOfEstablishment).Append("&");
			}
			if (this.businessType != null)
			{
					sb.Append(prefix).Append("businessType").Append("=").Append(EnumUtils.GetDescription(this.businessType));
					sb.Append("&");
			}
			if (this.businessSubtype != null)
			{
					sb.Append(prefix).Append("businessSubtype").Append("=").Append(EnumUtils.GetDescription(this.businessSubtype));
					sb.Append("&");
			}
			if (this.incorporationId != null)
			{
					sb.Append(prefix).Append("incorporationId").Append("=").Append(HttpUtility.UrlEncode(this.incorporationId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.averagePrice != null)
			{
					sb.Append(prefix).Append("averagePrice").Append("=").Append(Convert.ToString(this.averagePrice, DefaultCulture)).Append("&");
			}
			if (this.averageMonthlyVolume != null)
			{
					sb.Append(prefix).Append("averageMonthlyVolume").Append("=").Append(Convert.ToString(this.averageMonthlyVolume, DefaultCulture)).Append("&");
			}
			if (this.percentageRevenueFromOnline != null)
			{
					sb.Append(prefix).Append("percentageRevenueFromOnline").Append("=").Append(this.percentageRevenueFromOnline).Append("&");
			}
			for (int i = 0; i < this.salesVenue.Count; i++)
			{
				if (this.salesVenue[i] != null)
				{
					sb.Append(prefix).Append("salesVenue(").Append(i).Append(")=").Append(EnumUtils.GetDescription(this.salesVenue[i]));
					sb.Append("&");
				}
			}
			if (this.salesVenueDesc != null)
			{
					sb.Append(prefix).Append("salesVenueDesc").Append("=").Append(HttpUtility.UrlEncode(this.salesVenueDesc, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.vatId != null)
			{
					sb.Append(prefix).Append("vatId").Append("=").Append(HttpUtility.UrlEncode(this.vatId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.vatCountryCode != null)
			{
					sb.Append(prefix).Append("vatCountryCode").Append("=").Append(HttpUtility.UrlEncode(this.vatCountryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.commercialRegistrationLocation != null)
			{
					sb.Append(prefix).Append("commercialRegistrationLocation").Append("=").Append(HttpUtility.UrlEncode(this.commercialRegistrationLocation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.principalPlaceOfBusinessAddress != null)
			{
					string newPrefix = prefix + "principalPlaceOfBusinessAddress" + ".";
					sb.Append(this.principalPlaceOfBusinessAddressField.ToNVPString(newPrefix));
			}
			if (this.registeredOfficeAddress != null)
			{
					string newPrefix = prefix + "registeredOfficeAddress" + ".";
					sb.Append(this.registeredOfficeAddressField.ToNVPString(newPrefix));
			}
			if (this.establishmentCountryCode != null)
			{
					sb.Append(prefix).Append("establishmentCountryCode").Append("=").Append(HttpUtility.UrlEncode(this.establishmentCountryCode, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.establishmentState != null)
			{
					sb.Append(prefix).Append("establishmentState").Append("=").Append(HttpUtility.UrlEncode(this.establishmentState, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			for (int i = 0; i < this.businessStakeholder.Count; i++)
			{
				if (this.businessStakeholder[i] != null)
				{
					string newPrefix = prefix + "businessStakeholder" + "(" + i + ").";
					sb.Append(this.businessStakeholder[i].ToNVPString(newPrefix));
				}
			}
			if (this.businessEntityForThirdParty != null)
			{
					string newPrefix = prefix + "businessEntityForThirdParty" + ".";
					sb.Append(this.businessEntityForThirdPartyField.ToNVPString(newPrefix));
			}
			if (this.hasDirectors != null)
			{
					sb.Append(prefix).Append("hasDirectors").Append("=").Append(EnumUtils.GetDescription(this.hasDirectors));
					sb.Append("&");
			}
			if (this.hasBeneficialOwners != null)
			{
					sb.Append(prefix).Append("hasBeneficialOwners").Append("=").Append(EnumUtils.GetDescription(this.hasBeneficialOwners));
					sb.Append("&");
			}
			if (this.hasThirdPartyAssociates != null)
			{
					sb.Append(prefix).Append("hasThirdPartyAssociates").Append("=").Append(EnumUtils.GetDescription(this.hasThirdPartyAssociates));
					sb.Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Info about Stakeholders such as partner, beneficial, owner,
	/// director etc. 
    /// </summary>
	public partial class BusinessStakeholderType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private StakeholderRoleType? roleField;
		public StakeholderRoleType? role
		{
			get
			{
				return this.roleField;
			}
			set
			{
				this.roleField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private NameType nameField;
		public NameType name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string fullLegalNameField;
		public string fullLegalName
		{
			get
			{
				return this.fullLegalNameField;
			}
			set
			{
				this.fullLegalNameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AddressType addressField;
		public AddressType address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dateOfBirthField;
		public string dateOfBirth
		{
			get
			{
				return this.dateOfBirthField;
			}
			set
			{
				this.dateOfBirthField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string occupationField;
		public string occupation
		{
			get
			{
				return this.occupationField;
			}
			set
			{
				this.occupationField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public BusinessStakeholderType(StakeholderRoleType? role)
	 	{
			this.role = role;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public BusinessStakeholderType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.role != null)
			{
					sb.Append(prefix).Append("role").Append("=").Append(EnumUtils.GetDescription(this.role));
					sb.Append("&");
			}
			if (this.name != null)
			{
					string newPrefix = prefix + "name" + ".";
					sb.Append(this.nameField.ToNVPString(newPrefix));
			}
			if (this.fullLegalName != null)
			{
					sb.Append(prefix).Append("fullLegalName").Append("=").Append(HttpUtility.UrlEncode(this.fullLegalName, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.address != null)
			{
					string newPrefix = prefix + "address" + ".";
					sb.Append(this.addressField.ToNVPString(newPrefix));
			}
			if (this.dateOfBirth != null)
			{
					sb.Append(prefix).Append("dateOfBirth").Append("=").Append(this.dateOfBirth).Append("&");
			}
			if (this.occupation != null)
			{
					sb.Append(prefix).Append("occupation").Append("=").Append(HttpUtility.UrlEncode(this.occupation, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Info about PayPal user such as emailAddress, accountId,
	/// firstName, lastName etc. 
    /// </summary>
	public partial class UserInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string emailAddressField;
		public string emailAddress
		{
			get
			{
				return this.emailAddressField;
			}
			set
			{
				this.emailAddressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountTypeField;
		public string accountType
		{
			get
			{
				return this.accountTypeField;
			}
			set
			{
				this.accountTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string accountIdField;
		public string accountId
		{
			get
			{
				return this.accountIdField;
			}
			set
			{
				this.accountIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private NameType nameField;
		public NameType name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string businessNameField;
		public string businessName
		{
			get
			{
				return this.businessNameField;
			}
			set
			{
				this.businessNameField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public UserInfoType()
	 	{
		}


		/// <summary>
		/// Factory method for creating new object instances. For use by the de-serialization classes only.
	 	/// </summary>
	 	/// <param name="map">NVP map as returned by an API call</param>
	 	/// <param name="prefix">NVP prefix for this class in the response</param>
	 	/// <param name="index">For array elements, index of this element in the response</param>
	 	/// <returns>
	 	/// A new UserInfoType object created from the passed in NVP map
	 	/// </returns>
		public static UserInfoType CreateInstance(Dictionary<string, string> map, string prefix, int index)
		{
			UserInfoType userInfoType = null;
			string key;
			int i = 0;
			if(index != -1)
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + "(" + index + ").";
				}
			} 
			else
			{
				if (prefix.Length > 0 && !prefix.EndsWith("."))
				{
					prefix = prefix + ".";
				}
			}
			key = prefix + "emailAddress";
			if (map.ContainsKey(key))
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.emailAddress = map[key];
			}
			key = prefix + "accountType";
			if (map.ContainsKey(key))
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.accountType = map[key];
			}
			key = prefix + "accountId";
			if (map.ContainsKey(key))
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.accountId = map[key];
			}
			NameType name =  NameType.CreateInstance(map, prefix + "name", -1);
			if (name != null)
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.name = name;
			}
			key = prefix + "businessName";
			if (map.ContainsKey(key))
			{
				userInfoType = (userInfoType == null) ? new UserInfoType() : userInfoType;
				userInfoType.businessName = map[key];
			}
			return userInfoType;
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class WebOptionsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string returnUrlField;
		public string returnUrl
		{
			get
			{
				return this.returnUrlField;
			}
			set
			{
				this.returnUrlField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cancelUrlField;
		public string cancelUrl
		{
			get
			{
				return this.cancelUrlField;
			}
			set
			{
				this.cancelUrlField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string returnUrlDescriptionField;
		public string returnUrlDescription
		{
			get
			{
				return this.returnUrlDescriptionField;
			}
			set
			{
				this.returnUrlDescriptionField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string cancelUrlDescriptionField;
		public string cancelUrlDescription
		{
			get
			{
				return this.cancelUrlDescriptionField;
			}
			set
			{
				this.cancelUrlDescriptionField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public WebOptionsType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.returnUrl != null)
			{
					sb.Append(prefix).Append("returnUrl").Append("=").Append(HttpUtility.UrlEncode(this.returnUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.cancelUrl != null)
			{
					sb.Append(prefix).Append("cancelUrl").Append("=").Append(HttpUtility.UrlEncode(this.cancelUrl, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.returnUrlDescription != null)
			{
					sb.Append(prefix).Append("returnUrlDescription").Append("=").Append(HttpUtility.UrlEncode(this.returnUrlDescription, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.cancelUrlDescription != null)
			{
					sb.Append(prefix).Append("cancelUrlDescription").Append("=").Append(HttpUtility.UrlEncode(this.cancelUrlDescription, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Month in integer format, between 1 and 12 
    /// </summary>
	public partial class CardDateType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private int? monthField;
		public int? month
		{
			get
			{
				return this.monthField;
			}
			set
			{
				this.monthField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private int? yearField;
		public int? year
		{
			get
			{
				return this.yearField;
			}
			set
			{
				this.yearField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public CardDateType(int? month, int? year)
	 	{
			this.month = month;
			this.year = year;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public CardDateType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.month != null)
			{
					sb.Append(prefix).Append("month").Append("=").Append(this.month).Append("&");
			}
			if (this.year != null)
			{
					sb.Append(prefix).Append("year").Append("=").Append(this.year).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// Third party type: Individual or Business. 
    /// </summary>
	public partial class BusinessEntityForThirdPartyType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string thirdPartyTypeField;
		public string thirdPartyType
		{
			get
			{
				return this.thirdPartyTypeField;
			}
			set
			{
				this.thirdPartyTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private NameType nameField;
		public NameType name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string dateOfBirthField;
		public string dateOfBirth
		{
			get
			{
				return this.dateOfBirthField;
			}
			set
			{
				this.dateOfBirthField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private AddressType addressField;
		public AddressType address
		{
			get
			{
				return this.addressField;
			}
			set
			{
				this.addressField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string professionField;
		public string profession
		{
			get
			{
				return this.professionField;
			}
			set
			{
				this.professionField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string relationshipWithThirdPartyField;
		public string relationshipWithThirdParty
		{
			get
			{
				return this.relationshipWithThirdPartyField;
			}
			set
			{
				this.relationshipWithThirdPartyField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string natureOfBusinessField;
		public string natureOfBusiness
		{
			get
			{
				return this.natureOfBusinessField;
			}
			set
			{
				this.natureOfBusinessField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string nameOfBusinessField;
		public string nameOfBusiness
		{
			get
			{
				return this.nameOfBusinessField;
			}
			set
			{
				this.nameOfBusinessField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string businessTypeField;
		public string businessType
		{
			get
			{
				return this.businessTypeField;
			}
			set
			{
				this.businessTypeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string incorporationIdField;
		public string incorporationId
		{
			get
			{
				return this.incorporationIdField;
			}
			set
			{
				this.incorporationIdField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string incorporationCountryField;
		public string incorporationCountry
		{
			get
			{
				return this.incorporationCountryField;
			}
			set
			{
				this.incorporationCountryField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string incorporationStateField;
		public string incorporationState
		{
			get
			{
				return this.incorporationStateField;
			}
			set
			{
				this.incorporationStateField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public BusinessEntityForThirdPartyType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.thirdPartyType != null)
			{
					sb.Append(prefix).Append("thirdPartyType").Append("=").Append(HttpUtility.UrlEncode(this.thirdPartyType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.name != null)
			{
					string newPrefix = prefix + "name" + ".";
					sb.Append(this.nameField.ToNVPString(newPrefix));
			}
			if (this.dateOfBirth != null)
			{
					sb.Append(prefix).Append("dateOfBirth").Append("=").Append(this.dateOfBirth).Append("&");
			}
			if (this.address != null)
			{
					string newPrefix = prefix + "address" + ".";
					sb.Append(this.addressField.ToNVPString(newPrefix));
			}
			if (this.profession != null)
			{
					sb.Append(prefix).Append("profession").Append("=").Append(HttpUtility.UrlEncode(this.profession, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.relationshipWithThirdParty != null)
			{
					sb.Append(prefix).Append("relationshipWithThirdParty").Append("=").Append(HttpUtility.UrlEncode(this.relationshipWithThirdParty, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.natureOfBusiness != null)
			{
					sb.Append(prefix).Append("natureOfBusiness").Append("=").Append(HttpUtility.UrlEncode(this.natureOfBusiness, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.nameOfBusiness != null)
			{
					sb.Append(prefix).Append("nameOfBusiness").Append("=").Append(HttpUtility.UrlEncode(this.nameOfBusiness, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.businessType != null)
			{
					sb.Append(prefix).Append("businessType").Append("=").Append(HttpUtility.UrlEncode(this.businessType, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.incorporationId != null)
			{
					sb.Append(prefix).Append("incorporationId").Append("=").Append(HttpUtility.UrlEncode(this.incorporationId, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.incorporationCountry != null)
			{
					sb.Append(prefix).Append("incorporationCountry").Append("=").Append(HttpUtility.UrlEncode(this.incorporationCountry, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.incorporationState != null)
			{
					sb.Append(prefix).Append("incorporationState").Append("=").Append(HttpUtility.UrlEncode(this.incorporationState, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class GovernmentIDPair	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string valueField;
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private GovernmentIDTypes? typeField;
		public GovernmentIDTypes? type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public GovernmentIDPair()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.value != null)
			{
					sb.Append(prefix).Append("value").Append("=").Append(HttpUtility.UrlEncode(this.value, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.type != null)
			{
					sb.Append(prefix).Append("type").Append("=").Append(EnumUtils.GetDescription(this.type));
					sb.Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class LegalAgreementType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string acceptedField;
		public string accepted
		{
			get
			{
				return this.acceptedField;
			}
			set
			{
				this.acceptedField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private LegalAgreementTypes? typeField;
		public LegalAgreementTypes? type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public LegalAgreementType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.accepted != null)
			{
					sb.Append(prefix).Append("accepted").Append("=").Append(HttpUtility.UrlEncode(this.accepted, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.type != null)
			{
					sb.Append(prefix).Append("type").Append("=").Append(EnumUtils.GetDescription(this.type));
					sb.Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class Auditor	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string idField;
		public string id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string nameField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string actionField;
		public string action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string notesField;
		public string notes
		{
			get
			{
				return this.notesField;
			}
			set
			{
				this.notesField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public Auditor(string id, string name, string action)
	 	{
			this.id = id;
			this.name = name;
			this.action = action;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public Auditor()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.id != null)
			{
					sb.Append(prefix).Append("id").Append("=").Append(HttpUtility.UrlEncode(this.id, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.name != null)
			{
					sb.Append(prefix).Append("name").Append("=").Append(HttpUtility.UrlEncode(this.name, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.action != null)
			{
					sb.Append(prefix).Append("action").Append("=").Append(HttpUtility.UrlEncode(this.action, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.notes != null)
			{
					sb.Append(prefix).Append("notes").Append("=").Append(HttpUtility.UrlEncode(this.notes, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class TupleType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string nameField;
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string valueField;
		public string value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public TupleType(string name, string value)
	 	{
			this.name = name;
			this.value = value;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public TupleType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.name != null)
			{
					sb.Append(prefix).Append("name").Append("=").Append(HttpUtility.UrlEncode(this.name, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.value != null)
			{
					sb.Append(prefix).Append("value").Append("=").Append(HttpUtility.UrlEncode(this.value, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class DocumentType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string typeField;
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<string> filenameField = new List<string>();
		public List<string> filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public DocumentType(string type, List<string> filename)
	 	{
			this.type = type;
			this.filename = filename;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public DocumentType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.type != null)
			{
					sb.Append(prefix).Append("type").Append("=").Append(HttpUtility.UrlEncode(this.type, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			for (int i = 0; i < this.filename.Count; i++)
			{
				if (this.filename[i] != null)
				{
					sb.Append(prefix).Append("filename").Append("(").Append(i).Append(")").Append("=").Append(HttpUtility.UrlEncode(this.filename[i], BaseConstants.ENCODING_FORMAT)).Append("&");
				}
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class AuditorList	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private List<Auditor> auditorField = new List<Auditor>();
		public List<Auditor> auditor
		{
			get
			{
				return this.auditorField;
			}
			set
			{
				this.auditorField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public AuditorList(List<Auditor> auditor)
	 	{
			this.auditor = auditor;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AuditorList()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < this.auditor.Count; i++)
			{
				if (this.auditor[i] != null)
				{
					string newPrefix = prefix + "auditor" + "(" + i + ").";
					sb.Append(this.auditor[i].ToNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class AuditeeInfoType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private AccountIdentifierType accountIdentifierField;
		public AccountIdentifierType accountIdentifier
		{
			get
			{
				return this.accountIdentifierField;
			}
			set
			{
				this.accountIdentifierField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<DocumentType> documentField = new List<DocumentType>();
		public List<DocumentType> document
		{
			get
			{
				return this.documentField;
			}
			set
			{
				this.documentField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<TupleType> dataField = new List<TupleType>();
		public List<TupleType> data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public AuditeeInfoType(AccountIdentifierType accountIdentifier)
	 	{
			this.accountIdentifier = accountIdentifier;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AuditeeInfoType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.accountIdentifier != null)
			{
					string newPrefix = prefix + "accountIdentifier" + ".";
					sb.Append(this.accountIdentifierField.ToNVPString(newPrefix));
			}
			for (int i = 0; i < this.document.Count; i++)
			{
				if (this.document[i] != null)
				{
					string newPrefix = prefix + "document" + "(" + i + ").";
					sb.Append(this.document[i].ToNVPString(newPrefix));
				}
			}
			for (int i = 0; i < this.data.Count; i++)
			{
				if (this.data[i] != null)
				{
					string newPrefix = prefix + "data" + "(" + i + ").";
					sb.Append(this.data[i].ToNVPString(newPrefix));
				}
			}
			return sb.ToString();
		}
	}




	/// <summary>
	/// 
    /// </summary>
	public partial class AuditDetailsType	{
		
		// Default US culture info
		private static CultureInfo DefaultCulture = new CultureInfo("en-US");

		/// <summary>
		/// 
		/// </summary>
		private string statusField;
		public string status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string levelField;
		public string level
		{
			get
			{
				return this.levelField;
			}
			set
			{
				this.levelField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string methodField;
		public string method
		{
			get
			{
				return this.methodField;
			}
			set
			{
				this.methodField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string reasonField;
		public string reason
		{
			get
			{
				return this.reasonField;
			}
			set
			{
				this.reasonField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private List<TupleType> dataField = new List<TupleType>();
		public List<TupleType> data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}
		

		/// <summary>
		/// 
		/// </summary>
		private string policyVersionField;
		public string policyVersion
		{
			get
			{
				return this.policyVersionField;
			}
			set
			{
				this.policyVersionField = value;
			}
		}
		

		/// <summary>
		/// Constructor with arguments
	 	/// </summary>
	 	public AuditDetailsType(string status, string level, string method, string reason)
	 	{
			this.status = status;
			this.level = level;
			this.method = method;
			this.reason = reason;
		}

		/// <summary>
		/// Default Constructor
	 	/// </summary>
	 	public AuditDetailsType()
	 	{
		}


		public string ToNVPString(string prefix)
		{
			StringBuilder sb = new StringBuilder();
			if (this.status != null)
			{
					sb.Append(prefix).Append("status").Append("=").Append(HttpUtility.UrlEncode(this.status, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.level != null)
			{
					sb.Append(prefix).Append("level").Append("=").Append(HttpUtility.UrlEncode(this.level, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.method != null)
			{
					sb.Append(prefix).Append("method").Append("=").Append(HttpUtility.UrlEncode(this.method, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			if (this.reason != null)
			{
					sb.Append(prefix).Append("reason").Append("=").Append(HttpUtility.UrlEncode(this.reason, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			for (int i = 0; i < this.data.Count; i++)
			{
				if (this.data[i] != null)
				{
					string newPrefix = prefix + "data" + "(" + i + ").";
					sb.Append(this.data[i].ToNVPString(newPrefix));
				}
			}
			if (this.policyVersion != null)
			{
					sb.Append(prefix).Append("policyVersion").Append("=").Append(HttpUtility.UrlEncode(this.policyVersion, BaseConstants.ENCODING_FORMAT)).Append("&");
			}
			return sb.ToString();
		}
	}





}