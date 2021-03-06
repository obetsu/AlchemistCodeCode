using System;
using SRPG;

namespace AlchemistCodeCode.Network.Requests
{
	public class ReqRegisterDeviceToFacebook : WebAPI
	{
		public ReqRegisterDeviceToFacebook(string secretkey, string udid, string accesstoken)
		{
			this.name = "gauth/facebook/sso/relate_account";
			this.body = "{";
			string body = this.body;
			this.body = string.Concat(new object[]
			{
				body,
				"\"ticket\":",
				Networking.TicketID,
				","
			});
			this.body += "\"access_token\":\"\",";
			this.body += "\"param\":{";
			this.body = this.body + "\"secret_key\":\"" + secretkey + "\",";
			this.body = this.body + "\"device_id\":\"" + udid + "\",";
			this.body = this.body + "\"access_token\":\"" + accesstoken + "\"";
			this.body += "}";
			this.body += "}";
		}
	}
}
