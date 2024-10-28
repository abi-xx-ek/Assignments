using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dog dog = new dog();
            cat cat = new cat();
            bird bird = new bird();
            

            dog.makesound();
            cat.makesound();
            bird.makesound();
        }
    }
}
