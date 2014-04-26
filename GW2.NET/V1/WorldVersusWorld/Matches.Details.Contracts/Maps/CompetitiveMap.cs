﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompetitiveMap.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a World versus World map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.WorldVersusWorld.Matches.Details.Contracts.Maps
{
    using System.Runtime.Serialization;

    using GW2DotNET.V1.Common.Contracts;
    using GW2DotNET.V1.WorldVersusWorld.Matches.Details.Contracts.Common;
    using GW2DotNET.V1.WorldVersusWorld.Matches.Details.Contracts.Maps.Bonuses;
    using GW2DotNET.V1.WorldVersusWorld.Matches.Details.Contracts.Maps.Objectives;

    /// <summary>Represents a World versus World map.</summary>
    public class CompetitiveMap : JsonObject
    {
        /// <summary>Gets or sets the map's bonuses.</summary>
        [DataMember(Name = "bonuses", Order = 3)]
        public MapBonusCollection Bonuses { get; set; }

        /// <summary>Gets or sets the map's objectives.</summary>
        [DataMember(Name = "objectives", Order = 2)]
        public ObjectiveCollection Objectives { get; set; }

        /// <summary>Gets or sets the map's scoreboard.</summary>
        [DataMember(Name = "scores", Order = 1)]
        public Scoreboard Scores { get; set; }

        /// <summary>Gets or sets the map's type.</summary>
        [DataMember(Name = "type", Order = 0)]
        public CompetitiveMapType Type { get; set; }
    }
}