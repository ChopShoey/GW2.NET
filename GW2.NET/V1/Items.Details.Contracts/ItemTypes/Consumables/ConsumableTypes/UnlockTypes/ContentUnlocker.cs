﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContentUnlocker.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a content unlock item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Consumables.ConsumableTypes.UnlockTypes
{
    using GW2DotNET.Common;

    /// <summary>Represents a content unlock item.</summary>
    [TypeDiscriminator(Value = "Content", BaseType = typeof(Unlocker))]
    public class ContentUnlocker : Unlocker
    {
    }
}