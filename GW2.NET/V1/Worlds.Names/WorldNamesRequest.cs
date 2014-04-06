// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WorldNamesRequest.cs" company="GW2.Net Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a request for a list of worlds and their localized name.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2DotNET.V1.Worlds.Names
{
    using GW2DotNET.V1.Common;

    /// <summary>Represents a request for a list of worlds and their localized name.</summary>
    public class WorldNamesRequest : ServiceRequest
    {
        /// <summary>Initializes a new instance of the <see cref="WorldNamesRequest" /> class.</summary>
        public WorldNamesRequest()
            : base(Services.WorldNames)
        {
        }
    }
}