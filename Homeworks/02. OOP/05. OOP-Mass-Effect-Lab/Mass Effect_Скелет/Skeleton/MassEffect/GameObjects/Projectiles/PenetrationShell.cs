using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class PenetrationShell : Projectile
    {
        // constructor
        public PenetrationShell(int damage)
            : base(damage)
        {
        }

        // method
        public override void Hit(IStarship targetShip)
        {
            targetShip.Health -= this.Damage;
        }
    }
}
