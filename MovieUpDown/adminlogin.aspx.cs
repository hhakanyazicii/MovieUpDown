using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace MovieUpDown
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminLgnBtn_Click(object sender, EventArgs e)
        {
            if (adminIDTxtBox.Text == "" || adminPassTxtBox.Text == "")
            {
                adminWarn.ForeColor = System.Drawing.Color.Red;
                adminWarn.Text = "Lütfen bütün alanları doldurunuz.";
                adminWarn.Visible = true;
            }
            else
            {
                SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("SELECT * FROM admin WHERE username=@adminIDTxtBox AND pass=@adminPassTxtBox", baglanti);
                sorgu.Parameters.AddWithValue("@adminIDTxtBox", adminIDTxtBox.Text);
                sorgu.Parameters.AddWithValue("@adminPassTxtBox", adminPassTxtBox.Text);

                SqlDataReader dr = sorgu.ExecuteReader();

                if (dr.Read())
                {
                    Session.Add("username", adminIDTxtBox.Text);
                    Response.Redirect("default.aspx");
                }
                else
                {
                    adminWarn.ForeColor = System.Drawing.Color.Red;
                    adminWarn.Text = "Girdiğiniz bilgiler hatalıdır";
                    adminWarn.Visible = true;
                }
            }
        }
    }
}