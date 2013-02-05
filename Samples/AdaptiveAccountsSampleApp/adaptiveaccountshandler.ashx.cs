using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Web.Services;
using System.Web.Services.Protocols;
using PayPal;
using PayPal.AdaptiveAccounts;
using PayPal.AdaptiveAccounts.Model;
using PayPal.Util;
using PayPal.Exception;
using System.Configuration;

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
            String strCall = context.Request.Params["AdaptiveAccountsBtn"];

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
            NameValueCollection parameters = context.Request.Params;

            NameType nameOnCard = new NameType(parameters["firstName"], parameters["lastName"]);
            if (parameters["salutation"] != string.Empty)
                nameOnCard.salutation = parameters["salutation"];
            if (parameters["middleName"] != string.Empty)
                nameOnCard.middleName = parameters["middleName"];
            if (parameters["suffix"] != string.Empty)
                nameOnCard.suffix = parameters["suffix"];

            AddressType address = new AddressType(parameters["line1"], parameters["countryCode"]);
            if (parameters["line2"] != string.Empty)
                address.line2 = parameters["line2"];
            if (parameters["city"] != string.Empty)
                address.city = parameters["city"];
            if (parameters["state"] != string.Empty)
                address.state = parameters["state"];
            if (parameters["postalCode"] != string.Empty)
                address.postalCode = parameters["postalCode"];

            CreateAccountRequest req = new CreateAccountRequest(new RequestEnvelope(), nameOnCard, address,
                parameters["preferredLanguageCode"]);
            
            // set optional parameters
            if(parameters["contactPhoneNumber"] != string.Empty)
                req.contactPhoneNumber = parameters["contactPhoneNumber"];
            if (parameters["homePhoneNumber"] != string.Empty)
                req.homePhoneNumber = parameters["homePhoneNumber"];
            if (parameters["mobilePhoneNumber"] != string.Empty)
                req.mobilePhoneNumber = parameters["mobilePhoneNumber"];
            if (parameters["emailAddress"] != string.Empty)
                req.emailAddress = parameters["emailAddress"];
            if (parameters["currencyCode"] != string.Empty)
                req.currencyCode = parameters["currencyCode"];
            req.citizenshipCountryCode = parameters["citizenshipCountryCode"];
            req.registrationType = parameters["registrationType"];

            if (parameters["notificationUrl"] != string.Empty)
            {
                req.notificationURL = parameters["notificationUrl"];
            }

            if (parameters["returnUrl"] != string.Empty || parameters["returnUrlDescription"] != string.Empty
                || parameters["showAddCreditCard"] != string.Empty || parameters["showMobileConfirm"] != string.Empty
                || parameters["useMiniBrowser"] != string.Empty)
            {
                CreateAccountWebOptionsType webOptions = new CreateAccountWebOptionsType();
                req.createAccountWebOptions = webOptions;

                if (parameters["returnUrl"] != string.Empty)
                    webOptions.returnUrl = parameters["returnUrl"];
                if (parameters["returnUrlDescription"] != string.Empty)
                    webOptions.returnUrlDescription = parameters["returnUrlDescription"];
                if (parameters["showAddCreditCard"] != string.Empty)
                    webOptions.showAddCreditCard = Boolean.Parse(parameters["showAddCreditCard"]);
                if (parameters["showMobileConfirm"] != string.Empty)
                    webOptions.showMobileConfirm = Boolean.Parse(parameters["showMobileConfirm"]);
                if (parameters["useMiniBrowser"] != string.Empty)
                    webOptions.useMiniBrowser = Boolean.Parse(parameters["useMiniBrowser"]);
            }            
            

            // All set. Fire the request
            AdaptiveAccountsService service = new AdaptiveAccountsService();
            CreateAccountResponse resp = null;
            try
            {
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
            NameValueCollection parameters = context.Request.Params;

            ConfirmationType confirmationType = (ConfirmationType) 
                Enum.Parse(typeof(ConfirmationType), parameters["confirmationType"]);
            AddBankAccountRequest req = new AddBankAccountRequest(
                new RequestEnvelope(), parameters["bankCountryCode"], confirmationType);
            
            // set optional parameters
            if (parameters["accountId"] != string.Empty)
                req.accountId = parameters["accountId"];
            if (parameters["emailAddress"] != string.Empty)
                req.emailAddress = parameters["emailAddress"];
            if (parameters["createAccountKey"] != string.Empty)
                req.createAccountKey = parameters["createAccountKey"];            
            if (parameters["bankName"] != string.Empty)
                req.bankName = parameters["bankName"];
            if (parameters["routingNumber"] != string.Empty)
                req.routingNumber = parameters["routingNumber"];
            if (parameters["bankAccountType"] != string.Empty)
                req.bankAccountType = 
                    (BankAccountType) Enum.Parse( typeof(BankAccountType), parameters["bankAccountType"]);
            if (parameters["bankAccountNumber"] != string.Empty)
                req.bankAccountNumber = parameters["bankAccountNumber"];
            if (parameters["iban"] != string.Empty)
                req.iban = parameters["iban"];
            if (parameters["clabe"] != string.Empty)
                req.clabe = parameters["clabe"];
            if (parameters["bsbNumber"] != string.Empty)
                req.bsbNumber = parameters["bsbNumber"];
            if (parameters["branchLocation"] != string.Empty)
                req.branchLocation = parameters["branchLocation"];
            if (parameters["sortCode"] != string.Empty)
                req.sortCode = parameters["sortCode"];
            if (parameters["bankTransitNumber"] != string.Empty)
                req.bankTransitNumber = parameters["bankTransitNumber"];
            if (parameters["institutionNumber"] != string.Empty)
                req.institutionNumber = parameters["institutionNumber"];
            if (parameters["branchCode"] != string.Empty)
                req.branchCode = parameters["branchCode"];
            if (parameters["agencyNumber"] != string.Empty)
                req.agencyNumber = parameters["agencyNumber"];
            if (parameters["bankCode"] != string.Empty)
                req.bankCode = parameters["bankCode"];
            if (parameters["ribKey"] != string.Empty)
                req.ribKey = parameters["ribKey"];
            if (parameters["controlDigit"] != string.Empty)
                req.controlDigit = parameters["controlDigit"];
            if (parameters["taxIdType"] != string.Empty)
                req.taxIdType = parameters["taxIdType"];
            if (parameters["taxIdNumber"] != string.Empty)
                req.taxIdNumber = parameters["taxIdNumber"];
            if (parameters["accountHolderDateOfBirth"] != string.Empty)
                req.accountHolderDateOfBirth = parameters["accountHolderDateOfBirth"];
            if ( confirmationType == ConfirmationType.WEB &&
                (parameters["returnURL"] != string.Empty || parameters["returnURLDescription"] != string.Empty
                || parameters["cancelURL"] != string.Empty || parameters["cancelURLDescription"] != string.Empty))
            {
                req.webOptions = new WebOptionsType();
                if (parameters["returnURL"] != string.Empty)
                    req.webOptions.returnUrl = parameters["returnURL"];
                if (parameters["returnURLDescription"] != string.Empty)
                    req.webOptions.returnUrlDescription = parameters["returnURLDescription"];
                if (parameters["cancelURL"] != string.Empty)
                    req.webOptions.cancelUrl = parameters["cancelURL"];
                if (parameters["cancelURLDescription"] != string.Empty)
                    req.webOptions.cancelUrlDescription = parameters["cancelURLDescription"];
            }           

            // All set. Fire the request            
            AdaptiveAccountsService service = new AdaptiveAccountsService();
            AddBankAccountResponse resp = null;
            try
            {
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
            NameValueCollection parameters = context.Request.Params;

            NameType nameOnCard = new NameType(parameters["firstName"], parameters["lastName"]);
            if (parameters["salutation"] != string.Empty)
                nameOnCard.salutation = parameters["salutation"];
            if (parameters["middleName"] != string.Empty)
                nameOnCard.middleName = parameters["middleName"];
            if (parameters["suffix"] != string.Empty)
                nameOnCard.suffix = parameters["suffix"];

            AddressType billingAddress = new AddressType(parameters["line1"], parameters["countryCode"]);
            if (parameters["line2"] != string.Empty)
                billingAddress.line2 = parameters["line2"];
            if (parameters["city"] != string.Empty)
                billingAddress.city = parameters["city"];
            if (parameters["state"] != string.Empty)
                billingAddress.state = parameters["state"];
            if (parameters["postalCode"] != string.Empty)
                billingAddress.postalCode = parameters["postalCode"];
            
            CardTypeType cardType = 
                (CardTypeType) Enum.Parse(typeof(CardTypeType), parameters["cardType"]);
            ConfirmationType confirmationType = 
                (ConfirmationType) Enum.Parse(typeof(ConfirmationType), parameters["confirmationType"]);

            // Create API request object
            AddPaymentCardRequest req = new AddPaymentCardRequest(new RequestEnvelope(), nameOnCard, billingAddress,
                    parameters["cardNumber"], cardType, confirmationType);
           
            // set optional parameters
            if (parameters["accountId"] != string.Empty)
                req.accountId = parameters["accountId"];
            if (parameters["emailAddress"] != string.Empty)
                req.emailAddress = parameters["emailAddress"];
            if (parameters["createAccountKey"] != string.Empty)
                req.createAccountKey = parameters["createAccountKey"];
            if (parameters["cardOwnerDateOfBirth"] != string.Empty)
                req.cardOwnerDateOfBirth = parameters["cardOwnerDateOfBirth"];
            if (parameters["expirationMonth"] != string.Empty && parameters["expirationYear"] != string.Empty)
            {
                req.expirationDate = new CardDateType(
                    int.Parse(parameters["expirationMonth"]),
                    int.Parse(parameters["expirationYear"]));
            }
            if (parameters["cardVerificationNumber"] != string.Empty)
                req.cardVerificationNumber = parameters["cardVerificationNumber"];
            if (parameters["startMonth"] != string.Empty && parameters["startYear"] != string.Empty)
            {
                req.startDate = new CardDateType(
                    int.Parse(parameters["startMonth"]),
                    int.Parse(parameters["startYear"]));
            }            
            if (parameters["issueNumber"] != string.Empty)
                req.issueNumber = parameters["issueNumber"];
            if (confirmationType == ConfirmationType.WEB &&
                (parameters["returnURL"] != string.Empty || parameters["returnURLDescription"] != string.Empty
                || parameters["cancelURL"] != string.Empty || parameters["cancelURLDescription"] != string.Empty))
            {
                req.webOptions = new WebOptionsType();
                if (parameters["returnURL"] != string.Empty)
                    req.webOptions.returnUrl = parameters["returnURL"];
                if (parameters["returnURLDescription"] != string.Empty)
                    req.webOptions.returnUrlDescription = parameters["returnURLDescription"];
                if (parameters["cancelURL"] != string.Empty)
                    req.webOptions.cancelUrl = parameters["cancelURL"];
                if (parameters["cancelURLDescription"] != string.Empty)
                    req.webOptions.cancelUrlDescription = parameters["cancelURLDescription"];
            }

            // All set. Fire the request            
            AdaptiveAccountsService service = new AdaptiveAccountsService();
            AddPaymentCardResponse resp = null;
            try
            {
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
            NameValueCollection parameters = context.Request.Params;
            GetVerifiedStatusRequest req = new GetVerifiedStatusRequest(new RequestEnvelope(), parameters["matchCriteria"]);
            // set optional parameters
            if (parameters["firstName"] != string.Empty)
            {
                req.firstName = parameters["firstName"];
            }

            if (parameters["lastName"] != string.Empty)
            {
                req.lastName = parameters["lastName"];
            }

            if (parameters["emailAddress"] != string.Empty)
            {
                AccountIdentifierType accntIdentifierType = new AccountIdentifierType();
                accntIdentifierType.emailAddress = parameters["emailAddress"];
                req.accountIdentifier = accntIdentifierType;
            }

            // All set. Fire the request            
            AdaptiveAccountsService service = new AdaptiveAccountsService();
            GetVerifiedStatusResponse resp = null;
            try
            {
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
            NameValueCollection parameters = context.Request.Params;
            GetUserAgreementRequest req = new GetUserAgreementRequest(new RequestEnvelope());
            
            // set optional parameters
            if (parameters["createAccountKey"] != string.Empty)
            {
                req.createAccountKey = parameters["createAccountKey"];
            }
            if (parameters["countryCode"] != string.Empty)
            {
                req.countryCode = parameters["countryCode"];
            }
            if (parameters["languageCode"] != string.Empty)
            {
                req.languageCode = parameters["languageCode"];
            }

            // All set. Fire the request            
            AdaptiveAccountsService service = new AdaptiveAccountsService();
            GetUserAgreementResponse resp = null;
            try
            {
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
            NameValueCollection parameters = context.Request.Params;
            SetFundingSourceConfirmedRequest req =
                new SetFundingSourceConfirmedRequest(new RequestEnvelope(), parameters["fundingSourceKey"]);
            // set optional parameters
            if (parameters["accountId"] != string.Empty)
                req.accountId = parameters["accountId"];
            if (parameters["emailAddress"] != string.Empty)
                req.emailAddress = parameters["emailAddress"];
            
            // All set. Fire the request            
            AdaptiveAccountsService service = new AdaptiveAccountsService();
            SetFundingSourceConfirmedResponse resp = null;
            try
            {
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
            foreach (KeyValuePair<String, String> entry in responseValues)
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
