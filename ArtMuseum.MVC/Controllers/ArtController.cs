using ArtMuseumLibrary;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ArtMuseum.MVC.Controllers
{
    public class ArtController : Controller
    {
        private const string BASE_URL = $"https://collectionapi.metmuseum.org/public/collection/v1/objects";

        public IActionResult Index()
        {
            
            BaseServiceCall baseServiceCall = new BaseServiceCall(new HttpClient());
            Random random = new Random();

            List<int> artIds = baseServiceCall.GetArtIds(BASE_URL);

            int index = random.Next(artIds.Count);

            var artUrl = $"{BASE_URL}/{artIds[index]}";

            var artPiece = baseServiceCall.GetArtPiece(artUrl);
            return View(artPiece);
        }
    }
}
