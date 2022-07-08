using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string Sicil { get; set; }
        public string AdSoyad { get; set; }
        public Unvan Unvan { get; set; }
        public Birim Birim { get; set; }
        public string DahiliTelefonu { get; set; }
        public string CepTelefonu { get; set; }
        public bool Status { get; set; }

    }
}
