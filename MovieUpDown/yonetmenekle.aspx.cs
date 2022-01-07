using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace MovieUpDown
{
    public partial class yonetmenekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"].ToString() == "admin1")
            {

            }
            else
            {
                Response.Redirect("/default.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
            baglanti.Open();

            if(yntmnAdiTxtBox.Text == "")
            {       
                yntmnBilgiLbl.ForeColor = System.Drawing.Color.Red;
                yntmnBilgiLbl.Text = "Lütfen bütün alanları doldurun.";
                yntmnBilgiLbl.Visible = true;
            }
            else
            {
                string komut = ("INSERT INTO yonetmen(yonetmen_ad) VALUES (@yonetmenAdi)");
                SqlCommand ekle = new SqlCommand(komut, baglanti);
                ekle.Parameters.AddWithValue("@yonetmenAdi", yntmnAdiTxtBox.Text);
                ekle.ExecuteNonQuery();
                yntmnBilgiLbl.ForeColor = System.Drawing.Color.Green;
                yntmnBilgiLbl.Text = "Yönetmen başarıyla eklendi.";
                yntmnBilgiLbl.Visible = true;
            }
        }
    }
}