using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.IO;

namespace MovieUpDown
{
    public partial class oyuncuekle : System.Web.UI.Page
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

        protected void oyuncuEkleBtn_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
            baglanti.Open();

            //Oyuncu tablosuna eklemek için çalıştırılan query
            string komut = "INSERT INTO oyuncu (oyuncu_ad) VALUES(@oyuncu);" + "SELECT CAST(SCOPE_IDENTITY() AS int);";
            SqlCommand ekle = new SqlCommand(komut, baglanti);
            ekle.Parameters.AddWithValue("@oyuncu", oyuncularTxtBox.Text);
            int oyuncuID = Convert.ToInt32(ekle.ExecuteScalar());

            //Oynamak tablosuna eklemek için çalıştırılan query
            string komut2 = "INSERT INTO oynamak(film_id,oyuncu_id) VALUES (@film,@oyuncu);";
            SqlCommand ekle2 = new SqlCommand(komut2, baglanti);
            ekle2.Parameters.AddWithValue("@film", Convert.ToInt32(filmlerDropDwnList.SelectedValue.ToString()));
            ekle2.Parameters.AddWithValue("@oyuncu", oyuncuID);
            ekle2.ExecuteNonQuery();
            baglanti.Close();
            oyuncuBilgiLbl.Visible = true;
            oyuncuBilgiLbl.ForeColor = System.Drawing.Color.Green;
            oyuncuBilgiLbl.Text = "Oyuncu başarıyla eklendi.";
        }
    }
}