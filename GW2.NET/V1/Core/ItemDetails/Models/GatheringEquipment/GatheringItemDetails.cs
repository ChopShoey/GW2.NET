﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GatheringItemDetails.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.ItemDetails.Models.GatheringEquipment
{
    /// <summary>
    /// Represents detailed information about a piece of gathering equipment.
    /// </summary>
    public class GatheringItemDetails : Common.ItemDetails
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GatheringItemDetails"/> class.
        /// </summary>
        public GatheringItemDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatheringItemDetails"/> class using the specified values.
        /// </summary>
        /// <param name="type">The gathering equipment's type.</param>
        public GatheringItemDetails(GatheringType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets the gathering equipment's type.
        /// </summary>
        [JsonProperty("type", Order = 0)]
        public GatheringType Type { get; set; }
    }
}