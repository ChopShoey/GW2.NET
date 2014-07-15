﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sword.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a sword.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Contracts.Weapons
{
    using GW2DotNET.Common;

    /// <summary>Represents a sword.</summary>
    [TypeDiscriminator(Value = "Sword", BaseType = typeof(Weapon))]
    public class Sword : Weapon
    {
    }
}