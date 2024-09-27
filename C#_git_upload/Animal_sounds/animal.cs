using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animal_sounds
{
    internal class animal
    {
       

        public virtual string name{ get; set; }
        public string sound { get; set; }

        public virtual void makesound()
        {
            
        }

    }
    class dog : animal
    {
        public dog()
        {
            name = "Dog";
            sound = "Bark";

        }
        public override void makesound()
        {
            Console.WriteLine($"{name} makes sound :{sound}");
        }

    }
    class bird : animal 
    {
        public bird()
        {
            name = "Bird";
            sound = "Chirp";
            
        }
        public override void makesound()
        {
            Console.WriteLine($"{name} makes sound :{sound}");
        }

    }
    class cat : animal
    {
        public cat()
        {
            name = "cat";
            sound = "meow";

        }
        public override void makesound()
        {
            Console.WriteLine($"{name} makes sound :{sound}");
        }

    }

}
