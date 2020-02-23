using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityKulup
   {
       private int _kulupId;
       private string _kulupAd;

       public int KulupId
       {
           get => _kulupId;
           set => _kulupId = value;
       }

       public string KulupAd
       {
           get => _kulupAd;
           set => _kulupAd = value;
       }
   }
}
