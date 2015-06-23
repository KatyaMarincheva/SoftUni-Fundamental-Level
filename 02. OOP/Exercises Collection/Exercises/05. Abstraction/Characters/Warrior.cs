namespace _05.Abstraction.Characters
{
    public class Warrior : Character
    {
        private const int DefaultWarriorHealth = 300;
        private const int DefaultWarriorMana = 0;
        private const int DefaultWarriorDamage = 120;

        public Warrior() : 
            base(DefaultWarriorHealth, DefaultWarriorMana, DefaultWarriorDamage)
        {
        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
        }
    }
}
