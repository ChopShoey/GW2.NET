﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnTransmutationDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents detailed information about a un-transmutation consumable item.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Items.Details.Contracts.ItemTypes.Consumables.ConsumableTypes
{
    using GW2DotNET.V1.Common.Converters;

    using Newtonsoft.Json;

    /// <summary>Represents detailed information about a un-transmutation consumable item.</summary>
    [JsonConverter(typeof(DefaultJsonConverter))]
    public class UnTransmutationDetails : ConsumableDetails
    {
        /// <summary>Initializes a new instance of the <see cref="UnTransmutationDetails" /> class.</summary>
        public UnTransmutationDetails()
            : base(ConsumableType.UnTransmutation)
        {
        }
    }
}