using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Animal_sounds
{
    internal abstract class animal
    {


        public abstract string name { get; set; }
        public abstract string sound { get; set; }

        public abstract void makesound();


    }
    class dog : animal
    {
        public override string name
        {
            get; set;

        }
        public override string sound
        {
            get; set;

        }
        public override void makesound()
        {
            Console.WriteLine($"{name} makes sound :{sound}");
        }

    }
    class bird : animal
    {
        public override string name
        {
            get;set;

        }
        public override string sound
        {
            get; set;

        }
        public override void makesound()
        {
            Console.WriteLine($"{name} makes sound :{sound}");
        }

    }
    class cat : animal
    {
        public override string name
        {
            get; set;
        }
        public override string sound
        {
            get; set;

        }
        public override void makesound()
        {
            Console.WriteLine($"{name} makes sound :{sound}");
        }

    }

}
