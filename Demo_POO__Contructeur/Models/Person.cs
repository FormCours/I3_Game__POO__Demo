namespace Demo_POO__Contructeur.Models
{
    public class Person
    {
        // Propriété avec encapsulation
        public string? FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public int Age
        {
            get
            {
                int tempAge = DateTime.Today.Year - BirthDate.Year;
                
                if(DateTime.Today < BirthDate) {
                    tempAge--;
                }
                return tempAge;

                // return (DateTime.Today >= BirthDate) ? tempAge : tempAge - 1;
            }
        }

        // Constructeur
        // - Méthode utilisée lors de l'instanciation
        // - Elle porte le même nom que la classe
        // - Ne possede pas de parametre de retour (Il n'y a rien, pas de void !!!)
        public Person(string firstName, string lastName, DateTime birthDate)
            : this(lastName, birthDate) // Chainage de constructeur
        {
            this.FirstName = firstName;
        }

        // - Ca reste une méthode, la surcharge est autorisé évidement :D
        public Person(string lastName, DateTime birthDate)
        {
            this.FirstName = null;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }

    }
}
