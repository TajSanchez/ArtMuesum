using ArtMuseumLibrary;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArtMuseum.MVC.Controllers
{
    public class ArtController : Controller
    {
        private const string BASE_URL = $"https://collectionapi.metmuseum.org/public/collection/v1/objects";
        //private const string ART_URL = $"https://www.metmuseum.org/art/collection/search";

        public IActionResult Index()
        {
            List<ArtPiece> artCollection = new List<ArtPiece>();

            BaseServiceCall baseServiceCall = new BaseServiceCall(new HttpClient());
            Random random = new Random();

            List<int> artIds = baseServiceCall.GetArtIds(BASE_URL);

            ArtPiece artPiece = new ArtPiece();

            int counter = 0;

            while (counter != 4)
            {
                while (string.IsNullOrEmpty(artPiece.PrimaryImageSmall) && string.IsNullOrWhiteSpace(artPiece.PrimaryImageSmall)) 
                {
                    var index = random.Next(artIds.Count);
                    var artUrl = $"{BASE_URL}/{artIds[index]}";

                    artPiece = baseServiceCall.GetArtPiece(artUrl);
                }

                artCollection.Add(artPiece);
                counter++;
                artPiece = new();
            }


            return View(artCollection);
        }
    }
}
