using System.ComponentModel.DataAnnotations;

namespace QUANTUMWEB.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public String BayiKodu { get; set; }
        public String BayiAdi { get; set; }

        public String KullaniciAdi { get; set; }

        public String Parola { get; set; }
        public String Admin { get; set; }

        public bool LisansYetkisi1 { get; set; }
        public bool SystemAdmin { get; set; }
    }
}
