﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConverterForPointOfInterestChatLink.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Converts objects of type <see cref="Stream" /> to objects of type <see cref="PointOfInterestChatLink" />.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.ChatLinks
{
    using System.Diagnostics.Contracts;
    using System.IO;

    using GW2NET.Common;

    /// <summary>Converts objects of type <see cref="Stream"/> to objects of type <see cref="PointOfInterestChatLink"/>.</summary>
    internal sealed class ConverterForPointOfInterestChatLink : IConverter<Stream, PointOfInterestChatLink>, IConverter<PointOfInterestChatLink, Stream>
    {
        /// <summary>Converts the given object of type <see cref="Stream"/> to an object of type <see cref="PointOfInterestChatLink"/>.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public PointOfInterestChatLink Convert(Stream value)
        {
            Contract.Assume(value != null);
            using (var reader = new BinaryReader(value))
            {
                return new PointOfInterestChatLink
                {
                    PointOfInterestId = reader.ReadInt16()
                };
            }
        }

        /// <summary>Converts the given object of type <see cref="PointOfInterestChatLink"/> to an object of type <see cref="Stream"/>.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The converted value.</returns>
        public Stream Convert(PointOfInterestChatLink value)
        {
            Contract.Assume(value != null);
            var stream = new MemoryStream();
            var buffer = new MemoryStream();
            using (var writer = new BinaryWriter(buffer))
            {
                writer.Write((byte)4);
                writer.Write(value.PointOfInterestId);
                buffer.WriteTo(stream);
            }

            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
    }
}