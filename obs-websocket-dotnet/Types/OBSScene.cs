using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Describes a scene in OBS, along with its items
    /// </summary>
    public class OBSScene
    {
        /// <summary>
        /// OBS Scene name
        /// </summary>
        [JsonProperty(PropertyName = "sceneName")]
        public string Name;

        /// <summary>
        /// Is group
        /// </summary>
        [JsonProperty(PropertyName = "isGroup")]
        public bool IsGroup;

        /// <summary>
        /// Scene item list
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public List<SceneItem> Items;

        /// <summary>
        /// Builds the object from the JSON description
        /// </summary>
        /// <param name="data">JSON scene description as a <see cref="JObject" /></param>
        public OBSScene(JObject data)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ObjectCreationHandling = ObjectCreationHandling.Auto,
                NullValueHandling = NullValueHandling.Include
            };
            JsonConvert.PopulateObject(data.ToString(), this, settings);
        }

        /// <summary>
        /// Default Constructor for deserialization
        /// </summary>
        public OBSScene() { }

        internal OBSWebsocket owningWebsocket;

        public static OBSScene CurrentProgramScene(OBSWebsocket socket)
        {
            return new OBSScene() { owningWebsocket = socket, Name = socket.GetCurrentProgramScene() };
        }

        public static OBSScene CurrentPreviewScene(OBSWebsocket socket)
        {
            return new OBSScene() { owningWebsocket = socket, Name = socket.GetCurrentPreviewScene() };
        }


        public SceneItem GetSceneItemByName(string sourceName)
        {
            try
            {
                return new SceneItem()
                {
                    owningWebsocket = owningWebsocket, SceneName = Name,
                    ID = (int) owningWebsocket.GetSceneItemId(Name, sourceName)
                };
            }
            catch (ErrorResponseException ex)
            {
                if (ex.ErrorCode == 600) // not found
                    return null;
                return null; // other error
            }


            
        }


    }
}