using System;
using System.Data.SqlClient;
using System.Configuration;

namespace DiziOneriWebSitesii
{
    public partial class DiziDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DiziGetir();
            }
        }

        private void DiziGetir()
        {
            string id = Request.QueryString["id"];

            if (string.IsNullOrEmpty(id))
            {
                Response.Write("Dizi bulunamadı.");
                return;
            }

            SqlConnection baglanti = new SqlConnection(
                ConfigurationManager.ConnectionStrings["DiziOneriBaglanti"].ConnectionString
            );

            SqlCommand komut = new SqlCommand(
                "SELECT * FROM Diziler WHERE Id=@id",
                baglanti
            );

            komut.Parameters.AddWithValue("@id", id);

            try
            {
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    lblBaslik.Text = dr["Baslik"].ToString();
                    lblAciklama.Text = dr["Aciklama"].ToString();
                    lblTur.Text = dr["Kategori"].ToString();

                    string resimYolu = dr["Resim"].ToString();
                    if (!string.IsNullOrEmpty(resimYolu))
                    {
                        imgDizi.ImageUrl = resimYolu;
                    }
                    else
                    {
                        imgDizi.ImageUrl = "~/Images/no-image.jpg";
                    }
                }
                else
                {
                    Response.Write("Bu ID'ye sahip dizi bulunamadı.");
                }

                dr.Close();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                Response.Write("HATA: " + ex.Message);
            }
        }
    }
}