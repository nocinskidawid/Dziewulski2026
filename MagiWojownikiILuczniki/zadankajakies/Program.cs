namespace zadankajakies
{

    public abstract class Postac
    {
        public string NazwaPostaci {  get; set; }
        public int HP { get; set; }
        public int Poziom { get; set; }

        public Postac(string nazwaPostaci, int hp, int poziom)
        {
            this.NazwaPostaci = nazwaPostaci;
            this.HP = hp;
            this.Poziom = poziom;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Name: {NazwaPostaci}, Hp: {HP}, lvl: {Poziom}");
        }

        public abstract void Atak();

        public virtual void SpecjalnySkill()
        {
            Console.WriteLine("Postac uzywa umiejstnosci specjalnej");
        }
    }

    interface IWojownik
    {
        public void AtakujMieczem();
    }

    interface IMag
    {
        public void LeczSie();
    }

    interface ILucznik
    {
        public void AtakujZLuku();
    }
    public class Wojownik : Postac, IWojownik
    {
        int silaAtaku { get; set; }
        public Wojownik(string nazwa, int hp, int poziom, int silaAtaku) : base(nazwa, hp, poziom)
        {
            this.silaAtaku = silaAtaku;
            this.NazwaPostaci = nazwa;
            this.HP=hp;
            this.Poziom = poziom;
        }
        public override void Atak()
        {
            Console.WriteLine("atakuje wojownik");
        }

        public void AtakujMieczem()
        {
            Console.WriteLine("Atakuje mieczem");
        }
        public override void SpecjalnySkill()
        {
            Console.WriteLine("Wojownik uzywa wpierdolu");
        }
    }

    public class Mag: Postac, IMag
    {
        public Mag(string nazwa, int hp, int poziom): base(nazwa, hp, poziom)
        {
            this.NazwaPostaci= nazwa;
            this.HP = hp;
            this.Poziom = poziom;
        }

        public override void Atak()
        {
            Console.WriteLine("atakuje jako mag");
        }

        public void LeczSie()
        {
            Console.WriteLine("Lecze sie");
        }

        public override void SpecjalnySkill()
        {
            Console.WriteLine("Mag uzywa kuli mocy");
        }
    }

    public class Lucznik: Postac, ILucznik
    {
        public Lucznik(string nazwa, int hp, int poziom) : base(nazwa, hp, poziom)
        {
            this.NazwaPostaci = nazwa;
            this.HP = hp;
            this.Poziom = poziom;
        }

        public override void Atak()
        {
            Console.WriteLine("Atakuje z luku");
        }

        public void AtakujZLuku()
        {
            Console.WriteLine("Atakuje z luku");
        }

        public override void SpecjalnySkill()
        {
            Console.WriteLine("Lucznik uzywa ognistej strzaly");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Wojownik wojownik = new Wojownik("Cezary", 100, 1, 20);
            Mag magik = new Mag("Radagast", 80, 1);
            Lucznik lucznik = new Lucznik("Beria", 50, 2);

            List<Postac> druzyna = new List<Postac>();
            druzyna.Add(wojownik);
            druzyna.Add(magik);
            druzyna.Add(lucznik);
        
            foreach(Postac postac in druzyna)
            {
                var metoda = postac.GetType().GetMethod("LeczSie");
                //Console.WriteLine(metoda);

                //if(postac is Wojownik)
                //{
                //    Console.WriteLine($"Postac {postac.NazwaPostaci} jest wojownikiem");
                //}

                postac.Atak();
                postac.WyswietlInformacje();
                postac.SpecjalnySkill();
            }
        }
    }
}
