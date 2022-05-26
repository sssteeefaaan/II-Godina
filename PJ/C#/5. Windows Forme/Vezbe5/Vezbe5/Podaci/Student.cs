using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public enum NivoStudija
    {
        Osnovne = 0,
        Master,
        Doktorske
    }

    public class Student
    {
        private string ime, prezime;
        private int brojIndeksa;
        private NivoStudija nivoStudija;
        private int godinaStudija;
        private double prosek;
        private bool budzet;
        private DateTime datumRodjenja;

        public string Ime
        {
            get { return this.ime; }
            set { this.ime = value; }
        }

        public string Prezime
        {
            get { return this.prezime; }
            set { this.prezime = value; }
        }

        public int BrojIndeksa
        {
            get { return this.brojIndeksa; }
            set { this.brojIndeksa = value; }
        }

        public NivoStudija NivoStudija
        {
            get { return this.nivoStudija; }
            set { this.nivoStudija = value; }
        }

        public int GodinaStudija
        {
            get { return this.godinaStudija; }
            set { this.godinaStudija = value; }
        }

        public double Prosek
        {
            get { return this.prosek; }
            set { this.prosek = value; }
        }

        public bool Budzet
        {
            get { return this.budzet; }
            set { this.budzet = value; }
        }

        public DateTime DatumRodjenja
        {
            get { return this.datumRodjenja; }
            set { this.datumRodjenja = value; }
        }

        public Student(string ime = "Unknown", string prezime = "Unknown", int brojIndeksa=1, NivoStudija nivoStudija=NivoStudija.Osnovne,
            int godinaStudija=1, double prosek=10, bool budzet=true, DateTime datumRodjenja= new DateTime())
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
            this.nivoStudija = nivoStudija;
            this.godinaStudija = godinaStudija;
            this.prosek = prosek;
            this.budzet = budzet;
            this.datumRodjenja = datumRodjenja;
        }

        public Student(Student drugi)
        {
            this.ime = drugi.ime;
            this.prezime = drugi.prezime;
            this.brojIndeksa = drugi.brojIndeksa;
            this.nivoStudija = drugi.nivoStudija;
            this.godinaStudija = drugi.godinaStudija;
            this.prosek = drugi.prosek;
            this.budzet = drugi.budzet;
            this.datumRodjenja = drugi.datumRodjenja;
        }

        public override string ToString()
        {
            return brojIndeksa + " " + ime + " " + prezime;
        }

        private void SaveBin(BinaryWriter bw)
        {
            bw.Write(ime);
            bw.Write(prezime);
            bw.Write(brojIndeksa);
            bw.Write((int)nivoStudija);
            bw.Write(godinaStudija);
            bw.Write(prosek);
            bw.Write(budzet);
            bw.Write(datumRodjenja.ToBinary());
        }

        private void ReadBin(BinaryReader br)
        {
            ime = br.ReadString();
            prezime = br.ReadString();
            brojIndeksa = br.ReadInt32();
            nivoStudija = (NivoStudija)br.ReadInt32();
            godinaStudija = br.ReadInt32();
            prosek = br.ReadDouble();
            budzet = br.ReadBoolean();
            datumRodjenja = DateTime.FromBinary(br.ReadInt64());
        }

        public static void SnimiStudente(string path, List<Student> studenti)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create)))
            {
                bw.Write(studenti.Count);
                for (int i = 0; i < studenti.Count; i++)
                {
                    studenti[i].SaveBin(bw);
                }
            }
        }

        public static List<Student> UcitajStudente(string path)
        {
            List<Student> studenti = new List<Student>();
            using (BinaryReader br = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                int broj = br.ReadInt32();
                for (int i = 0; i < broj; i++)
                {
                    Student student = new Student();
                    student.ReadBin(br);
                    studenti.Add(student);
                }
            }
            return studenti;
        }

    }
}
