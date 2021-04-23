namespace CC_HandyClass
{
    using System.IO;
    using ServiceStack.Text;

    public class CsvSerializer<T>: ISerializable<T>
    {
        public void Serialize(string path, T output)
        {
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
            CsvSerializer.SerializeToStream(output, stream);
            stream.Close();
        }

        public T Deserialize(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            var a = CsvSerializer.DeserializeFromStream<T>(stream);
            stream.Close();
            return a;
        }
    }
}