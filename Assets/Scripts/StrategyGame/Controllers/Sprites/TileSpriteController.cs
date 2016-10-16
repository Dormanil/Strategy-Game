// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TileSpriteController.cs" company="SpaceKrakens">   
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// <summary>
//   Defines the BaseSpriteController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace StrategyGame.Controllers.Sprites
{
    using System;

    using StrategyGame.World;

    using UnityEngine;

    /// <summary>
    /// The tile sprite controller.
    /// Links and tracks pure tile data with Unity's visuals.
    /// </summary>
    public class TileSpriteController : BaseSpriteController<Tile>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="TileSpriteController"/> class.
        /// </summary>
        /// <param name="map">The map containing the tiles.</param>
        public TileSpriteController(Map map)
            : base("Tiles")
        {
            foreach (Tile tile in map.Tiles)
            {
                this.OnCreated(tile);
                tile.Changed += this.OnChanged;
            }
        }

        /// <summary>
        /// The "changed" callback. It gets called, whenever a tile gets changed.
        /// </summary>
        /// <param name="obj">The tile that got changed.</param>
        protected override void OnChanged(Tile obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The "created" callback. It gets called, whenever a tile gets created.
        /// </summary>
        /// <param name="tile">The tile that got created.</param>
        protected override void OnCreated(Tile tile)
        {
            GameObject tileGo = new GameObject();
            this.ObjectGameObjectMap.Add(tile, tileGo);
            tileGo.transform.SetParent(this.ObjectParent.transform, true);
            tileGo.transform.position = new Vector2(tile.X, tile.Y);
            tileGo.name = $"Tile [{tile.Y} : {tile.X}]";
        }
    }
}
