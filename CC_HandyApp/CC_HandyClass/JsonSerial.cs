using System;
using System.IO;
using System.Text.Json;

namespace CC_HandyClass
{
    public class JsonSerial<T>: ISerializeable<T>
    {
        public void Serialize(string path, T output)
        { 
            var options = new JsonSerializerOptions {
                WriteIndented = true,
            };
            var jsonString = JsonSerializer.Serialize(output, options);
            File.WriteAllText(path, jsonString);
        }

        public T Deserialize(string path)
        {
            var jsonString = File.ReadAllText(path);
            var result = JsonSerializer.Deserialize<T>(jsonString);
            return result;
        }
    }
}