// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using DragonFruit.Common.Data.Parameters;
using DragonFruit.Orbit.Api.Interfaces;

namespace DragonFruit.Orbit.Api
{
    /// <summary>
    /// An <see cref="OrbitRequest"/> that implements the <see cref="IPaginatedByOffset"/> interface
    /// </summary>
    public abstract class OrbitOffsetPaginatedRequest : OrbitRequest, IPaginatedByOffset
    {
        private uint? _offset, _limit;

        /// <summary>
        /// Internal default limit for when a <see cref="Limit"/> is not set.
        /// Internally customisable at a per-request level
        /// </summary>
        internal virtual uint DefaultLimit => 15;

        /// <summary>
        /// 0-based page number
        /// </summary>
        public uint Page { get; set; }

        /// <summary>
        /// Upper-bound for response count. If less than this is returned there aren't any more.
        /// Do not change between requests regarding the same dataset - it'll break the page system
        /// </summary>
        [QueryParameter("limit")]
        public uint? Limit
        {
            get => _limit ?? DefaultLimit;
            set => _limit = value;
        }

        /// <summary>
        /// Offset that is sent to the server. Can be overridden or calculated based on the limit and page.
        /// </summary>
        [QueryParameter("offset")]
        public uint Offset
        {
            // this allows the user to pick their own offset or use the page number
            // ReSharper disable once PossibleInvalidOperationException (we null-coalesce in Limit)
            get => _offset ?? Page * Limit.Value;
            set => _offset = value;
        }
    }
}
