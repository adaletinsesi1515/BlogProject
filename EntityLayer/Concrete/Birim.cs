using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Birim
    {
        [Key]
        public int BirimId { get; set; }
        public string BirimAdi { get; set; }
        public string BirimKod { get; set; }
        public ICollection<Personel> personels { get; set; }
    }
}
