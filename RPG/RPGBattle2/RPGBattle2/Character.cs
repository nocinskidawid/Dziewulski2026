namespace RPGBattle2
{
    public abstract class Character
    {
        public virtual void SpecjalnaUmiejetnosc()
        {
            Console.WriteLine("Nie mam specjalnej umiejetnosci");
        }
        private int _health;
        public string Name { get; }
        public int MaxHP { get; }
    public int Health
        {
            get => _health;
            private set => _health = Math.Clamp(value, 0, MaxHP);
        }
        public bool IsAlive => Health > 0;


        protected Character(string name, int maxHealth)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Podaj poprawne imie postaci", nameof(name));
            }

            if (maxHealth <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(maxHealth));
            }

            Name = name;
            MaxHP = maxHealth;
            Health = maxHealth;
        }

        public void TakeDamage(int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }

            Health -= amount;
            Console.WriteLine($"{Name} otrzymuje {amount} obrazen [HP {Health}/{MaxHP}]");

            if (!IsAlive)
            {
                Console.WriteLine($"Bohater {Name} umiera");
            }
        }

        public abstract void Attack(Character target);
        public override string ToString() => $"{GetType().Name} {Name} [HP {Health}/{MaxHP}]";

    }
}