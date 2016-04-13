using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB.Core
{
    class Utils
    {
        static public void Log(object obj)
        {
            Log(obj.ToString());
        }

        static public void Log(string text)
        {
            System.Diagnostics.Debug.WriteLine($"TOOLBOX DEBUG: {text}");
        }
    }
}
