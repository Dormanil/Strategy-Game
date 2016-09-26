﻿#region LICENSE

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Material.cs" company="SpaceKrakens">
//   MIT License
//   Copyright (c) 2016 SpaceKrakens
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace StrategyGame.Items.Weapons.Materials
{
    using System;

    using StrategyGame.Characters;

    /// <summary>
    /// The material.
    /// </summary>
    public abstract class Material
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// Gets or sets the action that applies the weapon's material bonuses to the unit.
        /// </summary>
        protected Action<Unit> ApplyMaterialAction { get; set; }

        /// <summary>
        /// Gets or sets the action that unapplies the weapon's material bonuses to the unit.
        /// </summary>
        protected Action<Unit> UnapplyMaterialAction { get; set; }

        /// <summary>
        /// The name of the material.
        /// </summary>
        /// <returns>The name of the material</returns>
        public abstract override string ToString();
    }
}