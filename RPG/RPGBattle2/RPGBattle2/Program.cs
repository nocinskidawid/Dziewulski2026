namespace RPGBattle2
{
internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> party = [
               new Warrior("Pawel", 120, 15),
           new Archer("Robin Chud", 90, 8),
           new Mage("Strange", 70, 30, 50)
            ];

            var boss = new Warrior("Thanos", 200, 15);

            foreach (var hero in party)
            {
                Console.WriteLine(hero);
            }

            Console.WriteLine(boss);

            int round = 1;
            while (boss.IsAlive && party.Any(h => h.IsAlive))
            {
                Console.WriteLine($"--- Runda {round++} ---");
                foreach (var hero in party.Where(h => h.IsAlive))
                {
                    if (!boss.IsAlive) break;
                    hero.Attack(boss);
                }

                var victim = party.FirstOrDefault(h => h.IsAlive);
                if (boss.IsAlive && victim is not null)
                {
                    boss.Attack(victim);
                }
                Console.WriteLine();


            }
            Console.WriteLine(boss.IsAlive ? "Druzyna przegrala" : "Zwyciestwo");


        }
    }
}