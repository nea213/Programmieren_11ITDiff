using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CC_HandyClass
{
    [Serializable()]
    public class Binary<T>: ISerializable<T>
    {
        public void Serialize(string path, T output)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, output);
            stream.Close();
        }

        public T Deserialize(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var result = (T)formatter.Deserialize(stream);
            stream.Close();
            return result;
        }
    }
}