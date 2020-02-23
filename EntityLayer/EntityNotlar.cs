using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
   public class EntityNotlar
    {
        private int _ogrenciId;
        private int _sinav1;
        private int _sinav2;
        private int _sinav3;
        private int _proje;
        private double _ortalama;
        private string _durum;
        public int OgrenciId
        {
            get => _ogrenciId;
            set => _ogrenciId = value;
        }

        public int Sinav1
        {
            get => _sinav1;
            set => _sinav1 = value;
        }

        public int Sinav2
        {
            get => _sinav2;
            set => _sinav2 = value;
        }

        public int Sinav3
        {
            get => _sinav3;
            set => _sinav3 = value;
        }

        public double Ortalama
        {
            get => _ortalama;
            set => _ortalama = value;
        }

        public int Proje
        {
            get => _proje;
            set => _proje = value;
        }

        public string Durum
        {
            get => _durum;
            set => _durum = value;
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


        private string _AD;
        private string _SOYAD;


    }
}
