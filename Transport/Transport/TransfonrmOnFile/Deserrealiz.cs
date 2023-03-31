using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Transport.Models.Objects;

namespace Transport.Serserrealization
{
    internal class Deserrealiz<T> where T : class
    {
        public List<T> DeserrealizationXML(string path)
        {
            List<T> list = new List<T>();
            XmlSerializer ser = new XmlSerializer(list.GetType());
            using (XmlReader reader = XmlReader.Create(path))
            {
                list = ser.Deserialize(reader) as List<T>;
            }
            return list;
        }
    }
}
