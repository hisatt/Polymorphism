﻿using System;
using System.Collections.Generic;
using System.Text;

namespace polymorphism
{
    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 9.5*12 ");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing.......");
        }
    }
}
