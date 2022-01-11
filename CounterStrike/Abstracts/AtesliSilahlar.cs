using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterStrike
{
    public class AtesliSilahlar : Silah
    {
        Random rnd = new Random();
        public int MermiKapasitesi { get; set; }
        public string MermiTipi { get; set; }



        private int anlikMermiSayisi;
        public int MermiSayisi
        {
            get { return anlikMermiSayisi; }
            set { anlikMermiSayisi = value; }
        }



    }
}
