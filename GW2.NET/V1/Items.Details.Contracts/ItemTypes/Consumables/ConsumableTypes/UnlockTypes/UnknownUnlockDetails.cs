﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnknownUnlockDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about an unknown unlock item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Consumables.ConsumableTypes.UnlockTypes
{
    using GW2DotNET.V1.Common.Converters;

    using Newtonsoft.Json;

    /// <summary>Represents detailed information about an unknown unlock item.</summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class UnknownUnlockDetails : UnlockDetails
    {
        /// <summary>Initializes a new instance of the <see cref="UnknownUnlockDetails" /> class.</summary>
        public UnknownUnlockDetails()
            : base(UnlockType.Unknown)
        {
        }
    }
}