namespace ConsoleApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Proizvod Proizvod1 = new Proizvod("Laptop", 1500.00m, 10);
            Proizvod Proizvod2 = new Proizvod("Telefon", 800.00m, 20);

            Proizvod1.IspisiInformacije();
            Proizvod2.IspisiInformacije();

            ElektronickiUredjaj elektronickiUredjaj = 
                new PametniTelefon("Tablet", "Samsung", 2022, "Android");

            elektronickiUredjaj.IspisiInformacije();


        }
    }
}
