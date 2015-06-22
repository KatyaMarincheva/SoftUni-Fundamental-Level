using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    public class ShieldReaver : Projectile
    {
        // constructor
        public ShieldReaver(int damage)
            : base(damage)
        {
        }

        // method
        public override void Hit(IStarship targetShip)
        {
            targetShip.Shields -= this.Damage * 2;
            targetShip.Health -= this.Damage;
        }
    }
}
