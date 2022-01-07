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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
            baglanti.Open();

            
            if(signup_nameTxtBox.Text == "" || signup_usernameTxtBox.Text == "" || signup_passTxtBox.Text == "" || signup_emailTxtBox.Text == "")
            {
                signup_uyari_label.ForeColor = System.Drawing.Color.Red;
                signup_uyari_label.Text = "Lütfen bütün alanları doldurunuz.";
                signup_uyari_label.Visible = true;
            }
            else
            {
                string komut = "INSERT INTO uye(adi,username,pass,email) VALUES (@signup_nameTxtBox,@signup_usernameTxtBox,@signup_passTxtBox,@signup_emailTxtBox)";
                SqlCommand cmd = new SqlCommand(komut, baglanti);

                cmd.Parameters.AddWithValue("@signup_nameTxtBox", signup_nameTxtBox.Text);
                cmd.Parameters.AddWithValue("@signup_usernameTxtBox", signup_usernameTxtBox.Text);
                cmd.Parameters.AddWithValue("@signup_passTxtBox", signup_passTxtBox.Text);
                cmd.Parameters.AddWithValue("@signup_emailTxtBox", signup_emailTxtBox.Text);
                cmd.ExecuteNonQuery();

                signup_uyari_label.ForeColor = System.Drawing.Color.Green;
                signup_uyari_label.Text = "Başarılı bir şekilde kayıt olundu.";
                signup_uyari_label.Visible = true;
            }

        }
    }
}