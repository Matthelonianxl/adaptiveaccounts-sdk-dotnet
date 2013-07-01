using System;
using System.Web;
using System.Collections.Generic;
using System.Collections.Specialized;
using PayPal.AdaptiveAccounts;
using PayPal.AdaptiveAccounts.Model;

namespace AdaptiveAccountsSampleApp
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>    
    public class adaptiveaccountshandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            string strCall = context.Request.Params["AdaptiveAccountsBtn"];

            if (strCall.Equals("CreateAccount"))
            {
                CreateAccount(context);
            }
            else if (strCall.Equals("AddBankAccount"))
            {
                AddBankAccount(context);
            }
            else if (strCall.Equals("AddPaymentCard"))
            {
                AddPaymentCard(context);
            }
            else if (strCall.Equals("GetVerifiedStatus"))
            {
                GetVerifiedStatus(context);
            }
            else if (strCall.Equals("GetUserAgreement"))
            {
                GetUserAgreement(context);
            }
            else if (strCall.Equals("SetFundingSourceConfirmed"))
            {
                SetFundingSourceConfirmed(context);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        private void CreateAccount(HttpContext context)
        {
            // #CreateAccount API
            // The CreateAccount API operation enables you to create a PayPal account on behalf of a third party.
            NameValueCollection parameters = context.Request.Params;

            // The name of the person for whom the PayPal account is
            // created, which
            // contains
            //
            // * `FirstName` - First name of the account or payment card
            // holder.
            // * `LastName` - Last name of the account or payment card
            // holder.
            NameType name = new NameType(parameters["firstName"], parameters["lastName"]);

            //(Optional) A salutation for the account or payment card holder. 
            if (parameters["salutation"] != string.Empty)
                name.salutation = parameters["salutation"];

            //Optional) Middle name of the account or payment card holder. 
            if (parameters["middleName"] != string.Empty)
                name.middleName = parameters["middleName"];

            //(Optional) A suffix for the account or payment card holder. 
            if (parameters["suffix"] != string.Empty)
                name.suffix = parameters["suffix"];

            // Address of the person for whom the PayPal account is created
            AddressType address = new AddressType(parameters["line1"], parameters["countryCode"]);

            //(Optional) Second line of the address.
		    // Note: This field is required for Brazilian addresses. 
            if (parameters["line2"] != string.Empty)
                address.line2 = parameters["line2"];

            //(Required) City name
            if (parameters["city"] != string.Empty)
                address.city = parameters["city"];

            //(Optional) State code.
            if (parameters["state"] != string.Empty)
                address.state = parameters["state"];

            //(Optional) Zip or postal code. 
            if (parameters["postalCode"] != string.Empty)
                address.postalCode = parameters["postalCode"];

            // Instantiating createAccountRequest with mandatory arguments:
            //
            // * `requestenvelope` - Information common to each API
            // operation, such
            // as the language in which an error message is returned.
            // * `name` - The name of the person for whom the PayPal account
            // is
            // created.
            // * `address` - The address to be associated with the PayPal
            // account.
            // * `preferredlanguagecode`- The code indicating the language
            // to be
            // associated with the account.
            // What value is allowed depends on the country code passed in
            // the
            // countryCode parameter for the address.
            // For Example: United States (US) - en_US
            CreateAccountRequest req = new CreateAccountRequest(new RequestEnvelope(), name, address,
                parameters["preferredLanguageCode"]);

            // The type of account to create. Allowed values:
            // 
            // *Personal – Personal account
            // *Premier – Premier account
            // *Business – Business account
            if (parameters["accountType"] != string.Empty)
                req.accountType = parameters["accountType"];
            // Phone Number to be associated with the account.
            if(parameters["contactPhoneNumber"] != string.Empty)
                req.contactPhoneNumber = parameters["contactPhoneNumber"];
            if (parameters["homePhoneNumber"] != string.Empty)
                req.homePhoneNumber = parameters["homePhoneNumber"];
            if (parameters["mobilePhoneNumber"] != string.Empty)
                req.mobilePhoneNumber = parameters["mobilePhoneNumber"];

            // Email address of person for whom the PayPal account is
            // created.
            if (parameters["emailAddress"] != string.Empty)
                req.emailAddress = parameters["emailAddress"];

            // The three letter code for the currency to be associated with
            // the account
            if (parameters["currencyCode"] != string.Empty)
                req.currencyCode = parameters["currencyCode"];

            // The code of the country to be associated with the account.
            req.citizenshipCountryCode = parameters["citizenshipCountryCode"];

            // This attribute determines whether a key or a URL is returned
            // for the redirect URL. Allowable value(s) currently
            // supported:`Web` - Returns a URL
            req.registrationType = parameters["registrationType"];

            // The URL to post instant payment notification (IPN) messages
            // to
            // regarding account creation. This URL supersedes the IPN
            // notification
            // URL set in the merchant profile.
            if (parameters["notificationUrl"] != string.Empty)
            {
                req.notificationURL = parameters["notificationUrl"];
            }

            if (parameters["returnUrl"] != string.Empty || parameters["returnUrlDescription"] != string.Empty
                || parameters["showAddCreditCard"] != string.Empty || parameters["showMobileConfirm"] != string.Empty
                || parameters["useMiniBrowser"] != string.Empty)
            {
                // Used for configuration settings for the web flow
                CreateAccountWebOptionsType webOptions = new CreateAccountWebOptionsType();
                req.createAccountWebOptions = webOptions;

                // (Required) The URL to which you want the account holder to return when he or she finishes account registration. 
                // This URL appears as a link on the final page of the PayPal account registration flow.
                // The text of this link is the text passed in the returnUrlDescription request parameter (below).
                if (parameters["returnUrl"] != string.Empty)
                    webOptions.returnUrl = parameters["returnUrl"];
                //(Optional) A description of the return URL. 
                if (parameters["returnUrlDescription"] != string.Empty)
                    webOptions.returnUrlDescription = parameters["returnUrlDescription"];
                // (Optional) Defines whether the "add credit card" option is included in the PayPal account registration flow.
                //    true - Show the option (default)
                //    false - Do not show the option
                if (parameters["showAddCreditCard"] != string.Empty)
                    webOptions.showAddCreditCard = Boolean.Parse(parameters["showAddCreditCard"]);

                // (Optional) Defines whether the "mobile confirmation" option is included in the PayPal account registration flow.
                //	    true - Show the option
                //	    false - Do not show the option (default)
                if (parameters["showMobileConfirm"] != string.Empty)
                    webOptions.showMobileConfirm = Boolean.Parse(parameters["showMobileConfirm"]);

                // (Optional) Defines whether to use the minibrowser account registration flow or the traditional account registration flow.
                //    true - Use the minibrowser flow
                //    false - Use the traditional flow (default)
                if (parameters["useMiniBrowser"] != string.Empty)
                    webOptions.useMiniBrowser = Boolean.Parse(parameters["useMiniBrowser"]);
            }


            // Create the AdaptiveAccounts service object to make the API call
            AdaptiveAccountsService service = null;
            CreateAccountResponse resp = null;
            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer at 
                // (https://github.com/paypal/adaptiveaccounts-sdk-java/wiki/SDK-Configuration-Parameters)
                Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

                // Creating service wrapper object to make an API call and loading
                // configuration map for your credentials and endpoint
                service = new AdaptiveAccountsService(configurationMap);

                // # API call 
                // Invoke the CreateAccount method in service wrapper object    	
                resp = service.CreateAccount(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                redirectUrl =  resp.redirectURL;
                keyResponseParams.Add("Account Id", resp.accountId);
                keyResponseParams.Add("Create account key", resp.createAccountKey);
                keyResponseParams.Add("Execution status", resp.execStatus.ToString()); 

                //Selenium Test Case
                keyResponseParams.Add("Acknowledgement", resp.responseEnvelope.ack.ToString());
                keyResponseParams.Add("Redirect To PayPal", resp.redirectURL);                
            }
            displayResponse(context, "CreateAccount", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle AddBankAccount API call
        /// </summary>
        /// <param name="context"></param>
        private void AddBankAccount(HttpContext context)
        {
            // # AddBankAccount API
            // The AddBankAccount API operation lets your application set up bank accounts as funding sources for PayPal accounts.
            NameValueCollection parameters = context.Request.Params;

            ConfirmationType confirmationType = (ConfirmationType) 
                Enum.Parse(typeof(ConfirmationType), parameters["confirmationType"]);
            AddBankAccountRequest req = new AddBankAccountRequest(
                new RequestEnvelope(), parameters["bankCountryCode"], confirmationType);
            
            // set optional parameters
            // (Optional) The identification number of the PayPal account
            // for which a bank account is added. You must specify either
            // the accountId or emailAddress for this request.
            if (parameters["accountId"] != string.Empty)
                req.accountId = parameters["accountId"];

            // (Optional) The identification number of the PayPal account
            // for which a bank account is added. You must specify either
            // the accountId or emailAddress for this request.
            if (parameters["emailAddress"] != string.Empty)
                req.emailAddress = parameters["emailAddress"];
            if (parameters["createAccountKey"] != string.Empty)
                req.createAccountKey = parameters["createAccountKey"];

            // (Optional) The default value is UNKNOWN.
            if (parameters["bankName"] != string.Empty)
                req.bankName = parameters["bankName"];

            // (Optional) The bank's routing number.
            if (parameters["routingNumber"] != string.Empty)
                req.routingNumber = parameters["routingNumber"];

            // (Optional) The type of bank account to be added. Allowable
            // values are: CHECKING SAVINGS BUSINESS_SAVINGS
            // BUSINESS_CHECKINGS NORMAL UNKNOWN
            if (parameters["bankAccountType"] != string.Empty)
                req.bankAccountType = 
                    (BankAccountType) Enum.Parse( typeof(BankAccountType), parameters["bankAccountType"]);
            // (Optional) The account number (BBAN) of the bank account to
            // be added.
            if (parameters["bankAccountNumber"] != string.Empty)
                req.bankAccountNumber = parameters["bankAccountNumber"];

            // (Optional) The IBAN for the bank.
            if (parameters["iban"] != string.Empty)
                req.iban = parameters["iban"];

            // CLABE represents the bank information for countries like
            // Mexico.
            if (parameters["clabe"] != string.Empty)
                req.clabe = parameters["clabe"];

            // (Optional) The Bank/State/Branch number for the bank.
            if (parameters["bsbNumber"] != string.Empty)
                req.bsbNumber = parameters["bsbNumber"];

            // (Optional) The branch location.
            if (parameters["branchLocation"] != string.Empty)
                req.branchLocation = parameters["branchLocation"];

            // (Optional) The branch sort code.
            if (parameters["sortCode"] != string.Empty)
                req.sortCode = parameters["sortCode"];

            // (Optional) The transit number of the bank.
            if (parameters["bankTransitNumber"] != string.Empty)
                req.bankTransitNumber = parameters["bankTransitNumber"];

            // (Optional) The institution number for the bank.
            if (parameters["institutionNumber"] != string.Empty)
                req.institutionNumber = parameters["institutionNumber"];

            // (Optional) The branch code for the bank.
            if (parameters["branchCode"] != string.Empty)
                req.branchCode = parameters["branchCode"];
            if (parameters["agencyNumber"] != string.Empty)
                req.agencyNumber = parameters["agencyNumber"];

            // (Optional) The code that identifies the bank where the
            // account is held.
            if (parameters["bankCode"] != string.Empty)
                req.bankCode = parameters["bankCode"];

            // (Optional) The RIB key for the bank.
            if (parameters["ribKey"] != string.Empty)
                req.ribKey = parameters["ribKey"];

            // (Optional) The control digits for the bank.
            if (parameters["controlDigit"] != string.Empty)
                req.controlDigit = parameters["controlDigit"];
            if (parameters["taxIdType"] != string.Empty)
                req.taxIdType = parameters["taxIdType"];
            if (parameters["taxIdNumber"] != string.Empty)
                req.taxIdNumber = parameters["taxIdNumber"];

            // (Optional) The date of birth of the account holder in
            // YYYY-MM-DDZ format, for example 1970-01-01Z.
            if (parameters["accountHolderDateOfBirth"] != string.Empty)
                req.accountHolderDateOfBirth = parameters["accountHolderDateOfBirth"];

            // (Optional) Additional structure to define the URLs for the
            // cancellation and return web flows.
            if ( confirmationType == ConfirmationType.WEB &&
                (parameters["returnURL"] != string.Empty || parameters["returnURLDescription"] != string.Empty
                || parameters["cancelURL"] != string.Empty || parameters["cancelURLDescription"] != string.Empty))
            {
                req.webOptions = new WebOptionsType();

                // (Optional) The URL to which bank account/payment card holders
	            // return after they add the account or payment card.
                if (parameters["returnURL"] != string.Empty)
                    req.webOptions.returnUrl = parameters["returnURL"];
                if (parameters["returnURLDescription"] != string.Empty)
                    req.webOptions.returnUrlDescription = parameters["returnURLDescription"];

                // (Optional) The URL to which bank account/payment card holders
	            // return when they cancel the bank account addition flow.
                if (parameters["cancelURL"] != string.Empty)
                    req.webOptions.cancelUrl = parameters["cancelURL"];
                if (parameters["cancelURLDescription"] != string.Empty)
                    req.webOptions.cancelUrlDescription = parameters["cancelURLDescription"];
            }           

            // Create the AdaptiveAccounts service object to make the API call           
            AdaptiveAccountsService service = null;
            AddBankAccountResponse resp = null;
            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer at 
                // (https://github.com/paypal/adaptiveaccounts-sdk-java/wiki/SDK-Configuration-Parameters)
                Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

                // Creating service wrapper object to make an API call and loading
                // configuration map for your credentials and endpoint
                service = new AdaptiveAccountsService(configurationMap);

                // # API call 
                // Invoke the CreateAccount method in service wrapper object   
                resp = service.AddBankAccount(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                redirectUrl =  resp.redirectURL;
                keyResponseParams.Add("Execution status", resp.execStatus.ToString());
                keyResponseParams.Add("Funding source key", resp.fundingSourceKey);

                //Selenium Test Case
                keyResponseParams.Add("Acknowledgement", resp.responseEnvelope.ack.ToString());
                keyResponseParams.Add("Redirect To PayPal", resp.redirectURL);  
            }
            displayResponse(context, "AddBankAccount", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle AddPaymentCard API call
        /// </summary>
        /// <param name="context"></param>
        private void AddPaymentCard(HttpContext context)
        {
            // #AddPaymentCard API
            // The AddPaymentCard API operation lets your application set up payment cards as funding sources for PayPal accounts.
            NameValueCollection parameters = context.Request.Params;

            // (Required) Name (as it appears on the card) of the payment card holder.
            // (Required) First name of the account or payment card holder. (Required) Last name of the account or payment card holder.
            NameType nameOnCard = new NameType(parameters["firstName"], parameters["lastName"]);

            // (Optional) A salutation for the account or payment card holder.
            if (parameters["salutation"] != string.Empty)
                nameOnCard.salutation = parameters["salutation"];

            //(Optional) Middle name of the account or payment card holder.
            if (parameters["middleName"] != string.Empty)
                nameOnCard.middleName = parameters["middleName"];

            // (Optional) A suffix for the account or payment card holder.
            if (parameters["suffix"] != string.Empty)
                nameOnCard.suffix = parameters["suffix"];

            // (Optional) Billing address of the payment card holder. See
            // AddressType Fields for details.
            AddressType billingAddress = new AddressType(parameters["line1"], parameters["countryCode"]);

            // (Optional) The second line of the address. Note: This field
            // is required for Brazilian addresses.
            if (parameters["line2"] != string.Empty)
                billingAddress.line2 = parameters["line2"];

            // (Required) The city.
            if (parameters["city"] != string.Empty)
                billingAddress.city = parameters["city"];

            // (Optional) The state code.
            if (parameters["state"] != string.Empty)
                billingAddress.state = parameters["state"];

            // (Optional) The zip or postal code.
            if (parameters["postalCode"] != string.Empty)
                billingAddress.postalCode = parameters["postalCode"];

            // (Required) The type of payment card to add. 
            CardTypeType cardType = 
                (CardTypeType) Enum.Parse(typeof(CardTypeType), parameters["cardType"]);
            ConfirmationType confirmationType = 
                (ConfirmationType) Enum.Parse(typeof(ConfirmationType), parameters["confirmationType"]);

            // (Required) The payment card number.
            AddPaymentCardRequest req = new AddPaymentCardRequest(new RequestEnvelope(), nameOnCard, billingAddress,
                    parameters["cardNumber"], cardType, confirmationType);

            // Optional) Unique identification number of the PayPal account
            // to which to add the payment card. You must pass either an
            // accountId or an emailAddress in this request. You can't leave
            // both fields out of the message.
            if (parameters["accountId"] != string.Empty)
                req.accountId = parameters["accountId"];

            // (Optional) Email address that uniquely identifies the PayPal
            // account to which to add the payment card.
            if (parameters["emailAddress"] != string.Empty)
                req.emailAddress = parameters["emailAddress"];

            // (Required if confirmationType is NONE) Unique identifier of
            //  the account to which to add a payment card. Use in cases
            //  where the payment card is being added without the account
            //  holder's explicit confirmation. The value to pass is returned
            //  in the createAccountKey field of a CreateAccount response. A
            //  create account key response expires after 60 minutes. If you
            //  pass an expired key to an Adaptive Accounts API, an error is
            //  returned
            if (parameters["createAccountKey"] != string.Empty)
                req.createAccountKey = parameters["createAccountKey"];

            // (Optional) Date of birth of the payment card holder.
            if (parameters["cardOwnerDateOfBirth"] != string.Empty)
                req.cardOwnerDateOfBirth = parameters["cardOwnerDateOfBirth"];

            // (Optional) Expiration date of the payment card. 
            if (parameters["expirationMonth"] != string.Empty && parameters["expirationYear"] != string.Empty)
            {
                req.expirationDate = new CardDateType(
                    int.Parse(parameters["expirationMonth"]),
                    int.Parse(parameters["expirationYear"]));
            }

            // The verification code of the payment card. This parameter is
            // generally required for calls in which confirmationType is
            // NONE. With the appropriate account review, this parameter can
            // be optional.
            if (parameters["cardVerificationNumber"] != string.Empty)
                req.cardVerificationNumber = parameters["cardVerificationNumber"];

            // (Optional) Start date of the payment card. 
            if (parameters["startMonth"] != string.Empty && parameters["startYear"] != string.Empty)
            {
                req.startDate = new CardDateType(
                    int.Parse(parameters["startMonth"]),
                    int.Parse(parameters["startYear"]));
            }

            // (Optional) 2-digit issue number of the payment card (for
            // Maestro cards only).
            if (parameters["issueNumber"] != string.Empty)
                req.issueNumber = parameters["issueNumber"];

            // (Optional) Structure in which to pass the URLs for the return
            // and cancelation web flows
            if (confirmationType == ConfirmationType.WEB &&
                (parameters["returnURL"] != string.Empty || parameters["returnURLDescription"] != string.Empty
                || parameters["cancelURL"] != string.Empty || parameters["cancelURLDescription"] != string.Empty))
            {
                req.webOptions = new WebOptionsType();

                // (Optional) The URL to which PayPal returns the account holder
                // once he or she completes confirmation of the payment card
                // addition
                if (parameters["returnURL"] != string.Empty)
                    req.webOptions.returnUrl = parameters["returnURL"];
                if (parameters["returnURLDescription"] != string.Empty)
                    req.webOptions.returnUrlDescription = parameters["returnURLDescription"];

                // (Optional) The URL to which PayPal returns the account holder
                // if he or she cancels confirmation of the payment card
                // addition.
                if (parameters["cancelURL"] != string.Empty)
                    req.webOptions.cancelUrl = parameters["cancelURL"];
                if (parameters["cancelURLDescription"] != string.Empty)
                    req.webOptions.cancelUrlDescription = parameters["cancelURLDescription"];
            }

            // Create the AdaptiveAccounts service object to make the API call          
            AdaptiveAccountsService service = null;
            AddPaymentCardResponse resp = null;
            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer at 
                // (https://github.com/paypal/adaptiveaccounts-sdk-java/wiki/SDK-Configuration-Parameters)
                Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

                // Creating service wrapper object to make an API call and loading
                // configuration map for your credentials and endpoint
                service = new AdaptiveAccountsService(configurationMap);

                // # API call 
                // Invoke the CreateAccount method in service wrapper object   
                resp = service.AddPaymentCard(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                redirectUrl = resp.redirectURL;
                keyResponseParams.Add("Execution status", resp.execStatus.ToString());
                keyResponseParams.Add("Funding source key", resp.fundingSourceKey);

                //Selenium Test Case
                keyResponseParams.Add("Acknowledgement", resp.responseEnvelope.ack.ToString());
                keyResponseParams.Add("Redirect To PayPal", resp.redirectURL);  
            }
            displayResponse(context, "AddPaymentCard", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle GetVerifiedStatus API call
        /// </summary>
        /// <param name="context"></param>
        private void GetVerifiedStatus(HttpContext context)
        {
            // # GetVerifiedStatus API
            // The GetVerifiedStatus API operation lets you determine whether the specified PayPal account's status is verified or unverified.
            NameValueCollection parameters = context.Request.Params;
            GetVerifiedStatusRequest req = new GetVerifiedStatusRequest(new RequestEnvelope(), parameters["matchCriteria"]);
            //(Required) The first name of the PayPal account holder.
            // Required if matchCriteria is NAME.
            if (parameters["firstName"] != string.Empty)
            {
                req.firstName = parameters["firstName"];
            }

            // (Required) The last name of the PayPal account holder.
            // Required if matchCriteria is NAME.
            if (parameters["lastName"] != string.Empty)
            {
                req.lastName = parameters["lastName"];
            }

            if (parameters["emailAddress"] != string.Empty)
            {
                // (Optional - must be present if the emailAddress field above
                // is not) The identifier of the PayPal account holder. If
                // present, must be one (and only one) of these account
                // identifier types: 1. emailAddress 2. mobilePhoneNumber 3.
                // accountId
                AccountIdentifierType accntIdentifierType = new AccountIdentifierType();

                // (Required)Email address associated with the PayPal account:
                // one of the unique identifiers of the account.
                accntIdentifierType.emailAddress = parameters["emailAddress"];
                req.accountIdentifier = accntIdentifierType;
            }

            // Create the AdaptiveAccounts service object to make the API call            
            AdaptiveAccountsService service = null;
            GetVerifiedStatusResponse resp = null;
            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer at 
                // (https://github.com/paypal/adaptiveaccounts-sdk-java/wiki/SDK-Configuration-Parameters)
                Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

                // Creating service wrapper object to make an API call and loading
                // configuration map for your credentials and endpoint
                service = new AdaptiveAccountsService(configurationMap);

                // # API call 
                // Invoke the CreateAccount method in service wrapper object 
                resp = service.GetVerifiedStatus(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                keyResponseParams.Add("Account status", resp.accountStatus);
                if (resp.userInfo != null)
                {
                    keyResponseParams.Add("Account Id", resp.userInfo.accountId);
                    keyResponseParams.Add("Account type", resp.userInfo.accountType);

                    //Selenium Test Case
                    keyResponseParams.Add("Acknowledgement", resp.responseEnvelope.ack.ToString()); 
                }
            }
            displayResponse(context, "GetVerifiedStatus", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Handle GetUserAgreement API call
        /// </summary>
        /// <param name="context"></param>
        private void GetUserAgreement(HttpContext context)
        {
            // #GetUserAgreement API
            // The GetUserAgreement API operation lets you retrieve the user agreement for the customer to approve the new PayPal account.
            NameValueCollection parameters = context.Request.Params;
            GetUserAgreementRequest req = new GetUserAgreementRequest(new RequestEnvelope());

            // (Optional) The key returned for this account in the
            // CreateAccountResponse message in the createAccountKey field.
            // If you specify this key, do not pass a country code or
            // language code. Doing so will result in an error.
            if (parameters["createAccountKey"] != string.Empty)
            {
                req.createAccountKey = parameters["createAccountKey"];
            }

            // (Optional) The code for the country in which the user account
            // is located. You do not need to provide this country code if
            // you are passing the createAccount key. 
            if (parameters["countryCode"] != string.Empty)
            {
                req.countryCode = parameters["countryCode"];
            }

            // (Optional) The code indicating the language to be used for
            // the agreement.
            if (parameters["languageCode"] != string.Empty)
            {
                req.languageCode = parameters["languageCode"];
            }

            // Create the AdaptiveAccounts service object to make the API call         
            AdaptiveAccountsService service = null;
            GetUserAgreementResponse resp = null;
            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer at 
                // (https://github.com/paypal/adaptiveaccounts-sdk-java/wiki/SDK-Configuration-Parameters)
                Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

                // Creating service wrapper object to make an API call and loading
                // configuration map for your credentials and endpoint
                service = new AdaptiveAccountsService(configurationMap);

                // # API call 
                // Invoke the CreateAccount method in service wrapper object 
                resp = service.GetUserAgreement(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                keyResponseParams.Add("Agreement", resp.agreement.Substring(0, 100) + "....");

                //Selenium Test Case
                keyResponseParams.Add("Acknowledgement", resp.responseEnvelope.ack.ToString()); 
            }
            displayResponse(context, "GetUserAgreement", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }


        /// <summary>
        /// Handle SetFundingSourceConfirmed API call
        /// </summary>
        /// <param name="context"></param>
        private void SetFundingSourceConfirmed(HttpContext context)
        {
            // # SetFundingSourceConfirmed API
            // The SetFundingSourceConfirmed API operation lets your application set up bank accounts as funding sources for PayPal accounts.
            NameValueCollection parameters = context.Request.Params;

            // (Required) The funding source key returned in the AddBankAccount or AddPaymentCard response.
            SetFundingSourceConfirmedRequest req =
                new SetFundingSourceConfirmedRequest(new RequestEnvelope(), parameters["fundingSourceKey"]);
            //(Optional) The merchant account Id of the PayPal account to
            // which the funding source was added in the AddPaymentCard or
            // AddBankAccount request. You must specify either the accountId
            // or mailAddress when making this request, but never both in
            // the same request.
            if (parameters["accountId"] != string.Empty)
                req.accountId = parameters["accountId"];

            // (Optional) The email address of the PayPal account to which
            // the funding source was added in the AddPaymentCard or
            // AddBankAccount request. You must specify either the accountId
            // or mailAddress when making this request, but never both in
            // the same request.
            if (parameters["emailAddress"] != string.Empty)
                req.emailAddress = parameters["emailAddress"];

            // Create the AdaptiveAccounts service object to make the API call           
            AdaptiveAccountsService service = null;
            SetFundingSourceConfirmedResponse resp = null;
            try
            {
                // Configuration map containing signature credentials and other required configuration.
                // For a full list of configuration parameters refer at 
                // (https://github.com/paypal/adaptiveaccounts-sdk-java/wiki/SDK-Configuration-Parameters)
                Dictionary<string, string> configurationMap = Configuration.GetSignatureConfig();

                // Creating service wrapper object to make an API call and loading
                // configuration map for your credentials and endpoint
                service = new AdaptiveAccountsService(configurationMap);

                // # API call 
                // Invoke the CreateAccount method in service wrapper object    	
                resp = service.SetFundingSourceConfirmed(req);
            }
            catch (System.Exception e)
            {
                context.Response.Write(e.Message);
                return;
            }

            // Display response values. 
            Dictionary<string, string> keyResponseParams = new Dictionary<string, string>();
            string redirectUrl = null;
            if (!(resp.responseEnvelope.ack == AckCode.FAILURE) &&
                !(resp.responseEnvelope.ack == AckCode.FAILUREWITHWARNING))
            {
                // nothing to add
            }
            displayResponse(context, "SetFundingSourceConfirmed", keyResponseParams, service.getLastRequest(), service.getLastResponse(),
                resp.error, redirectUrl);
        }

        /// <summary>
        /// Utility method for displaying API response
        /// </summary>
        /// <param name="context"></param>
        /// <param name="apiName"></param>
        /// <param name="responseValues"></param>
        /// <param name="requestPayload"></param>
        /// <param name="responsePayload"></param>
        /// <param name="errorMessages"></param>
        /// <param name="redirectUrl"></param>
        private void displayResponse(HttpContext context, string apiName, Dictionary<string, string> responseValues, 
            string requestPayload, string responsePayload, List<ErrorData> errorMessages, string redirectUrl)
        {

            context.Response.Write("<html><head><title>");
            context.Response.Write("PayPal Adaptive Accounts - " + apiName);
            context.Response.Write("</title><link rel='stylesheet' href='Content/sdk.css' type='text/css'/></head><body>");
            context.Response.Write("<h3>" + apiName + " response</h3>");
            if (errorMessages != null && errorMessages.Count > 0)
            {
                context.Response.Write("<div class='section_header'>Error messages</div>");
                context.Response.Write("<div class='note'>Investigate the response object for further error information</div><ul>");
                foreach (ErrorData error in errorMessages)
                {   
                    context.Response.Write("<li>" + error.message + "</li>");       
                }
                context.Response.Write("</ul>");
            }
            if (redirectUrl != null)
            {
                string red = "<div>This API involves a web flow. You must now redirect your user to " + redirectUrl;
                red = red + "<br />Please click <a href='" + redirectUrl + "' target='_blank'>here</a> to try the flow.</div><br/>";
                context.Response.Write(red);
            }
            context.Response.Write("<div class='section_header'>Key values from response</div>");
            context.Response.Write("<div class='note'>Consult response object and reference doc for complete list of response values.</div><table>");

            //Selenium Test Case            
            foreach (KeyValuePair<string, string> entry in responseValues)
            {

                context.Response.Write("<tr><td class='label'>");
                context.Response.Write(entry.Key);
                context.Response.Write(": </td><td>");

                if (entry.Key == "Redirect To PayPal")
                {
                    context.Response.Write("<a id='");
                    context.Response.Write(entry.Key);
                    context.Response.Write("' href=");
                    context.Response.Write(entry.Value);
                    context.Response.Write(">Redirect To PayPal</a>");
                }
                else
                {
                    context.Response.Write("<div id='");
                    context.Response.Write(entry.Key);
                    context.Response.Write("'>");
                    context.Response.Write(entry.Value);
                }

                context.Response.Write("</td></tr>");
            }

            context.Response.Write("</table><h4>Request:</h4><br/><textarea rows=15 cols=80 readonly>");
            context.Response.Write(requestPayload);
            context.Response.Write("</textarea><br/><h4>Response</h4><br/><textarea rows=15 cols=80 readonly>");
            context.Response.Write(responsePayload);
            context.Response.Write("</textarea>");            
            context.Response.Write("<br/><br/><a href='Default.aspx'>Home<a><br/><br/></body></html>");
        }
    }
}
