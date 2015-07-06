        using MassEffect.Interfaces;

namespace MassEffect.GameObjects.Projectiles
{
    class Laser : Projectile
    {
        // constructor
        public Laser(int damage)
            : base(damage)
        {
        }

        // method
        public override void Hit(IStarship targetShip)
        {
            int remainder = this.Damage - targetShip.Shields;
            targetShip.Shields -= this.Damage;

            if (remainder > 0)
            {
                targetShip.Health -= remainder;
            }
        }
    }
}