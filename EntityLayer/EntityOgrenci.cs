using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
  public  class EntityOgrenci
    {
        private int _ID;
        private string _AD;
        private string _SOYAD;
        private string _FOTOGRAF;
        private int _KULUPID;

        public int Id
        {
            get => _ID;
            set => _ID = value;
        }
        public string Ad
        {
            get => _AD;
            set => _AD = value;
        }
        public string Soyad
        {
            get => _SOYAD;
            set => _SOYAD = value;
        }
        public string Fotograf
        {
            get => _FOTOGRAF;
            set => _FOTOGRAF = value;
        }
        public int Kulupid
        {
            get => _KULUPID;
            set => _KULUPID = value;
        }
    }
}
