using CounterStrike.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public abstract class Silah
    {
        public string SilahAdi { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public double Agirlik { get; set; }
        public bool AtesliMi { get; set; }
        public Menzil Menzili { get; set; }
        public Silah()
        {

        }
        public Silah(string marka, string model, double agirlik)
        {
            Marka = marka;
            Model = model;
            Agirlik = agirlik;
        }

    }
}
