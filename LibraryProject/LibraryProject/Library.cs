using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    

    internal class Library // Kütüphane adında bir Class oluşturduk. Ve bu classtan kitap nesneleri oluşturacağız. 
    {

        public Library() // Parametre almayan default Constructor metodumuz. 
        {
            
            KayitTarihi = DateTime.Now;
            Ad = "Belirtilmedi";
            YazarAd = "Belirtilmedi";
            YazarSoyad = "Belirtilmedi";
            SayfaSayisi = 0;
            YayinEvi = "Belirtilmedi";





        }

        //Alınan bilgileri propertylere atayan Constructor metodumuz. 
        public Library(string kitapAd, string yazarAd, string yazarSoyAd, int sayfaSayisi, string yayinEvi)
        {
            KayitTarihi = DateTime.Now;
            Ad = kitapAd;
            YazarAd = yazarAd;
            YazarSoyad = yazarSoyAd;
            SayfaSayisi = sayfaSayisi;
            YayinEvi = yayinEvi;


        }


        // Propertiesler. Oluşturulan her nesne için özellikleri. 

        public string Ad;

        public string YazarAd;

        public string YazarSoyad;

        public int SayfaSayisi;

        public string YayinEvi;

        public DateTime KayitTarihi;

    }
}
