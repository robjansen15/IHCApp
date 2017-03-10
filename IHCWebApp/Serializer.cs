using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using UserWebApp.Models;

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