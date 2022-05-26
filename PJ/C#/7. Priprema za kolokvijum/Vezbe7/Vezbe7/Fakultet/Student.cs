using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fakultet
{
    public abstract class Student
    {
        private int brojIndeksa;
        private string ime;
        private string prezime;

        public Student(int brojIndeksa, string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
        }

        public abstract int BrojBodova { get; }

        public override string ToString()
        {
            return brojIndeksa + " " + ime + " " + prezime + ": " + BrojBodova;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.BrojBodova < s2.BrojBodova;
        }

        public static bool operator >(Student s1, Student s2)
        {
            return s1.BrojBodova > s2.BrojBodova;
        }
    }
}
