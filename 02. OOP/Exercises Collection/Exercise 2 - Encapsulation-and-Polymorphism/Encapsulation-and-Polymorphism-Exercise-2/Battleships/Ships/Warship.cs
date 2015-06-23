namespace Battleships.Ships
{
    public class Warship : BattleShip
    {
        public Warship(string name, double lengthInMeters, double volume)
            : base(name, lengthInMeters, volume)
        {
        }

        public override string Attack(Ship targetShip)
        {
            this.DestroyShip(targetShip);
            return "Victory is ours!";
        }
    }
}