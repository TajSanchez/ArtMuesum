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

        private async Task<string> GetJsonData(string url)
        {
            var artData = await _client.GetStringAsync(url);
            return artData;
        }

        public ArtPiece GetArtPiece(string url)
        {
            var jsonData = GetJsonData(url);           
            var artPiece = DeserializeArt(jsonData.Result);
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
            var collection = DeserializeArtId(jsonData.Result);
            return collection.ArtIds;
        }
    }
}