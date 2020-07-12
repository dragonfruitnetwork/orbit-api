using System.Globalization;
using DragonFruit.Common.Data.Parameters;

namespace DragonFruit.Orbit.API.Requests
{
    public abstract class OsuPaginatedRequest : OrbitApiRequest
    {
        /// <summary>
        /// The 0-starting number of the page being requested
        /// </summary>
        public uint Page { get; set; }
        
        [QueryParameter("limit")]
        public int ItemsPerPage { get; set; } = 15;

        [QueryParameter("offset")]
        protected string Offset => (Page * ItemsPerPage).ToString(CultureInfo.InvariantCulture);
    }
}