using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtMuseumLibrary
{

    public class ArtPiece
    {
        #region Public Properties
        [JsonProperty("primaryImage")]
        public string PrimaryImage { get; set; }

        [JsonProperty("primaryImageSmall")]
        public string PrimaryImageSmall { get; set; }


        [JsonProperty("title")]
        public string Title { get; set; } = "Untitled";

        [JsonProperty("culture")]
        public string Culture { get; set; } = "Culture Unknown";           

        [JsonProperty("artistDisplayName")]
        public string ArtistDisplayName { get; set; } = "Artist Unknown";

        [JsonProperty("artistDisplayBio")]
        public string ArtistDisplayBio { get; set; } = "Artist Bio Unavailable";

        [JsonProperty("artistBeginDate")]
        public string ArtistBeginDate { get; set; } = "Info Unknown";

        [JsonProperty("artistEndDate")]
        public string ArtistEndDate { get; set; } = "Info Unknown";

        [JsonProperty("artistGender")]
        public string ArtistGender { get; set; } = "Gender Unavailable";

        [JsonProperty("artistWikidata_URL")]
        public string ArtistWikidataURL { get; set; } = "No Wikidata Available";

        [JsonProperty("objectURL")]
        public string ObjectURL { get; set; }
        
        [JsonProperty("objectDate")]
        public string ObjectDate { get; set; }

        [JsonProperty("creditLine")]
        public string CreditLine { get; set; } = "Ceditline Unknown";

        [JsonProperty("country")]
        public string Country { get; set; } = "Country Unknown";

        [JsonProperty("region")]
        public string Region { get; set; } = "Region Unknown";

        [JsonProperty("classification")]
        public string Classification { get; set; } = "Classification Unknown";

        [JsonProperty("rightsAndReproduction")]
        public string RightsAndReproduction { get; set; } = "Rights And Reproduction Unavailable";

        [JsonProperty("linkResource")]
        public string LinkResource { get; set; } = "Link Resource Unavailable";

        [JsonProperty("GalleryNumber")]
        public string GalleryNumber { get; set; }
        #endregion


    }


}
