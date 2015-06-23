namespace _05.Abstraction.Characters
{
    using Interfaces;

    public class Priest : Character, IHeal
    {
        private const int DefaultPriestHealth = 120;
        private const int DefaultPriestMana = 200;
        private const int DefaultPriestDamage = 100;

        public Priest() 
            : base(DefaultPriestHealth, DefaultPriestMana, DefaultPriestDamage)
        {
        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
            this.Health += this.Damage / 10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
