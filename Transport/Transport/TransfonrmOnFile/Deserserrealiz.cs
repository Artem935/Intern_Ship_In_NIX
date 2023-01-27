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
    internal class Deserserrealiz<T> where T : class
    {
        public T DeserserrealizationXML(string path,T transport)
        {
            XmlSerializer ser = new XmlSerializer(typeof(TransportList));

            using (XmlReader reader = XmlReader.Create(path))
            {
                transport = ser.Deserialize(reader) as T;
            }
            return transport;
        }
    }
}
