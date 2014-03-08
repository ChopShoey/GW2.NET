﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SubregionCollection.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace GW2DotNET.V1.Core.MapsInformation.Floors.Regions.Subregions
{
    /// <summary>
    ///     Represents a collection of maps and their details.
    /// </summary>
    public class SubregionCollection : JsonDictionary<int, Subregion>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SubregionCollection" /> class.
        /// </summary>
        public SubregionCollection()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SubregionCollection" /> class.
        /// </summary>
        /// <param name="capacity">The initial number of elements that the new dictionary can contain.</param>
        public SubregionCollection(int capacity)
            : base(capacity)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SubregionCollection" /> class.
        /// </summary>
        /// <param name="dictionary">The dictionary whose values are copied to the new dictionary.</param>
        public SubregionCollection(IDictionary<int, Subregion> dictionary)
            : base(dictionary)
        {
        }
    }
}