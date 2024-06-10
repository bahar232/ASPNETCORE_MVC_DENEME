namespace QUANTUMWEB.Models;
using System.ComponentModel.DataAnnotations;

    public class Musteriler
    {
        [Key]
        public int MusteriId { get; set; }
        public string Kodu { get; set; }

        public string Adi { get; set; }
        public string TckNo { get; set; } 

        public string Il { get; set; } 
       
       public string Ilce { get; set; }
      
       

        //public string SirketKodu { get; set; }

        //public string Turu { get; set; }
        //public string VergiDaire { get; set; }
        //public int VergiNo { get; set; }

        //public string Email { get; set; }

        //public int Tel1 { get; set; }

        //public string Adres { get; set; }

        //public string WebSite { get; set; }

        //public DateTime DemoKurulumTarihi { get; set; }

        //public bool DemoKuruldu { get; set; }

        //public string Parola { get; set; }
        //public DateTime SonYedeklemeZamani { get; set; }

        //public string Sifre { get; set; }
        //public string YedeklemeServerKonumu { get; set; }

        //public string SonYedeklemeDosyaAdi { get; set; }
        //public decimal Risklimit { get; set; }
        //public decimal SiparisRiskLimit { get; set; }
        //public string TicariTuru { get; set; }

        //public string MutabakatMailServer { get; set; }

        //public string MutabakatMailAdresi { get; set; }
        //public bool MutabakatMailSsl { get; set; }

        //public int MutabakatMailPort { get; set; }
        //public string MutabakatMailKullaniciAdi { get; set; }

        //public string MutabakatMailParola { get; set; }

        //public DateTime SonIletisimZamani { get; set; }

        //public string SonIletisimNedeni { get; set; }

        //public string Notlar { get; set; }
        //public int KullaniciSayisi { get; set; }
}

