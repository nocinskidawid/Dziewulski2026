namespace RPGBattle2
{
    public class Warrior : Character
    {
        public int Strength { get; }
    public Warrior(string name, int maxHealth, int strength) : base(name, maxHealth)
        {
            Strength = strength;

        }

        public override void Attack(Character target)
        {
            Console.WriteLine($"{Name} tnie mieczem {target.Name}");
            target.TakeDamage(Strength);
        }
        public override void SpecjalnaUmiejetnosc()
        {
            Console.WriteLine("Specjalna umiejetnosc warriora");
        }

    }
}