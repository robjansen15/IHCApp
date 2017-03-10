using System;
using Newtonsoft.Json;

namespace UserWebApp
{
    public class Serializer<T>
    {
        public string Serialize(T obj)
        {
            string serializedString = JsonConvert.SerializeObject(obj);
            return serializedString;
        }


        public T Deserialize(string serializedData)
        {
            T deserializedObj = JsonConvert.DeserializeObject<T>(serializedData);
            return deserializedObj;
        }
    }
}