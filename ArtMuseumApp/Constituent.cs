using Newtonsoft.Json;

namespace ArtMuseumLibrary
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Constituent
    {
        [JsonProperty("constituentID")]
        public int ConstituentID { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("constituentULAN_URL")]
        public string ConstituentULANURL { get; set; }

        [JsonProperty("constituentWikidata_URL")]
        public string ConstituentWikidataURL { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }
    }


}
