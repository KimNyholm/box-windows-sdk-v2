﻿using Newtonsoft.Json;

namespace Box.V2.Models
{
    public class BoxItemRequest : BoxRequestEntity
    {

        /// <summary>
        /// The folder that contains this file
        /// </summary>
        [JsonProperty(PropertyName = "parent")]
        public BoxRequestEntity Parent { get; set; }

        /// <summary>
        /// The name of the file 
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The new description for the file
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// An object representing this item’s shared link and associated permissions
        /// </summary>
        [JsonProperty(PropertyName = "shared_link")]
        public BoxSharedLinkRequest SharedLink { get; set; }
    }
}
