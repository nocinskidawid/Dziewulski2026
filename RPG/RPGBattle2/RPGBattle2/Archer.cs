namespace RPGBattle2
{
    public class Archer : Character
    {
        public int ArrowDamage { get; }
        public Archer(string name, int maxHealth, int arrowDamage) : base(name, maxHealth)
        {
            ArrowDamage = arrowDamage;
        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} strzela z łuku dwukrotnie {target.Name}");
            target.TakeDamage(ArrowDamage);
            target.TakeDamage(ArrowDamage);
        }
        public override void SpecjalnaUmiejetnosc()
        {
            Console.WriteLine("Specjalna umiejetnosc lucznika");
        }

    }
}