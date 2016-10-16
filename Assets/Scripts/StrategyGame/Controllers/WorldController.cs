#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WorldController.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

using UnityEngine;

namespace StrategyGame.Controllers
{
    using StrategyGame.Controllers.Sprites;

    using StrategyGame.World;

    /// <summary>
    /// The controller for everything in the world.
    /// </summary>
    public class WorldController : MonoBehaviour
    {
        /// <summary>
        /// The tile sprite controller.
        /// </summary>
        private TileSpriteController tileSpriteController;

        /// <summary>
        /// Initialises a new instance of the <see cref="WorldController"/> class.
        /// </summary>
        public WorldController()
        {
            Instance = this;
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        public static WorldController Instance { get; private set; }

        /// <summary>
        /// Runs when the game starts.
        /// </summary>
        public void Start()
        {
            this.InitialiseGameState();
        }

        /// <summary>
        /// Update called by unity. Called every frame.
        /// </summary>
        public void Update()
        {
        }

        /// <summary>
        /// Initialises the game state.
        /// </summary>
        private void InitialiseGameState()
        {
            ////InitialiseClasses();
            ////InitialiseItems();
            ////InitialiseUnits();
            ////InitialiseMap();

            Map debugMap = Debug.TestNumberOne.InitialiseGameState();

            this.tileSpriteController = new TileSpriteController(debugMap);
        } 
    }
}