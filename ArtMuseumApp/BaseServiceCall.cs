using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtMuseumLibrary
{
    public class BaseServiceCall
    {
        private readonly HttpClient _client;

        public BaseServiceCall(HttpClient client)
        {
            _client = client;
        }

        private string GetJsonData(string url)
        {
            var artData = _client.GetStringAsync(url).Result;
            return artData;
        }

        public ArtPiece GetArtPiece(string url)
        {
            var jsonData = GetJsonData(url);           
            var artPiece = DeserializeArt(jsonData);
            return artPiece;
        }

        private ArtPiece DeserializeArt(string jsonData)
        {
            ArtPiece artPiece = JsonConvert.DeserializeObject<ArtPiece>(jsonData) ?? new ArtPiece();
            return artPiece;
        }
        
        private Collection DeserializeArtId(string jsonData)
        {
            Collection artIds = JsonConvert.DeserializeObject<Collection>(jsonData) ?? new Collection();
            return artIds;
        }

        public List<int> GetArtIds(string url)
        {
            var jsonData = GetJsonData(url);
            var collection = DeserializeArtId(jsonData);
            return collection.ArtIds;
        }
    }
}