using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
namespace FacadeLayer
{
  public  class FacadeKulup
    {
        public static int KulupEkle(EntityKulup deger) //kaç tane eklendiğini geri döndürecek
        {
             SqlCommand komut= new SqlCommand("KULUPEKLE",SqlBaglantisi.baglanti);
             //insert yerine sqlde yazılan prosedürü çağırıyor ancak programa ne olduğunun bildirilmesi lazım
             komut.CommandType = CommandType.StoredProcedure; //procedure olduğunu belirtiyor

             if(komut.Connection.State !=ConnectionState.Open) //açık değilse aç
             komut.Connection.Open();

             komut.Parameters.AddWithValue("KULUPAD", deger.KulupAd); //ifade içine yazılan değer sqldeki gönderilcek kısım
             //kulupad da entitykulup sınıfndaki değişken
             return komut.ExecuteNonQuery(); //kaç kayıt eklendiğini döndürüyor
        }

        public static bool KulupSil(int deger) //ekleyip eklememe durumuna göre değer döndürecek
        {
            SqlCommand komut=new SqlCommand("KULUPSIL", SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if(komut.Connection.State!=ConnectionState.Open)
                komut.Connection.Open();
            komut.Parameters.AddWithValue("KULUPID", deger);
            return komut.ExecuteNonQuery() > 0;
        }
        public static bool KulupGuncelle(EntityKulup deger)
        {
            SqlCommand komut=new SqlCommand("KULUPGUNCELLE", SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();
            komut.Parameters.AddWithValue("KULUPAD", deger.KulupAd);
            komut.Parameters.AddWithValue("KULUPID", deger.KulupId);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityKulup> KulupListesi()
        {
            List<EntityKulup> degerler =new List<EntityKulup>();
            SqlCommand komut=new SqlCommand("KULUPLISTESI", SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if(komut.Connection.State!=ConnectionState.Open)
                komut.Connection.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityKulup ent=new EntityKulup();
                ent.KulupId = Convert.ToInt16(dr["KULUPID"]);
                ent.KulupAd = dr["KULUPAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
