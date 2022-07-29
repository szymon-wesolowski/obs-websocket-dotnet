﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Version info of the plugin, the API and OBS Studio
    /// </summary>
    public class OBSVersion
    {
        /// <summary>
        /// obs-websocket plugin version
        /// </summary>
        [JsonProperty(PropertyName = "obsWebSocketVersion")]
        public string PluginVersion { get; internal set; }

        /// <summary>
        /// OBS Studio version
        /// </summary>
        [JsonProperty(PropertyName = "obsVersion")]
        public string OBSStudioVersion { get; internal set; }

        /// <summary>
        /// OBSRemote compatible API version.Fixed to 1.1 for retrocompatibility.
        /// </summary>
        [JsonProperty(PropertyName = "rpcVersion")]
        public double Version { internal set; get; }

        /// <summary>
        /// List of available request types, formatted as a comma-separated list string (e.g. : "Method1,Method2,Method3").
        /// </summary>
        [JsonProperty(PropertyName = "availableRequests")]
        public string[] AvailableRequests { get; internal set; }

        /// <summary>
        /// Builds the object from the JSON response body
        /// </summary>
        /// <param name="data">JSON response body as a <see cref="JObject"/></param>
        public OBSVersion(JObject data)
        {
            JsonConvert.PopulateObject(data.ToString(), this);
        }

        /// <summary>
        /// Empty constructor for jsonconvert
        /// </summary>
        public OBSVersion() { }

    }
}