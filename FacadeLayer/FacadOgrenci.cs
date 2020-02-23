using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using EntityLayer;
namespace FacadeLayer
{
   public class FacadOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci ekle)
        {
            SqlCommand komut=new SqlCommand("OGRENCIEKLE", SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();
            komut.Parameters.AddWithValue("AD", ekle.Ad);
            komut.Parameters.AddWithValue("SOYAD", ekle.Soyad);
            komut.Parameters.AddWithValue("FOTOGRAF", ekle.Fotograf);
            komut.Parameters.AddWithValue("KULUPID", ekle.Kulupid);
            return komut.ExecuteNonQuery();
        }
        public static bool OgrenciSil(int deger)
        {
            SqlCommand komut = new SqlCommand("OGRENCISIL", SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();
            komut.Parameters.AddWithValue("ID", deger);
            return komut.ExecuteNonQuery() > 0;
        }

        public static bool OgrenciGuncelle(EntityOgrenci guncelle)
        {
            SqlCommand komut = new SqlCommand("OGRENCIGUNCELLE", SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();
            komut.Parameters.AddWithValue("AD", guncelle.Ad);
            komut.Parameters.AddWithValue("SOYAD", guncelle.Soyad);
            komut.Parameters.AddWithValue("FOTOGRAF", guncelle.Fotograf);
            komut.Parameters.AddWithValue("KULUPID", guncelle.Kulupid);
            komut.Parameters.AddWithValue("ID", guncelle.Id);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci>degerler=new List<EntityOgrenci>();
            SqlCommand komut=new SqlCommand("OGRENCILISTESI",SqlBaglantisi.baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
                komut.Connection.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent=new EntityOgrenci();
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Fotograf = dr["FOTOGRAF"].ToString();
                ent.Kulupid =Convert.ToInt16( dr["KULUPID"]);
                ent.Id = Convert.ToInt16(dr["ID"]);
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
