using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DiziOneriWebSitesii
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HaftaninOnerileriniGetir();
                YeniDizileriGetir();
            }
        }

        void HaftaninOnerileriniGetir()
        {
            SqlConnection baglanti = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DiziOneriBaglanti"].ConnectionString
            );

            SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM HaftaninOnerileri", baglanti);
            baglanti.Open();
            int sayi = Convert.ToInt32(kontrol.ExecuteScalar());
            baglanti.Close();

            if (sayi == 0)
            {
                dlHaftaninOnerileri.DataSource = null;
                dlHaftaninOnerileri.DataBind();
                return;
            }

            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT Diziler.Id, Diziler.Baslik, Diziler.Resim 
                  FROM HaftaninOnerileri 
                  INNER JOIN Diziler ON HaftaninOnerileri.DiziId = Diziler.Id 
                  ORDER BY HaftaninOnerileri.Id",
                baglanti
            );

            DataTable dt = new DataTable();
            da.Fill(dt);

            dlHaftaninOnerileri.DataSource = dt;
            dlHaftaninOnerileri.DataBind();
        }

        void YeniDizileriGetir()
        {
            SqlConnection baglanti = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DiziOneriBaglanti"].ConnectionString
            );

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT TOP 3 * FROM Diziler ORDER BY Id DESC",
                baglanti
            );

            DataTable dt = new DataTable();
            da.Fill(dt);

            dlYeniDiziler.DataSource = dt;
            dlYeniDiziler.DataBind();
        }
    }
}