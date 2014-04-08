using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontPanic.TumblrSharp.Client
{
    public class Note
    {
        [JsonProperty(PropertyName = "timestamp")]
        public string timestamp { get; set; }

        [JsonProperty(PropertyName = "blog_name")]
        public string blog_name { get; set; }

        [JsonProperty(PropertyName = "blog_url")]
        public string blog_url { get; set; }

        [JsonProperty(PropertyName = "added_text")]
        public string added_text { get; set; }

        [JsonProperty(PropertyName = "post_id")]
        public string post_id { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string type { get; set; }
    }
}
