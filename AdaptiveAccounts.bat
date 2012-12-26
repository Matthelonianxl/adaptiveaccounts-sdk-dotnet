call "C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\devenv.com" PayPalAdaptiveAccountsSDK\PayPalAdaptiveAccountsSDK.sln /build Release

copy /Y PayPalAdaptiveAccountsSDK\bin\Release\PayPalAdaptiveAccountsSDK.dll Samples\AdaptiveAccountsSampleApp\lib\. 
