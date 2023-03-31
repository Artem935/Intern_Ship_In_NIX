using System.Xml.Serialization;
using Transport.Models.Objects;
using Transport.DisplayConsole;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Transport.Serserrealization
{
    internal class Serrealiz<T>where T : class
    {
        public async Task SerrealizationXML(string path, string fileName,List<T> transport)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(transport.GetType());
            await using (FileStream fs = new FileStream($"{path}\\{fileName}.xaml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, transport);
                new DataVerification().Complete("Object has been serialized");
            }
        }
        public async Task SerrealizationTXT(string path,string fileName,List<T> transport) 
        {
            XmlSerializer xmlSerializer = new XmlSerializer(transport.GetType());
            await using(FileStream fs = new FileStream($"{path}\\{fileName}.txt", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, transport);
                new DataVerification().Complete("Object has been serialized");
            }
        }
    }
}
