﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1N : IClass1
    {
        public void CreatePNR()
        {
            Console.WriteLine($"Create PNR {nameof(Class1N)}");
        }
    }
}