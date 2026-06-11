namespace Demo_POO__Contructeur.Models
{
    public class Trainer : Person
    {
        public List<Pokemon> Pokemons { get; private set; }
        public string? Title { get; private set; }

        public Trainer(string firstName, string lastName, string title, DateTime birthDate)
            : base(firstName, lastName, birthDate) // Chainage avec la classe parent :o
        { 
            Pokemons = [];
            Title = title;
        }

    }
}
