using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SwimBehavior
{
    internal class Float : SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("I can float!");
        }
    }
}