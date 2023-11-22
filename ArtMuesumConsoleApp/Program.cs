using static System.Net.WebRequestMethods;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography.X509Certificates;
using ArtMuseumLibrary;
using Newtonsoft.Json;
using static ArtMuesumConsoleApp.ConsoleLogging;
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

            PassMessage("Welcome To The Metropolitan Museum of Art Collection!");
            BlankLine();
            PassMessage("This site will randomly generate a piece of art from our prestine collection, and give you details about your random selection.");
            BlankLine();
            PassMessage("Please give us a number of art pieces you would like to view. NOTE Some art pieces do NOT have complete data");
            BlankLine();
            int userResponse = int.Parse(Console.ReadLine());
            BlankLine();

           
            for (int i = 0; i < userResponse; i++)
            {
                int index = random.Next(artIds.Count);

                var artUrl = $"{BASE_URL}/{artIds[index]}";

                var artPiece = baseServiceCall.GetArtPiece(artUrl);

                PassMessage($"Image: {artPiece.PrimaryImageSmall}");
                PassMessage($"Title: {artPiece.Title}");
                PassMessage($"Artist Name: {artPiece.ArtistDisplayName}");
                PassMessage($"Bio: {artPiece.ArtistDisplayBio}");
                PassMessage($"Art Start Year: {artPiece.ArtistBeginDate}");
                PassMessage($"Art Completion Year: {artPiece.ArtistEndDate}");
                PassMessage($"Art URL: {artPiece.ObjectURL}");
                PassMessage($"Art WikiData: {artPiece.ArtistWikidataURL}");
                PassMessage($"Art Region: {artPiece.Region}");
                PassMessage($"Art Country: {artPiece.Country}");
                PassMessage($"Art Culture: {artPiece.Culture}");
                BlankLine();
                PassMessage("---------------------------------------");
                BlankLine();
            }
        }
    }
}


