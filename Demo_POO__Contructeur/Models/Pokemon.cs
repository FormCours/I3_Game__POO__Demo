namespace Demo_POO__Contructeur.Models
{
    public class Pokemon
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Pokemon(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
