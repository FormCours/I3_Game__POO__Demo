namespace Demo_POO__Heritage.Models
{
    public class Dog : Animal
    {
        public string Race { get; set; }
        public string Color { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsTrained { get; set; }
    }
}
