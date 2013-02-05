IPN Overview:
------------
* PayPal Instant Payment Notification is a call back system that is initiated when a transaction is completed 
  (Example: On successful payment transaction)
* The transaction related IPN variables will be received on the call back URL specified in the request
* The IPN variables have to be sent back to the PayPal system for validation, 
  upon validation PayPal will send a response string "VERIFIED" or "INVALID"
* PayPal would continuously resend IPN if a wrong IPN is sent


IPN Configuration:
-----------------
* IPN endpoint URL is specified in 'Web.config' as 'IPNEndpoint'. This will be used for the IPN post back
* A utility class 'IPNMessage.cs' is provided in sdk-core-dotnet for IPN message validation


IPN Deployment:
--------------
* IPN Listener - adaptivepayments-sdk-dotnet\Samples\AdaptiveAccountsSampleApp\IPNListener.aspx
* Deploy IPN Listener sample in IIS and expose your server port using any third party 
  LocalTunneling software, so that the PayPal IPN call back can be received
* Make a PayPal API call (Example: Pay request), setting the IPNNotificationUrl field of the API request class
  to the URL of deployed IPNListener sample (Example: http://DNS-Name/IPNListener.aspx)
* The IPN call back from PayPal would be logged in the log file of the IPN sample


IPN variables:
--------------

[Transaction]
-------------
* notify_version
* verify_sign
* charset
* confirmation_code
* event_type
* account_key

[BuyerInfo]
-----------
* first_name
* last_name 

* For a full list of IPN variables you need to check the log file that the IPN Listener logs.    

IPN Reference :
--------------
* Please refer to 'Instant Payment Notification: Getting Started' at [https://www.x.com/developers/paypal/documentation-tools/IPN/gs_IPN]