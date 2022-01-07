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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=proje;Integrated Security=True");
            baglanti.Open();

            //Afiş kısmı navbar altı
            DataSet dsFilmAfis = new DataSet();
            SqlDataAdapter daFilmAfis = new SqlDataAdapter("SELECT TOP 7 * FROM film", baglanti); // create a DataSet object to hold you table(s)... this can contain more than 1 table
            daFilmAfis.Fill(dsFilmAfis);

            for (int i = 0; i < dsFilmAfis.Tables[0].Rows.Count; i++)
            {
                var imgDiv = new HtmlGenericControl("div");
                imgDiv.Attributes["class"] = "card";
                imgDiv.Attributes["style"] = "width: 12rem; height: 18rem; margin-top:3rem; margin-right:5px; margin-left:18px;";
                var img = new HtmlGenericControl("img");
                img.Attributes["src"] = dsFilmAfis.Tables[0].Rows[i]["img_path"].ToString();
                var imgA = new HtmlGenericControl("a");
                imgA.Attributes["href"] = "/filmdetay.aspx/?id=" + dsFilmAfis.Tables[0].Rows[i]["id"];
                imgA.Attributes["id"] = dsFilmAfis.Tables[0].Rows[i]["id"].ToString();
                imgA.Attributes["runat"] = "server";
                img.Attributes["class"] = "card-img-top mb-0";
                imgA.Controls.Add(img);
                imgDiv.Controls.Add(imgA);
                filmAkis.Controls.Add(imgDiv);
            }


            // Afişin alt kısmı
            DataSet dsFilmGonderi = new DataSet();
            SqlDataAdapter daFilmGonderi = new SqlDataAdapter("SELECT film.id,film.adi,film.cikis_tarihi,film.konu,film.img_path,kategori.kategori_adi FROM film INNER JOIN kategori ON film.kategori_id = kategori.id;", baglanti); // create a DataSet object to hold you table(s)... this can contain more than 1 table
            daFilmGonderi.Fill(dsFilmGonderi);
            for (int i = 0; i < dsFilmGonderi.Tables[0].Rows.Count; i++)
            {
                var postDiv = new HtmlGenericControl("div");
                postDiv.Attributes["class"] = "movie_card";
                var postDiv2 = new HtmlGenericControl("div");
                postDiv2.Attributes["class"] = "info_section";
                //
                var postDiv3 = new HtmlGenericControl("div");
                postDiv3.Attributes["class"] = "movie_header";
                var postImg = new HtmlGenericControl("img");
                postImg.Attributes["class"] = "locandina";
                postImg.Attributes["src"] = dsFilmGonderi.Tables[0].Rows[i]["img_path"].ToString();
                var postH1 = new HtmlGenericControl("h1")
                {
                    InnerText = dsFilmGonderi.Tables[0].Rows[i]["adi"].ToString()
                };
                var h1Anc = new HtmlGenericControl("a");
                h1Anc.Attributes["href"] = "/filmdetay.aspx?id=" + dsFilmGonderi.Tables[0].Rows[i]["id"].ToString();
                h1Anc.Controls.Add(postH1);

                var postH4 = new HtmlGenericControl("h4")
                {
                    InnerText = dsFilmGonderi.Tables[0].Rows[i]["cikis_tarihi"].ToString()
                };
                var postP2 = new HtmlGenericControl("p") { InnerText = dsFilmGonderi.Tables[0].Rows[i]["kategori_adi"].ToString() };
                postP2.Attributes["class"] = "type";
                postDiv3.Controls.Add(postImg);
                postDiv3.Controls.Add(h1Anc);
                postDiv3.Controls.Add(postH4);
                postDiv3.Controls.Add(postP2);
                postDiv2.Controls.Add(postDiv3);
                //
                var pDiv = new HtmlGenericControl("div");
                pDiv.Attributes["class"] = "movie_desc";
                var postP = new HtmlGenericControl("p") { InnerText = dsFilmGonderi.Tables[0].Rows[i]["konu"].ToString() };
                postP.Attributes["class"] = "text";
                pDiv.Controls.Add(postP);
                postDiv2.Controls.Add(pDiv);
                //
                var postLastDiv = new HtmlGenericControl("div");
                postLastDiv.Attributes["class"] = "blur_back bright_back";
                postLastDiv.Attributes["style"] = "background-image: url('" + dsFilmGonderi.Tables[0].Rows[i]["img_path"].ToString() + "');";
                postDiv.Controls.Add(postDiv2);
                postDiv.Controls.Add(postLastDiv);
                filmGonderi.Controls.Add(postDiv);
            }

        }
    }
}