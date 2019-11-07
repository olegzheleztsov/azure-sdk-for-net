// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource SKU location information.
    /// </summary>
    public partial class ResourceSkuLocationInfo
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSkuLocationInfo class.
        /// </summary>
        public ResourceSkuLocationInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceSkuLocationInfo class.
        /// </summary>
        /// <param name="location">Location where this SKU is
        /// available.</param>
        /// <param name="zones">Zones if any.</param>
        public ResourceSkuLocationInfo(string location = default(string), IList<string> zones = default(IList<string>))
        {
            Location = location;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets location where this SKU is available.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets zones if any.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

    }
}