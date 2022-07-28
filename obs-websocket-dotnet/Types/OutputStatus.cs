using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OBSWebsocketDotNet.Types
{
    public class OutputStatus
    {
        // https://github.com/obsproject/obs-websocket/blob/master/docs/generated/protocol.md#getoutputstatus

        /// <summary>
        /// Whether the output is active
        /// </summary>
        [JsonProperty(PropertyName = "outputActive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Whether the output is reconnecting
        /// </summary>
        [JsonProperty(PropertyName = "outputReconnecting")]
        public bool IsReconnecting { get; set; }

        /// <summary>
        /// Time elapsed since output started (only present if output currently active)
        /// </summary>
        [JsonProperty(PropertyName = "outputTimecode")]
        public string Timecode { get; set; }

        /// <summary>
        /// Current duration in milliseconds for the output
        /// </summary>
        [JsonProperty(PropertyName = "outputDuration")]
        public UInt64 Duration { get; set; }

        /// <summary>
        /// Current congestion, between 0-1
        /// </summary>
        [JsonProperty(PropertyName = "outputCongestion")]
        public float Congestion { get; set; }

        /// <summary>
        /// Bytes sent
        /// </summary>
        [JsonProperty(PropertyName = "outputBytes")]
        public UInt64 Bytes { get; set; }

        /// <summary>
        /// Frames dropped
        /// </summary>
        [JsonProperty(PropertyName = "outputSkippedFrames")]
        public int FramesDropped { get; set; }

        /// <summary>
        /// Frames sent
        /// </summary>
        [JsonProperty(PropertyName = "outputTotalFrames")]
        public int TotalFrames { get; set; }

        /// <summary>
        /// Builds the object from the JSON response body
        /// </summary>
        /// <param name="data">JSON response body as a <see cref="JObject"/></param>
        public OutputStatus(JObject data)
        {
            JsonConvert.PopulateObject(data.ToString(), this);
        }

        /// <summary>
        /// Constructor for jsonconverter
        /// </summary>
        public OutputStatus()
        {
        }
    }
}
