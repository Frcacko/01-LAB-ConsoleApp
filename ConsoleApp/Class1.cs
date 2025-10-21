using System.Reflection.Emit;

namespace ConsoleApp
{
    public class ElektronickiUredjaj
    {
     public string Naziv { get; set; }
     public string Proizvodjac { get; set; }
     public int GodinaProizvodnje { get; set; }

    public ElektronickiUredjaj(string naziv, string proizvodjac, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvodjac = proizvodjac;
            GodinaProizvodnje = godinaProizvodnje;
        }
        public void IspisiInformacije()
        {
            Console.WriteLine($"Naziv: {Naziv}, Proizvodjac: {Proizvodjac}, Godina Proizvodnje: {GodinaProizvodnje}");
        }

    }
}
