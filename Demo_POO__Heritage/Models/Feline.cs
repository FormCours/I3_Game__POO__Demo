using System;
using System.Collections.Generic;
using System.Text;
using Demo_POO__Heritage.EnumCustom;

namespace Demo_POO__Heritage.Models
{
    public class Feline : Animal
    {
        public CoatTypeEnum CoatType { get; set; }
        public bool IsFriendly { get; set; }

        public virtual void SharpenClaws()
        {
            Console.WriteLine($"{Name} fait ses griffes");
        }
    }
}
