﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordleConsole
{
    internal class sharedFuncs
    {
        
        public List<string> charArrayToStringList(string inputCharArray)
        {
            List<string> stringList = new List<string>();
            foreach (char c in inputCharArray.ToCharArray()) { stringList.Add(c.ToString()); }
            return stringList;
        }

    }
}
