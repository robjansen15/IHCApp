using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Xml.Serialization;


namespace TestConsoleApp
{
    public class Serializer<T>
    {
        public Serializer()
        {

        }


        public string Serialize(T obj)
        {
            string serializedString = string.Empty;

            //Create a stream to serialize the object to.  
            MemoryStream ms = new MemoryStream();

            // Serializer the User object to the stream.  
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            ser.WriteObject(ms, obj);
            byte[] json = ms.ToArray();
            ms.Close();
            serializedString = System.Text.Encoding.UTF8.GetString(json, 0, json.Length);

            return serializedString;
        }


        public T Deserialize(string serializedData, Type objType)
        {
            T deserializedObj = default(T);

            MemoryStream ms = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(serializedData));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(serializedData.GetType());
            deserializedObj = (T)ser.ReadObject(ms);
            ms.Close();

            return deserializedObj;
        }
    }
}