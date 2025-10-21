namespace ConsoleApp
{
    internal class Program
    {
        public class Proizvod         {
            public string Naziv { get; set; }
            public decimal Cijena { get; set; }
            public int DostupnaKolicina { get; set; }
            public Proizvod(string naziv, decimal cijena,int DostupnaKolicina)
            
            {
                Naziv = naziv;
                Cijena = cijena;
                DostupnaKolicina = dostupnaKolicina;

            }
        }
        public void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvod Proizvod1 = new Proizvod("Laptop", 1500.00m, 10);
            Proizvod Proizvod2 = new Proizvod("Telefon", 800.00m, 20);

            Proizvod1.PrikaziInformacije();
            Proizvod2.PrikaziInformacije();

            ElektronickiUredjaj elektronickiUredjaj = 
                new PametniTelefon("Tablet", "Samsung", 2022, "Android");

            elektronickiUredjaj.IspisiInformacije();


        }
    }
}
