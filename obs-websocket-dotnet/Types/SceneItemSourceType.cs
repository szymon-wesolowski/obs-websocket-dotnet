namespace OBSWebsocketDotNet.Types
{
    // https://obsproject.com/docs/reference-sources.html#c.obs_source_get_type

    /// <summary>
    /// Type of scene item's source
    /// </summary>
    public enum SceneItemSourceType
    {
        /// <summary>
        /// Input
        /// </summary>
        OBS_SOURCE_TYPE_INPUT,

        /// <summary>
        /// Filter
        /// </summary>
        OBS_SOURCE_TYPE_FILTER,

        /// <summary>
        /// Transition
        /// </summary>
        OBS_SOURCE_TYPE_TRANSITION,

        /// <summary>
        /// Scene
        /// </summary>
        OBS_SOURCE_TYPE_SCENE
    }
}
