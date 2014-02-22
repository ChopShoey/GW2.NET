﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemsResult.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;

namespace GW2DotNET.V1.Core.ItemsInformation.Catalog
{
    /// <summary>
    /// Wraps a collection of items.
    /// </summary>
    public class ItemsResult : JsonObject
    {
        /// <summary>
        /// Gets or sets a list of item IDs.
        /// </summary>
        [JsonProperty("items")]
        public Catalog.Items Items { get; set; }
    }
}