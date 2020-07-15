// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System.Globalization;
using DragonFruit.Common.Data.Parameters;

#nullable enable

namespace DragonFruit.Orbit.API.Requests
{
    /// <summary>
    /// A request using a page number, limit and an offset
    /// </summary>
    public abstract class OrbitPaginatedRequest : OrbitApiRequest
    {
        protected abstract bool UsesOffset { get; }

        /// <summary>
        /// The 0-starting number of the page being requested
        /// </summary>
        public uint Page { get; set; }

        /// <summary>
        /// The maximum number of items to return in a single response. (Capped at something like 18)
        /// </summary>
        [QueryParameter("limit")]
        public int ItemsPerPage { get; set; } = 15;

        [QueryParameter("offset")]
        protected string? Offset => UsesOffset ? (Page * ItemsPerPage).ToString(CultureInfo.InvariantCulture) : null;

        [QueryParameter("page")]
        protected string? PageNumber => !UsesOffset ? Page.ToString(CultureInfo.InvariantCulture) : null;
    }
}
