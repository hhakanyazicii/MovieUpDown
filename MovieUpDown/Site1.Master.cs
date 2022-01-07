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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                loginNavBtn.Visible = false;
                signupNavBtn.Visible = false;
                navUserNameLabel.Visible = true;
                navUserNameLabel.Text = "Hoşgeldiniz";
                navLogout.Visible = true;
                navYonetmenEkle.Visible = true;
                navFilmEkle.Visible = true;
                navOyuncuEkle.Visible = true;
            }
            else
            {

            }
            if (Session["noid"] != null)
            {


                loginNavBtn.Visible = false;
                signupNavBtn.Visible = false;
                navUserNameLabel.Visible = true;
                navUserNameLabel.Text = "Hoşgeldiniz";
                navLogout.Visible = true;
            }
            else
            {

            }
        }

        protected void loginNavBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/login.aspx");
        }

        protected void signupNavBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/signup.aspx");
        }

        protected void navLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/default.aspx");
        }

        protected void navFilmEkle_Click(object sender, EventArgs e)
        {
            Response.Redirect("/filmekle.aspx");
        }

        protected void navOyuncuEkle_Click(object sender, EventArgs e)
        {
            Response.Redirect("/oyuncuekle.aspx");
        }

        protected void navYonetmenEkle_Click(object sender, EventArgs e)
        {
            Response.Redirect("/yonetmenekle.aspx");
        }
    }
}