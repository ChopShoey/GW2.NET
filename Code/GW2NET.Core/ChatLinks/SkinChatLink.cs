﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SkinChatLink.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Represents a chat link that links to a wardrobe skin.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.ChatLinks
{
    using GW2NET.Common;

    /// <summary>Represents a chat link that links to a wardrobe skin.</summary>
    [Converter(typeof(SkinChatLinkConverter))]
    public class SkinChatLink : ChatLink
    {
        /// <summary>Gets or sets the skin identifier.</summary>
        public int SkinId { get; set; }
    }
}