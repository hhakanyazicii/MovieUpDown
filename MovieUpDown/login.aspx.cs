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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            login_warn_label.Visible = false;
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginUserNameTxtBox.Text == "" || loginPassTxtBox.Text == "")
            {
                login_warn_label.ForeColor = System.Drawing.Color.Red;
                login_warn_label.Text = "Lütfen bütün alanları doldurunuz.";
                login_warn_label.Visible = true;
            }
            else
            {
                SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
                baglanti.Open();
                SqlCommand sorgu = new SqlCommand("SELECT * FROM uye WHERE username=@loginUserNameTxtBox AND pass=@loginPassTxtBox",baglanti);
                sorgu.Parameters.AddWithValue("@loginUserNameTxtBox", loginUserNameTxtBox.Text);
                sorgu.Parameters.AddWithValue("@loginPassTxtBox", loginPassTxtBox.Text);

                SqlDataReader dr = sorgu.ExecuteReader();

                if (dr.Read())
                {
                    
                    Session["noid"] = dr["id"];
                    Response.Redirect("default.aspx");
                }
                else
                {
                    login_warn_label.ForeColor = System.Drawing.Color.Red;
                    login_warn_label.Text = "Girdiğiniz bilgiler hatalıdır";
                    login_warn_label.Visible = true;
                }
            }

        }
    }
}