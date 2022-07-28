﻿namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Describes the state of an output (streaming or recording)
    /// </summary>
    public enum OutputState
    {
        /// <summary>
        /// The output is initializing and doesn't produces frames yet
        /// </summary>
        OBS_WEBSOCKET_OUTPUT_STARTING,

        /// <summary>
        /// The output is running and produces frames
        /// </summary>
        OBS_WEBSOCKET_OUTPUT_STARTED,

        /// <summary>
        /// The output is stopping and sends the last remaining frames in its buffer
        /// </summary>
        OBS_WEBSOCKET_OUTPUT_STOPPING,

        /// <summary>
        /// The output is completely stopped
        /// </summary>
        Stopped,
        //#TODO doc
        Reconnecting,
        //#TODO doc
        Paused,
        //#TODO doc
        Resumed,
        //#TODO doc
        Unknown
    }
}