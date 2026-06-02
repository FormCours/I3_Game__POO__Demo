using System;
using System.Collections.Generic;
using System.Text;
using Demo_POO__Heritage.EnumCustom;

namespace Demo_POO__Heritage.Models
{
    public class Cat : Feline
    {
        public bool IsIndoor { get; set; }
        public bool WasStray { get; set; }
    }
}
