using Google.DAO;
using System.Text.Json;

namespace Google.Common
{
    public class Utils
    {
        public static Constant? ReadConstantInfoFromFile(string filePath)
        {
            string txt = File.ReadAllText(filePath);
            var constant = JsonSerializer.Deserialize<Constant>(txt);
            return constant;
        }       

    }
}
