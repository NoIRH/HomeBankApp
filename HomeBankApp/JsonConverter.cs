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
            var result = new FileContext();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate)) 
                    result = JsonSerializer.Deserialize<FileContext>(fs);
                
                return result;
            }
            catch(Exception e)
            {
                Serialize(new FileContext(), path);
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    result = JsonSerializer.Deserialize<FileContext>(fs);
                return result;
            }
                 
            
        }
    }
}
