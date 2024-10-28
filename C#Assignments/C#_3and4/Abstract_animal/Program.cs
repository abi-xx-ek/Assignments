using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_sounds
{
    public class Program
    {
        static void Main(string[] args)
        {
            dog dog = new dog();
            cat cat = new cat();
            bird bird = new bird();

            dog.name = "Dog";
            dog.sound = "bark";
            dog.makesound();

            cat.name = "cat";
            cat.sound = "meow";
            cat.makesound();

            bird.name = "bird";
            bird.sound = "chirp";
            bird.makesound();
        }
    }
}
