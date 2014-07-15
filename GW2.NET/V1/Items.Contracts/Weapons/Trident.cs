﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Trident.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a trident.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Contracts.Weapons
{
    using GW2DotNET.Common;

    /// <summary>Represents a trident.</summary>
    [TypeDiscriminator(Value = "Trident", BaseType = typeof(Weapon))]
    public class Trident : Weapon
    {
    }
}