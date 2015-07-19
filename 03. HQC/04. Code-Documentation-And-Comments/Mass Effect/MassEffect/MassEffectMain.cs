﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MassEffectMain.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The mass effect main.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MassEffect
{
    using Engine;
    using GameObjects;
    using GameObjects.Locations;
    using Interfaces;

    /// <summary>
    ///     The mass effect main.
    /// </summary>
    public class MassEffectMain
    {
        /// <summary>
        ///     The main.
        /// </summary>
        private static void Main()
        {
            Galaxy galaxy = new Galaxy();
            SeedStarSystems(galaxy);

            ICommandManager commandManager = new ExtendedCommandManager();
            IGameEngine engine = new GameEngine(commandManager, galaxy);
            engine.Run();
        }

        /// <summary>
        /// The seed star systems.
        /// </summary>
        /// <param name="galaxy">
        /// The galaxy.
        /// </param>
        public static void SeedStarSystems(Galaxy galaxy)
        {
            var artemisTau = new StarSystem("Artemis-Tau");
            var serpentNebula = new StarSystem("Serpent-Nebula");
            var hadesGamma = new StarSystem("Hades-Gamma");
            var keplerVerge = new StarSystem("Kepler-Verge");

            galaxy.StarSystems.Add(artemisTau);
            galaxy.StarSystems.Add(serpentNebula);
            galaxy.StarSystems.Add(hadesGamma);
            galaxy.StarSystems.Add(keplerVerge);

            artemisTau.NeighbourStarSystems.Add(serpentNebula, 50);
            artemisTau.NeighbourStarSystems.Add(keplerVerge, 120);

            serpentNebula.NeighbourStarSystems.Add(artemisTau, 50);
            serpentNebula.NeighbourStarSystems.Add(hadesGamma, 360);

            hadesGamma.NeighbourStarSystems.Add(serpentNebula, 360);
            hadesGamma.NeighbourStarSystems.Add(keplerVerge, 145);

            keplerVerge.NeighbourStarSystems.Add(hadesGamma, 145);
            keplerVerge.NeighbourStarSystems.Add(artemisTau, 120);
        }
    }
}