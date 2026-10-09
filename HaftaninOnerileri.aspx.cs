using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DiziOneriWebSitesii
{
    public partial class HaftaninOnerileri : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OnerileriGetir();
            }
        }

        private void OnerileriGetir()
        {
            SqlConnection baglanti = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DiziOneriBaglanti"].ConnectionString
            );

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT Diziler.Id, Diziler.Baslik, Diziler.Resim 
                  FROM HaftaninOnerileri 
                  INNER JOIN Diziler ON HaftaninOnerileri.DiziId = Diziler.Id 
                  ORDER BY HaftaninOnerileri.Id",
                baglanti
            );

            DataTable dt = new DataTable();
            da.Fill(dt);

            dlOneriler.DataSource = dt;
            dlOneriler.DataBind();

            if (dt.Rows.Count == 0)
            {
                Response.Write("<p style='color:white; text-align:center; font-size:20px;'>Henüz haftanın önerisi seçilmedi.</p>");
            }
        }
    }
}