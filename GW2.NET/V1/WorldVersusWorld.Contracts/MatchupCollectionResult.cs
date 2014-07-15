﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MatchupCollectionResult.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Wraps a collection of matchups.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.WorldVersusWorld.Contracts
{
    using System.Runtime.Serialization;

    using GW2DotNET.Common.Contracts;

    /// <summary>Wraps a collection of matchups.</summary>
    public class MatchupCollectionResult : ServiceContract
    {
        /// <summary>Gets or sets a collection of matches.</summary>
        [DataMember(Name = "wvw_matches")]
        public MatchupCollection Matchups { get; set; }
    }
}