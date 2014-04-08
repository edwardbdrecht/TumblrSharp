using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DontPanic.TumblrSharp.Client
{
    public class TagMeta
    {
        public int status { get; set; }
        public string msg { get; set; }
    }

    public class Theme
    {
        public string link_color { get; set; }
        public string background_color { get; set; }
        public string title_color { get; set; }
        public string title_font { get; set; }
        public string title_font_weight { get; set; }
        public string body_font { get; set; }
        public string header_image { get; set; }
        public bool show_title { get; set; }
        public bool show_description { get; set; }
        public bool show_header_image { get; set; }
        public string avatar_shape { get; set; }
        public bool show_avatar { get; set; }
    }

    public class Blog
    {
        public string name { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public int updated { get; set; }
        public Theme theme { get; set; }
    }

    public class AltSize
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class OriginalSize
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Exif
    {
        public string Camera { get; set; }
        public int ISO { get; set; }
        public string Aperture { get; set; }
        public string Exposure { get; set; }
        public string FocalLength { get; set; }
    }

    public class SPhoto
    {
        public string caption { get; set; }
        public List<AltSize> alt_sizes { get; set; }
        public OriginalSize original_size { get; set; }
        public Exif exif { get; set; }
    }

    public class Post
    {
        public string blog_name { get; set; }
        public Blog blog { get; set; }
        public object id { get; set; }
        public string post_url { get; set; }
        public string slug { get; set; }
        public string type { get; set; }
        public string date { get; set; }
        public int timestamp { get; set; }
        public string state { get; set; }
        public string format { get; set; }
        public string reblog_key { get; set; }
        public List<object> tags { get; set; }
        public string short_url { get; set; }
        public List<string> featured_in_tag { get; set; }
        public List<object> highlighted { get; set; }
        public int note_count { get; set; }
        public string source_url { get; set; }
        public string source_title { get; set; }
        public string caption { get; set; }
        public string photoset_layout { get; set; }
        public List<SPhoto> photos { get; set; }
        public string image_permalink { get; set; }
        public string link_url { get; set; }
        public bool? bookmarklet { get; set; }
        public string text { get; set; }
        public string source { get; set; }
        public string post_author { get; set; }
    }

    public class Row
    {
        public string tag_name { get; set; }
        public List<Post> posts { get; set; }
    }

    public class TagDiscoveryInfo
    {
        public List<Row> rows { get; set; }
        public int total_tags { get; set; }
    }
}
