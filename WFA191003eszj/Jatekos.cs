using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA191003eszj
{
    class Jatekos
    {
        public string Nev { get; set; }
        public int[] Tippek { get; set; }

        public Jatekos(string sor)
        {
            string[] t = sor.Split(' ');
            Nev = t[0];

            Tippek = new int[t.Length - 1];

            for (int i = 1; i < t.Length; i++)
            {
                Tippek[i - 1] = int.Parse(t[i]);
            }
        }
    }
}
