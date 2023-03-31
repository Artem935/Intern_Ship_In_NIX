using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Serserrealization;

namespace Transport.TransfonrmOnFile
{
    internal interface ITransformOnFile<T> where T : class
    {
        public void Save(string path, List<T> transport, int type);
        public List<T> Load(string path, T transport);

    }
}
