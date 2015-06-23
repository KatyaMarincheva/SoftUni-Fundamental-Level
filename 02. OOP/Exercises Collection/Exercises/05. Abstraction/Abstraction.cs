namespace _05.Abstraction
{
    using Characters;

    public class Abstraction
    {
        public static void Main()
        {
            Priest p = new Priest();
            Warrior w = new Warrior();

            w.Attack(p);
            p.Heal(p);
        }
    }
}
