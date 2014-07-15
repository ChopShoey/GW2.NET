﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppearanceChanger.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents an appearance changing consumable item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Contracts.Consumables
{
    using GW2DotNET.Common;

    /// <summary>Represents an appearance changing consumable item.</summary>
    [TypeDiscriminator(Value = "AppearanceChange", BaseType = typeof(Consumable))]
    public class AppearanceChanger : Consumable
    {
    }
}