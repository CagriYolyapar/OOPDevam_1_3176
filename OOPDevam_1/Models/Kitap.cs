using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDevam_1.Models
{
    public class Kitap
    {
        public string Isim { get; set; }
        public int SayfaSayisi { get; set; }
        public Yazar Yazari { get; set; }

        public string BilgiGoster()
        {
            return $"{Isim}..{SayfaSayisi} sayfa..{Yazari.BilgiGoster()}";
        }

    }
}
