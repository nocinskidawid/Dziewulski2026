namespace RPGBattle2
{
    public class Mage : Character
    {
        private const int SpellCost = 20;
        public int SpellPower { get; }
        public int Mana { get; private set; }
        private const int StaffDamage = 3;
        public Mage(string name, int maxHealth, int mana, int spellPower) : base(name, maxHealth)
        {
            SpellPower = spellPower;
            Mana = mana;
        }
        public override void Attack(Character target)
        {
            if (Mana >= SpellCost)
            {
                Mana -= SpellCost;
                Console.WriteLine($"{Name} tworzy ogniste tornado na {target.Name}");
                target.TakeDamage(SpellPower);
            }
            else
            {
                Console.WriteLine($"{Name} nie ma many wiec uderza kosturem {target.Name}");
                target.TakeDamage(StaffDamage);
            }

        }
        public override void SpecjalnaUmiejetnosc()
        {
            Console.WriteLine("Specjalna umiejetnosc maga");
        }

    }
}