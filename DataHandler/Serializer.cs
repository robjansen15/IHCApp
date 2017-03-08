using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using DataHandler.Models;

namespace DataHandler
{
    public class Serializer<T>
    {
        public Serializer()
        {

        }


        public string Serialize(T obj)
        {
            string serializedString = string.Empty;

            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            using (StringWriter sw = new StringWriter())
            {
                serializer.Serialize(sw, obj);
                serializedString = sw.ToString();
            }

            return serializedString;
        }


        public T Deserialize(string serializedData, Type objType)
        {
            T deserializedObj = default(T);

            XmlSerializer deserializer = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(serializedData))
            {
                deserializedObj = (T)deserializer.Deserialize(tr);
            }

            return deserializedObj;
        }
    }
}