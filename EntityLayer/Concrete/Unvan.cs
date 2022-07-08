using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Unvan
    {
        [Key]
        public int UnvanId { get; set; }
        public string Unvani { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}
