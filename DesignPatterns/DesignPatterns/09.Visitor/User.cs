﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Visitor
{
    public class User : Leaf
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
