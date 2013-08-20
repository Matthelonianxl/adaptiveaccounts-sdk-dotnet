using System;

namespace AdaptiveAccountsSampleApp
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string currentPath = System.Web.HttpContext.Current.Request.Url.OriginalString;
            this.returnUrl.Value = currentPath;
            Random autoRand = new Random();
            this.emailAddress.Value = "sdkaccount_" + autoRand.Next(0, int.MaxValue) + "@paypal.com";
        }
    }
}
