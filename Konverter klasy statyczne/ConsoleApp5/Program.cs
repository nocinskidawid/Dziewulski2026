namespace ConsoleApp5
{
    internal class Program
    {

        public class Converter()
        {
            public static double CelciusToFarenheit(double Celcius)
            {
                return Celcius * 1.8 + 32;
            }

            public static double KilometersToMiles(double Kilometers)
            {
                return Kilometers * 0.62137;
            }

            public static double KilogramsToPounds(double Kilograms)
            {
                return Kilograms * 2.20462;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("wybierz funkcje:\n 1 - stopnie celcjusza na stopnie farenheita \n 2 - kilometry na mile \n 3 - kilogramy na funty");
                string wybor = Console.ReadLine();

                if (wybor == "1")
                {
                    Console.WriteLine("Podaj liczbe stopni celcjusza");
                    double wartosc = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Converter.CelciusToFarenheit(wartosc)} F");
                }
                else if (wybor == "2")
                {
                    Console.WriteLine("Podaj liczbe kilometrow");
                    double wartosc = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Converter.KilometersToMiles(wartosc)} Mi");
                }
                else if (wybor == "3")
                {
                    Console.WriteLine("Podaj liczbe kilogramow");
                    double wartosc = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{Converter.KilogramsToPounds(wartosc)}lb");
                }
                else
                {
                    Console.WriteLine("Zly wybor");
                }
            } 
        }
    }
}
