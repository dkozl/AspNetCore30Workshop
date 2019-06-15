using Newtonsoft.Json;

namespace WorkshopApp.Models
{
    public class UserInfo
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string FullName { get; set; }

        [JsonProperty("html_url")]
        public string Url { get; set; }

        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
    }
}