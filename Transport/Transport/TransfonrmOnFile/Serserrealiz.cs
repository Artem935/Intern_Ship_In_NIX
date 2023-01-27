using System.Xml.Serialization;
using Transport.Models.Objects;
using Transport.DisplayConsole;

namespace Transport.Serserrealization
{
    internal class Serserrealiz<T>where T : class
    {
        public void SerserrealizationXML(string path, string fileName,T transport)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TransportList));
            using (FileStream fs = new FileStream($"{path}\\{fileName}.xaml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, transport);
                new DataVerification().Complete("Object has been serialized");
            }
        }
    }
}
