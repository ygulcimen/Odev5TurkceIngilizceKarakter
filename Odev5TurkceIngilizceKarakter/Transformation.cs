using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev5TurkceIngilizceKarakter
{
    public class Transformation
    {
        string t = "ığüşöçĞÜŞİÖÇ";
        string e = "igusocGUSIOC";
        public string Transform(string s)
        {
            for (int i = 0; i < t.Length; i++)
            {
               s = s.Replace(t[i], e[i]);
            }
            return s;
        }
    }
}
