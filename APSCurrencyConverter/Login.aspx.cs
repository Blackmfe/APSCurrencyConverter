using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace APSCurrencyConverter
{
	public partial class Login : System.Web.UI.Page
	{
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Currency"].ToString());
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			//Validating credentials
			using (SqlCommand cmd = new SqlCommand("spValidateUser", con))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				con.Open();
				cmd.CommandTimeout = 300;
				cmd.Parameters.AddWithValue("@UserName", txtusername.Text);
				cmd.Parameters.AddWithValue("@password", txtpassword.Text);
				SqlDataReader dr = cmd.ExecuteReader();
				dr.Close();
				dr = cmd.ExecuteReader();

				//Logging in
				if (dr.HasRows)
				{
					Session["UserName"] = txtusername.Text;
					Response.Redirect("index.aspx");
				}
				else
				{
					lblerror.Visible = true;
					lblerror.Text = "Incorrect credentials";
				}
			}
		}
	}
}
