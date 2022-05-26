using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet
{
    public class StudentFIB : Student
    {
        private int kol1, kol2, lab;

        public StudentFIB(int brojIndeksa, string ime, string prezime, int kol1, int kol2, int lab)
            : base(brojIndeksa, ime, prezime)
        {
            this.kol1 = kol1;
            this.kol2 = kol2;
            this.lab = lab;
        }

        public override int BrojBodova
        {
            get
            {
                return kol1 + kol2 + lab;
            }
        }

    }
}
