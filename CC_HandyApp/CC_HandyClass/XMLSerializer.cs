using System.IO;
using System.Xml.Serialization;

namespace CC_HandyClass
{
    public class Xml<T>: ISerializable<T>
    {
        public void Serialize(string path, T output)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            serializer.Serialize(stream, output);
            stream.Close();
        }

        public T Deserialize(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var result = (T)serializer.Deserialize(stream);
            stream.Close();
            return result;
        }
    }
}