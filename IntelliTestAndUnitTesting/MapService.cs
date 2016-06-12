using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;

namespace IntelliTestAndUnitTesting
{
    public class MapService
    {
        public void GetMapImage(string filename, double lat, double lng)
        {
            var key = ConfigurationManager.AppSettings["bingMapsKey"];

            var uri =
                $"http://dev.virtualearth.net/REST/v1/Imagery/Map/Road/{lat},{lng}/15?mapSize=500,500&pp=47.620495,-122.34931;21;AA&pp=47.619385,-122.351485;;AB&pp=47.616295,-122.3556;22&mapMetadata=0&o=xml&key={key}";

            var request = WebRequest.CreateHttp(uri);

            var response = request.GetResponse();

            var stream = response.GetResponseStream();

            var image = Image.FromStream(stream);

            if (File.Exists(filename))
                File.Delete(filename);

            // make sure directory exists
            image.Save(filename, ImageFormat.Jpeg);
        }
    }
}