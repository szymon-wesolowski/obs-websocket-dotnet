using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Settings for a source item
    /// </summary>
    public class SourceSettings
    {
        /// <summary>
        /// Name of the source
        /// </summary>
        [JsonProperty(PropertyName = "inputName")]
        public string SourceName { set; get; }

        /// <summary>
        /// Kind of source
        /// </summary>
        [JsonProperty(PropertyName = "inputKind")]
        public string SourceKind { set; get; }

        /// <summary>
        /// Settings for the source
        /// </summary>
        [JsonProperty(PropertyName = "inputSettings")]
        public JObject Settings { set; get; }

        /// <summary>
        /// Builds the object from the JSON data
        /// </summary>
        /// <param name="data">JSON item description as a <see cref="JObject"/></param>
        public SourceSettings(string sourceName, JObject data)
        {
            SourceName = sourceName;
            JsonConvert.PopulateObject(data.ToString(), this);
        }

        /// <summary>
        /// Default Constructor for deserialization
        /// </summary>
        public SourceSettings() { }
    }
}