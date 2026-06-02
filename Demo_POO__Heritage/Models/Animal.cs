namespace Demo_POO__Heritage.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }


        public void Sleep(int hours)
        {
            Console.WriteLine($"{Name} dort {hours} heures");
        }
        public void Eat(string meal)
        {
            Console.WriteLine($"{Name} mange {meal}");
        }
    }
}
