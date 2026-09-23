
namespace Pieski_i_kotki
{
    internal class Program
    {

        interface IZwierze
        {
            public void WydajDzwiek();
        }

        public abstract class Zwierze : IZwierze
        {
            public string nazwa { get; set; }
            public abstract void WydajDzwiek();
            
        }

        public class Kot : Zwierze 
        {
            public override void WydajDzwiek()
            {
                Console.WriteLine("mial");
            }
        }
        public class Pies : Zwierze 
        {
            public override void WydajDzwiek()
            {
                Console.WriteLine("hal");
            }
        }
        public class Nauczyciel : Pies
        {
            public override void WydajDzwiek()
            {
                Console.WriteLine("Wyciagamy karteczki");
                base.WydajDzwiek();
            }
        }
        static void Main(string[] args)
        {
            Zwierze Kitku = new Kot();
            Zwierze Piesel = new Pies();
            Zwierze Nauczyciel = new Nauczyciel();

            Kitku.WydajDzwiek();
            Piesel.WydajDzwiek();
            Nauczyciel.WydajDzwiek();
            
        }
    }
}
