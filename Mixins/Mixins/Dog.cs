﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Mixins
{
    public class Dog
    {
        public virtual string name { get { return "Dog"; } }
    }
}
