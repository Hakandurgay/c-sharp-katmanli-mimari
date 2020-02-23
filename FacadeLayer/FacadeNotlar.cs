using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
namespace FacadeLayer
{
  public   class FacadeNotlar
    {
        public static bool NotGuncelle(EntityNotlar deger)
        {
            SqlCommand komut = new SqlCommand("NOTGUNCELLE", SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();
            komut.Parameters.AddWithValue("SINAV1", deger.Sinav1);
            komut.Parameters.AddWithValue("SINAV2", deger.Sinav2);
            komut.Parameters.AddWithValue("SINAV3", deger.Sinav3);
            komut.Parameters.AddWithValue("PROJE", deger.Proje);
            komut.Parameters.AddWithValue("ORTALAMA", deger.Ortalama);
            komut.Parameters.AddWithValue("DURUM", deger.Durum);
            komut.Parameters.AddWithValue("OGRID", deger.OgrenciId);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityNotlar> NotListesi()
        {
            List<EntityNotlar> degerler=new List<EntityNotlar>();
            SqlCommand komut=new SqlCommand("NOTLISTESI",SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityNotlar ent=new EntityNotlar();
                ent.OgrenciId =Convert.ToInt16(dr["OGRID"]);
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sinav1 =Convert.ToInt16(dr["SINAV1"]);
                ent.Sinav2 =Convert.ToInt16(dr["SINAV2"]);
                ent.Sinav3 =Convert.ToInt16(dr["SINAV3"]);
                ent.Proje =Convert.ToInt16(dr["PROJE"]);
                ent.Ortalama = Convert.ToDouble(dr["ORTALAMA"]);
                ent.Durum = dr["DURUM"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
