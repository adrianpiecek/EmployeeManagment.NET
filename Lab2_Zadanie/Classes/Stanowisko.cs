using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Zadanie.Classes
{
    internal class Stanowisko
    {
        public string Nazwa { get; set; }
        public string Dzial { get; set; }
        public int Poziom { get; set; }

        public IEnumerable<Pracownik> Pracownicy { get; set; }
    }
}
