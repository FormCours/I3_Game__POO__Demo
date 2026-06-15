namespace Demo_POO__Abstract
{
    internal abstract class Forme
    {
        public string Couleur { get; set; }

        public abstract void Dessiner();
        // ↑ La méthode "Dessiner" existe sur toutes les formes
        //   Mais cette méthode DOIT être implémenté par une classe spécialisé
    }
}
