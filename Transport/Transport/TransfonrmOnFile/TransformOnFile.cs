using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Serserrealization;

namespace Transport.TransfonrmOnFile
{
    public class TransformOnFile<T>:ITransformOnFile<T> where T : class
    {
        public void Save(string path,List<T> transport,int type)
        {
            Serrealiz<T> serrealiz = new Serrealiz<T>();
            if (type == 1)
            {
                serrealiz.SerrealizationXML(path, transport[0].GetType().Name,transport);
            }
            else
                serrealiz.SerrealizationTXT(path, transport[0].GetType().Name, transport);
        }
        public List<T> Load(string path, T transport)
        {
            return new Deserrealiz<T>().DeserrealizationXML(path);
        }
    }
}
