﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixins
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dog dog = new Dog();
                Dog labrador = new Labrador();

                dog.Feed();
                labrador.Feed();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
