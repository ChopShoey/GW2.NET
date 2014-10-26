﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPaginator.cs" company="GW2.NET Coding Team">
//   This product is licensed under the GNU General Public License version 2 (GPLv2) as defined on the following page: http://www.gnu.org/licenses/gpl-2.0.html
// </copyright>
// <summary>
//   Provides the interface for types that perform pagination.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace GW2NET.Common
{
    using System.Diagnostics.Contracts;
    using System.Threading;
    using System.Threading.Tasks;

    using GW2NET.V2.Common;

    /// <summary>Provides the interface for types that perform pagination.</summary>
    /// <typeparam name="T">The type of elements on the page.</typeparam>
    [ContractClass(typeof(ContractClassForIPaginator<>))]
    public interface IPaginator<T>
    {
        /// <summary>Finds the page with the specified page index.</summary>
        /// <param name="pageIndex">The page index to find.</param>
        /// <returns>The page.</returns>
        ICollectionPage<T> FindPage(int pageIndex);

        /// <summary>Finds the page with the specified page number and maximum size.</summary>
        /// <param name="pageIndex">The page index to find.</param>
        /// <param name="pageSize">The maximum number of page elements.</param>
        /// <returns>The page.</returns>
        ICollectionPage<T> FindPage(int pageIndex, int pageSize);

        /// <summary>Finds the page with the specified page index.</summary>
        /// <param name="pageIndex">The page index to find.</param>
        /// <returns>The page.</returns>
        Task<ICollectionPage<T>> FindPageAsync(int pageIndex);

        /// <summary>Finds the page with the specified page index.</summary>
        /// <param name="pageIndex">The page index to find.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that provides cancellation support.</param>
        /// <returns>The page.</returns>
        Task<ICollectionPage<T>> FindPageAsync(int pageIndex, CancellationToken cancellationToken);

        /// <summary>Finds the page with the specified page index.</summary>
        /// <param name="pageIndex">The page index to find.</param>
        /// <param name="pageSize">The maximum number of page elements.</param>
        /// <returns>The page.</returns>
        Task<ICollectionPage<T>> FindPageAsync(int pageIndex, int pageSize);

        /// <summary>Finds the page with the specified page index.</summary>
        /// <param name="pageIndex">The page index to find.</param>
        /// <param name="pageSize">The maximum number of page elements.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> that provides cancellation support.</param>
        /// <returns>The page.</returns>
        Task<ICollectionPage<T>> FindPageAsync(int pageIndex, int pageSize, CancellationToken cancellationToken);
    }
}