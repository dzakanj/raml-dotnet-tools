﻿
// This code was generated by RAML Web Api 2 Scaffolder

using System;
using System.Collections.Generic;
using RAML.WebApiExplorer.Tests.Types;

namespace RAML.WebApiExplorer.Tests.Types
{
    public partial class SearchGetResponse
    {
        
        public Attributes Attributes { get; set; }
        public BoundingBox Bounding_box { get; set; }
        public ContainedWithin[] Contained_within { get; set; }
        public string Country_code { get; set; }
        public string Country { get; set; }
        public string Full_name { get; set; }
        public Geometry Geometry { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Place_type { get; set; }
        public string[] Polylines { get; set; }
        public string Url { get; set; }
    } // end class

} // end Objects namespace