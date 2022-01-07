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
    public partial class addmovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"].ToString() == "admin1")
            {

            } else
            {
                Response.Redirect("/default.aspx");
            }
        }

        protected void filmekleBtn_Click(object sender, EventArgs e)
        {
            if (filmAdiTxtBox.Text == "" || konuTxtBox.Text == "" || dateTxtBox.Text == "" || !filmImgUpld.HasFile)
            {
                filmbilgiLbl.Visible = true;
                filmbilgiLbl.ForeColor = System.Drawing.Color.Red;
                filmbilgiLbl.Text = "Lütfen bütün alanları doldurunuz.";
            }
            else
            {
                try
                {
                    
                    string imgfile = Path.GetFileName(filmImgUpld.PostedFile.FileName);
                    filmImgUpld.SaveAs(Server.MapPath("~/Images/") + imgfile);
                    SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
                    baglanti.Open();
                    string komut = "INSERT INTO [film] (adi, yonetmen_id, ortalama_puan, cikis_tarihi, kategori_id, konu, img_path) VALUES(@filmAdiTxtBox,@yonetmen,'',@dateTxtBox,@kategori,@konuTxtBox,@img);" + "SELECT CAST(SCOPE_IDENTITY() AS int);";
                    SqlCommand ekle = new SqlCommand(komut, baglanti);
                    ekle.Parameters.AddWithValue("@filmAdiTxtBox", filmAdiTxtBox.Text);
                    ekle.Parameters.AddWithValue("@dateTxtBox", Convert.ToDateTime(dateTxtBox.Text));
                    ekle.Parameters.AddWithValue("@konuTxtBox", konuTxtBox.Text);
                    ekle.Parameters.AddWithValue("@yonetmen", Convert.ToInt32(yonetmenList.SelectedValue.ToString()));
                    ekle.Parameters.AddWithValue("@kategori", Convert.ToInt32(kategoriList.SelectedValue.ToString()));
                    ekle.Parameters.AddWithValue("@img", "Images/" + imgfile);
                    int newID = Convert.ToInt32(ekle.ExecuteScalar());

                    string komut2 = "INSERT INTO [yonetmek] (yonetmen_id,film_id) VALUES (@yonetmen,@film);";
                    SqlCommand ekle2 = new SqlCommand(komut2, baglanti);
                    ekle2.Parameters.AddWithValue("@yonetmen", Convert.ToInt32(yonetmenList.SelectedValue.ToString()));
                    ekle2.Parameters.AddWithValue("@film", newID);
                    ekle2.ExecuteNonQuery();
                    baglanti.Close();
                    filmbilgiLbl.Visible = true;
                    filmbilgiLbl.ForeColor = System.Drawing.Color.White;
                    filmbilgiLbl.Text = "Film başarıyla eklendi.";

                }
                catch (Exception Hata)
                {
                    filmbilgiLbl.Visible = true;
                    filmbilgiLbl.ForeColor = System.Drawing.Color.White;
                    filmbilgiLbl.Text = Hata.ToString();
                }
            }
        }
    }
}