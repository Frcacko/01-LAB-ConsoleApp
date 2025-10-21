namespace ConsoleApp
{
    internal class PametniTelefon : ElektronickiUredjaj
    {
        public string OperativniSustav { get; set; }
        public PametniTelefon(string naziv, string proizvodjac, int godinaProizvodnje, string OperativniSustav) 
            : base(naziv, proizvodjac, godinaProizvodnje)

        {
            OperatingSystem = operativniSustav;
        }
    }
}
