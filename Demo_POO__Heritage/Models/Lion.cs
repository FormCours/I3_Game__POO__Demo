using Demo_POO__Heritage.EnumCustom;

namespace Demo_POO__Heritage.Models
{
    public class Lion : Feline
    {
        public double ManeSize { get; set; }

        public override void SharpenClaws()
        {
            Console.WriteLine($"{Name} a démolie le salon");
        }
    }
}
