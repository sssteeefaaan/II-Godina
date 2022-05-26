using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet
{
    public class StudentSAF : Student
    {
        private int pismeni, seminarski;

        public StudentSAF(int brojIndeksa, string ime, string prezime, int pismeni, int seminarski)
            : base(brojIndeksa, ime, prezime)
        {
            this.pismeni = pismeni;
            this.seminarski = seminarski;
        }

        public override int BrojBodova
        {
            get
            {
                return pismeni + seminarski;
            }
        }
    }
}
