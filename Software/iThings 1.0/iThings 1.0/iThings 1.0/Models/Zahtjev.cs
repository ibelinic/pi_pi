using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iThings_1._0.Models
{
    internal class Zahtjev
    {
        public int Id { get; set; }

        public string Podnositelj { get; set; }

        public string Status { get; set; }

        public DateTime DatumPodnosenja { get; set; }

        public string SifraOpreme { get; set; }

        public string NazivOpreme { get; set; }

        public int KolicinaOpreme { get; set; }
    }
}
