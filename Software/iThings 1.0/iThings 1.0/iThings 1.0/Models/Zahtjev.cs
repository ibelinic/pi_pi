using iThings_1._0.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iThings_1._0.Models
{
    public class Zahtjev
    {
        public int Id { get; set; }

        public string Podnositelj { get; set; }

        public string Status { get; set; }

        public string DatumPodnosenja { get; set; }


        public string Naziv { get; set; }

        public int Kolicina { get; set; }

    }
}
