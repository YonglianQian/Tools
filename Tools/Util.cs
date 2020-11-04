using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    public class Util
    {
       public string GetCurrentTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
