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
    public partial class filmdetay : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            var filmID = Request.QueryString["id"];

            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
            baglanti.Open();
            DataSet dsFilmDetayImg = new DataSet();
            SqlDataAdapter daFilmDetayImg = new SqlDataAdapter("SELECT * FROM film WHERE film.id = '" + filmID + "'", baglanti);
            daFilmDetayImg.Fill(dsFilmDetayImg);
            var filmDetayImg = new HtmlGenericControl("img");
            filmDetayImg.Attributes["class"] = "card-img-top";
            filmDetayImg.Attributes["src"] = "/" + dsFilmDetayImg.Tables[0].Rows[0]["img_path"].ToString();
            filmDetayPanelCard.Controls.Add(filmDetayImg);
            for (int i = 0; i < dsFilmDetayImg.Tables[0].Rows.Count; i++)
            {

                var filmTitle = new HtmlGenericControl("h5") { InnerText = dsFilmDetayImg.Tables[0].Rows[i]["adi"].ToString() };
                filmTitle.Attributes["class"] = "card-title";
                filmDetayCardBody.Controls.Add(filmTitle);
            }


            DataSet dsFilmDetay = new DataSet();
            SqlDataAdapter daFilmDetay = new SqlDataAdapter("SELECT yonetmen.yonetmen_ad,film.ortalama_puan,film.konu FROM film INNER JOIN yonetmek ON film.id = yonetmek.film_id INNER JOIN yonetmen ON yonetmek.yonetmen_id = yonetmen.id WHERE film.id = '" + filmID + "'", baglanti); // create a DataSet object to hold you table(s)... this can contain more than 1 table
            daFilmDetay.Fill(dsFilmDetay);
            for (int i = 0; i < dsFilmDetay.Tables[0].Rows.Count; i++)
            {
                var konuP = new HtmlGenericControl("p") { InnerText = "Konu:" + dsFilmDetay.Tables[0].Rows[i]["konu"].ToString() };
                konuP.Attributes["class"] = "card-text";
                filmDetayCardBody.Controls.Add(konuP);
                var yonetmenP = new HtmlGenericControl("p") { InnerText = "Yönetmen: " + dsFilmDetay.Tables[0].Rows[i]["yonetmen_ad"].ToString() };
                yonetmenP.Attributes["class"] = "card-text";
                filmDetayCardBody.Controls.Add(yonetmenP);
                var rateIcon = new HtmlGenericControl("p") { InnerText = "Ortalama Puan: " + dsFilmDetay.Tables[0].Rows[i]["ortalama_puan"].ToString() };
                if (Convert.ToInt32(dsFilmDetay.Tables[0].Rows[i]["ortalama_puan"]) <= 5)
                {
                    rateIcon.Attributes["style"] = "color:red;";
                }
                if (5 < Convert.ToInt32(dsFilmDetay.Tables[0].Rows[i]["ortalama_puan"]) && 8 > Convert.ToInt32(dsFilmDetay.Tables[0].Rows[i]["ortalama_puan"]))
                {
                    rateIcon.Attributes["style"] = "color:yellow;";
                }
                if (8 < Convert.ToInt32(dsFilmDetay.Tables[0].Rows[i]["ortalama_puan"]))
                {
                    rateIcon.Attributes["style"] = "color:green;";
                }


                rateIcon.Attributes["class"] = "card-text";
                filmDetayCardBody.Controls.Add(rateIcon);
            }

            DataSet dsFilmDesc = new DataSet();
            SqlDataAdapter daFilmDesc = new SqlDataAdapter("SELECT kategori.kategori_adi,oyuncu.oyuncu_ad FROM film INNER JOIN kategori ON film.kategori_id=kategori.id INNER JOIN oynamak ON film.id=oynamak.film_id INNER JOIN oyuncu ON oynamak.oyuncu_id = oyuncu.id WHERE film.id = '" + filmID + "'", baglanti); // create a DataSet object to hold you table(s)... this can contain more than 1 table
            daFilmDesc.Fill(dsFilmDesc);
            var oyuncuP = new HtmlGenericControl("p") { InnerText = "Oyuncular: " };
            oyuncuP.Attributes["class"] = "card-text";
            filmDetayCardBody.Controls.Add(oyuncuP);
            var kategoriP = new HtmlGenericControl("p");
            kategoriP.Attributes["class"] = "card-text";
            var kategoriSmall = new HtmlGenericControl("small");
            kategoriSmall.Attributes["class"] = "text-muted";
            kategoriP.Controls.Add(kategoriSmall);
            filmDetayCardBody.Controls.Add(kategoriP);
            var last = dsFilmDesc.Tables[0].Rows.Count - 1;
            for (int i = 0; i < dsFilmDesc.Tables[0].Rows.Count; i++)
            {
                kategoriSmall.InnerText = dsFilmDesc.Tables[0].Rows[i]["kategori_adi"].ToString();

                if (i == last)
                {
                    oyuncuP.InnerText += dsFilmDesc.Tables[0].Rows[i]["oyuncu_ad"];
                }
                else
                {
                    oyuncuP.InnerText += dsFilmDesc.Tables[0].Rows[i]["oyuncu_ad"] + "," + " ";
                }

            }

            DataSet dsYorumlar = new DataSet();
            SqlDataAdapter daYorumlar = new SqlDataAdapter("SELECT uye.username,yorum_yapmak.yorum,yorum_yapmak.puan FROM film INNER JOIN yorum_yapmak ON film.id=yorum_yapmak.film_id INNER JOIN uye ON yorum_yapmak.uye_id=uye.id WHERE film_id='" + filmID + "'", baglanti);
            daYorumlar.Fill(dsYorumlar);
            for (int i = 0; i < dsYorumlar.Tables[0].Rows.Count; i++)
            {
                var yorumlarUL = new HtmlGenericControl("ul");
                yorumlarUL.Attributes["class"] = "yorum-ul";
                var yorumLI = new HtmlGenericControl("li") { InnerText = "Kullanıcı Adı:" + dsYorumlar.Tables[0].Rows[i]["username"].ToString() };
                yorumLI.Attributes["class"] = "yorum-li";
                var yorumP = new HtmlGenericControl("p") { InnerText = "Yorumu:" + " " + dsYorumlar.Tables[0].Rows[i]["yorum"].ToString() };
                yorumLI.Controls.Add(yorumP);
                var puanP = new HtmlGenericControl("p") { InnerText = "Verdiği Puan: " + dsYorumlar.Tables[0].Rows[i]["puan"].ToString() };
                yorumLI.Controls.Add(puanP);
                yorumlarUL.Controls.Add(yorumLI);
                yorumKismi.Controls.Add(yorumlarUL);
            }
        }

        protected void yorumYap_Click(object sender, EventArgs e)
        {
            if (Session["noid"] != null)
            {
                if (yorumTxtBox.Text == "")
                {
                    yorumUyari.ForeColor = System.Drawing.Color.Red;
                    yorumUyari.Text = "Lütfen bütün alanları doldurunuz.";
                    yorumUyari.Visible = true;
                }
                else
                {
                    var filmID = Request.QueryString["id"];
                    SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
                    baglanti.Open();
                    var userID = Convert.ToInt32(Session["noid"]);

                    string komut = "INSERT INTO yorum_yapmak(uye_id,film_id,puan,yorum_tarihi,yorum) VALUES (@uye_id,@film_id,@puan,@tarih,@yorum)";
                    SqlCommand cmd = new SqlCommand(komut, baglanti);
                    cmd.Parameters.AddWithValue("@uye_id", userID);
                    cmd.Parameters.AddWithValue("@film_id", Convert.ToInt32(filmID));
                    cmd.Parameters.AddWithValue("@yorum", yorumTxtBox.Text);
                    cmd.Parameters.AddWithValue("@tarih", DateTime.Now.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@puan", Convert.ToInt32(puanlamaDL.SelectedValue.ToString()));
                    cmd.ExecuteNonQuery();
                    Response.Redirect(Request.RawUrl);
                }
            }

            else
            {
                yorumUyari.ForeColor = System.Drawing.Color.Red;
                yorumUyari.Text = "Yorum yapmak için giriş yapmalısınız.";
                yorumUyari.Visible = true;
            }
        }
    }
}