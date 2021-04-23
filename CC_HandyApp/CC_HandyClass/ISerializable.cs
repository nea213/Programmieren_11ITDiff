using System;
using CC_HandyApp;

namespace CC_HandyClass
{
    public interface ISerializable<T>
    {
        public void Serialize(String path, T output);
        public T Deserialize(String path);
    }
}