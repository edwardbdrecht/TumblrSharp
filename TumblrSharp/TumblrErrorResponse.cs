using Newtonsoft.Json;

namespace DontPanic.TumblrSharp
{
    internal class TumblrErrorResponse
    {
        [JsonProperty(PropertyName = "errors")]
        public string[] Errors { get; set; }
    }
}
