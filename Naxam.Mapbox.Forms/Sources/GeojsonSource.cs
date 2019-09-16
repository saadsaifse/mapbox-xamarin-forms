﻿using GeoJSON.Net.Feature;

namespace Naxam.Mapbox.Sources
{
    public class GeoJsonSource : Source
    {
        public bool IsLocal { get; set; }

        public string Url { get; set; }

        public FeatureCollection Data { get; set; }

        public GeoJsonOptions Options { get; set; }
    }

    public class GeoJsonOptions
    {
        public int? MinZoom { get; set; }
        public int? MaxZoom { get; set; }
        public int? Buffer { get; set; }
        public bool? LineMetrics { get; set; }
        public float? Tolerance { get; set; }
        public bool? Cluster { get; set; }
        public int? ClusterMaxZoom { get; set; }
        public int? ClusterRadius { get; set; }
    }
}