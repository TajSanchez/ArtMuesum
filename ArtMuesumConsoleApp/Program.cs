using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using ArtMuseumLibrary;
using Newtonsoft.Json;

namespace ArtMuesumConsoleApp
{
    public class Program
    {
       private const string BASE_URL = $"https://collectionapi.metmuseum.org/public/collection/v1/objects";
        static void Main(string[] args)
        {
            BaseServiceCall baseServiceCall = new BaseServiceCall(new HttpClient());
            Random random = new Random();

            List<int> artIds = baseServiceCall.GetArtIds(BASE_URL);

            Console.WriteLine("Welcome To The Metropolitan Museum of Art Collection!");
            Console.WriteLine();
            Console.WriteLine("This site will randomly generate a piece of art from our prestine collection, and give you details about your random selection.");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(artIds.Count);

                var artUrl = $"{BASE_URL}/{artIds[index]}";

                var artPiece = baseServiceCall.GetArtPiece(artUrl);



                Console.WriteLine($"Image: {artPiece.PrimaryImage}");
                Console.WriteLine($"Title: {artPiece.Title}");
                Console.WriteLine($"Artist Name: {artPiece.ArtistDisplayName}");
                Console.WriteLine($"Bio: {artPiece.ArtistDisplayBio}");
                Console.WriteLine($"Art Start Year: {artPiece.ArtistBeginDate}");
                Console.WriteLine($"Art Completion Year: {artPiece.ArtistEndDate}");
                Console.WriteLine($"Art WikiData: {artPiece.ArtistWikidataURL}");
                Console.WriteLine($"Art Region: {artPiece.Region}");
                Console.WriteLine($"Art Culture: {artPiece.Culture}");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
            }




        }
    }
}


