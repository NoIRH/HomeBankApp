using HomeBankApp.Contexts;
using System.Diagnostics;
using System.Text.Json;

namespace HomeBankApp
{
    public static class JsonConverter
    {
        
        public static void Serialize(FileContext context, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                JsonSerializer.Serialize(fs, context);
            }
        }

        public static FileContext Deserialize(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                return JsonSerializer.Deserialize<FileContext>(fs);
            }
        }
    }
}
