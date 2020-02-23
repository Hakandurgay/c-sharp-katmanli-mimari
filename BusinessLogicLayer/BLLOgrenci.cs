using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;
namespace BusinessLogicLayer
{
   public class BLLOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci deger)
        {
            if (deger.Ad != null && deger.Soyad != null && deger.Kulupid > 0 && deger.Fotograf != null &&
                deger.Kulupid > 0 && deger.Fotograf.Length > 1) 
            {
                return FacadOgrenci.OgrenciEkle(deger);
            }
            return -1;
        }

        public static bool Guncelle(EntityOgrenci deger)
        {
            if (deger.Ad != null && deger.Soyad != null && deger.Kulupid>0 && deger.Fotograf != null &&
                deger.Kulupid > 0 && deger.Id>0) 
                return FacadOgrenci.OgrenciGuncelle(deger);
            return false;
        }

        public static bool Sil(int deger)
        {
            if (deger != null && deger > 1)
                return FacadOgrenci.OgrenciSil(deger);
            return false;
        }

        public static List<EntityOgrenci>  OgrenciListele()
        {
            return FacadOgrenci.OgrenciListesi();
        }
    }
}
