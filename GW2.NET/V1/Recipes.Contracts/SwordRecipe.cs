﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SwordRecipe.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a sword crafting recipe.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Recipes.Contracts
{
    using GW2DotNET.Common;

    /// <summary>Represents a sword crafting recipe.</summary>
    [TypeDiscriminator(Value = "Sword", BaseType = typeof(Recipe))]
    public class SwordRecipe : Recipe
    {
    }
}