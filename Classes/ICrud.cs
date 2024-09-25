using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devPOO.Classes
{
    internal interface ICrud
    {
        string Create();
        string Read();
        string Update();
        string Delete();
    }
}
