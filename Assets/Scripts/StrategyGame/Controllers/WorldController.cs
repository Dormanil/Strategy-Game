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
    using System.Collections.Generic;

    using StrategyGame.World;

    /// <summary>
    /// The controller for everything in the world.
    /// </summary>
    public class WorldController : MonoBehaviour
    {
        /// <summary>
        /// The tile/game object dictionary.
        /// </summary>
        private static Dictionary<Tile, GameObject> tileGameObjectDictionary = new Dictionary<Tile, GameObject>();

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

            GameObject go = new GameObject();
            go.transform.SetParent(this.transform);
            go.name = "Map";

            for (int i = 0; i < debugMap.Tiles.GetLength(0); i++)
            {
                for (int j = 0; j < debugMap.Tiles.GetLength(1); j++)
                {
                    GameObject tileGameObject = new GameObject();
                    tileGameObject.transform.SetParent(go.transform);
                    tileGameObject.transform.position = new Vector3(j, i);
                    tileGameObject.name = $"Tile [{i} : {j}]";
                    tileGameObjectDictionary.Add(debugMap.Tiles[i, j], tileGameObject);
                }
            }
        }
    }
}