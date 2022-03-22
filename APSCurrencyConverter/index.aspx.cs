using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CurrencyConverter;

namespace APSCurrencyConverter
{
	public partial class index : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Currency"].ToString());
		protected void Page_Load(object sender, EventArgs e)
		{
			//Checking if user is logged in
			if (Session["UserName"] == null)
			{
				Response.Redirect("Login.aspx");
			}
		}

		protected void btnConvert_Click(object sender, EventArgs e)
		{
			//Getting the conversion
			decimal Amount = CurrencyConverter.CurrencyConverter.Convert(Convert.ToDecimal(txtInput.Text.Trim()), drpFromCurrency.SelectedValue, drpToCurrency.SelectedValue);

			txtOutput.Text = Convert.ToString(Amount);

			//Saving capture data on the database
			using (SqlCommand cmd = new SqlCommand("spCapture", con))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				con.Open();

				cmd.Parameters.Add("@Input", SqlDbType.NVarChar).Value = txtInput.Text;
				cmd.Parameters.Add("@Output", SqlDbType.NVarChar).Value = Amount;
				cmd.Parameters.Add("@FromCurrency", SqlDbType.NVarChar).Value = drpFromCurrency.SelectedValue;
				cmd.Parameters.Add("@ToCurrency", SqlDbType.NVarChar).Value = drpToCurrency.SelectedValue;

				cmd.ExecuteNonQuery();

				con.Close();
			}
		}

	}
}
