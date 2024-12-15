using Lab2_Zadanie.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Zadanie
{
    internal class CompanyContext : DbContext
    {
        public DbSet<Pracownik> Pracownicy { get; set; }
        public DbSet<Stanowisko> Stanowiska { get; set; }
    }
}
