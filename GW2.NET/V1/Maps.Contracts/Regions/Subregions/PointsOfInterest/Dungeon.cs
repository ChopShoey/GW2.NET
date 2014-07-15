﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dungeon.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a dungeon entrance.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Maps.Contracts.Regions.Subregions.PointsOfInterest
{
    using GW2DotNET.Common;

    /// <summary>Represents a dungeon entrance.</summary>
    [TypeDiscriminator(Value = "unlock", BaseType = typeof(PointOfInterest))]
    public class Dungeon : PointOfInterest
    {
    }
}