using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.N._8
{
    public interface ISQLite
    {
        string GetLocalFilePath(string filename);
    }
}
