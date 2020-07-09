// Orbit API Copyright 2020 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Orbit.API.Objects.Enums;

#nullable enable

namespace DragonFruit.Orbit.API.Requests
{
    public class OsuChangelogRequest : OrbitApiRequest
    {
        protected override string Route => $"/changelog/{(!string.IsNullOrEmpty(_streamName) ? $"{_streamName}/{Version}" : string.Empty)}";
        public override bool RequireAuth => false;

        public OsuChangelogRequest()
        {
        }

        public OsuChangelogRequest(OsuChangelogStream stream, string version)
        {
            Stream = stream;
            Version = version;
        }

        private OsuChangelogStream? _stream;
        private string? _streamName;

        public OsuChangelogStream? Stream
        {
            get => _stream;
            set
            {
                _stream = value;
                _streamName = value switch
                {
                    OsuChangelogStream.Stable => "stable40",
                    OsuChangelogStream.StableFallback => "stable",
                    OsuChangelogStream.Beta => "beta40",
                    OsuChangelogStream.CuttingEdge => "cuttingedge",
                    OsuChangelogStream.Lazer => "lazer",
                    OsuChangelogStream.Web => "web",

                    null => null,
                    _ => throw new ArgumentException(nameof(OsuChangelogStream))
                };
            }
        }

        public string? Version { get; set; }
    }
}
