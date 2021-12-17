﻿// Orbit API Copyright (C) 2019-2021 DragonFruit Network
// Licensed under the MIT License - see the LICENSE file at the root of the project for more info

using System;
using DragonFruit.Data.Parameters;

namespace DragonFruit.Orbit.Api.Beatmaps.Requests
{
    public class OsuBeatmapRequest : OrbitRequest
    {
        private string _filename;

        protected override string Stub => "beatmaps/lookup";

        [QueryParameter("id")]
        public uint BeatmapId { get; set; }

        [QueryParameter("checksum")]
        public string Hash { get; set; }

        [QueryParameter("filename")]
        public string Filename
        {
            get => !string.IsNullOrEmpty(_filename) ? Uri.EscapeUriString(_filename) : null;
            set => _filename = value;
        }
    }
}
