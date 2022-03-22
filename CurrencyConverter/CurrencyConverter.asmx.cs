using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace CurrencyConverter
{
	/// <summary>
	/// Summary description for CurrencyConverter
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
	// [System.Web.Script.Services.ScriptService]
	public class CurrencyConverter : System.Web.Services.WebService
	{
		

		[WebMethod]
		public static decimal Convert(decimal amount, string fromCurrency, string toCurrency)
		{
			//Converting captured amount
			try
			{

				WebClient web = new WebClient();
				string url = string.Format("http://www.google.com/ig/calculator?hl=en&q={2}{0}%3D%3F{1}", fromCurrency.ToUpper(), toCurrency.ToUpper(), amount);
				string response = web.DownloadString(url);
				Regex regex = new Regex("rhs: \\\"(\\d*.\\d*)");
				decimal rate = System.Convert.ToDecimal(regex.Match(response).Groups[1].Value);
				return rate;

			}
			catch(Exception ex)
			{
				string messa = ex.Message;

				return 0;
			}
		}

		
	}
}
