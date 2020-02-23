using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data;
using EntityLayer;
using FacadeLayer;
namespace BusinessLogicLayer
{
   public class BLLKULUP
    {
        public static int KulupEkle(EntityKulup deger)
        {
            if (deger.KulupAd != null)
            {
                return FacadeKulup.KulupEkle(deger);
            }

            return -1;
        }

        public static bool KulupGuncelle(EntityKulup deger)
        {
            if (deger.KulupAd != null && deger.KulupId != null)
            {
                return FacadeKulup.KulupGuncelle(deger);
            }

            return false;
        }

        public static bool sil(int deger)
        {
            if (deger != null)
            {
                return FacadeKulup.KulupSil(deger);
            }
            return false;
        }

        public static List<EntityKulup> Listele()
        {
            return FacadeKulup.KulupListesi();
        }
    }
}
