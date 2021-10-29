using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Moraba.Images.Webp
{
    class Helper
    {
        public static async Task<Stream> DownloadImageAsync(string imageUrl) => await new HttpClient().GetStreamAsync(imageUrl);

        public static byte[] ReadByte(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using MemoryStream ms = new();
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                ms.Write(buffer, 0, read);
            return ms.ToArray();
        }
    }
}
