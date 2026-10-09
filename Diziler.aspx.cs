using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace DiziOneriWebSitesii
{
    public partial class Diziler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listele();
            }
        }

        private void Listele()
        {
            SqlConnection baglanti = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DiziOneriBaglanti"].ConnectionString
            );

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT DISTINCT * FROM Diziler ORDER BY Baslik",
                baglanti
            );

            DataTable dt = new DataTable();
            da.Fill(dt);

            dlDiziler.DataSource = dt;
            dlDiziler.DataBind();
        }
    }
}