﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imagenet
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Manager();
            m.CountImgs();

            Console.WriteLine("done.");
            Console.ReadLine();
        }
    }
}
