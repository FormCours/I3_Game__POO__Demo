using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_POO__Props_Indexeur.Models
{
    public class Charakter
    {
        // Champs (Donnée brute -> Variable dans la RAM)
        private string _Name;
        private List<Ausstattung> AusstattungListe;


        // Encapsuler (Méthode : Getter/Setter)
        /* Exemple de méthode "caché" derniere les props
        public void SetName(string value)
        {
            _Name = value;
        }
        public string GetName()
        {
            return _Name;
        }
        */

        // - Propriétées
        public string Name
        {
            get { return _Name; }
            set { _Name = value.ToUpper(); }
        }
        public int Lebenspunkt { get; set; }
        public string CharakterKlasse { get; set; }
        public double MaximalGewicht { get; set; }

        // - Indexeurs

        public List<Ausstattung> this[string kategorie]
        {
            get
            {
                List<Ausstattung> ausstattungGefunden = [];
                foreach (Ausstattung ausstattung in AusstattungListe)
                {
                    if (ausstattung.Kategorie == kategorie)
                    {
                        ausstattungGefunden.Add(ausstattung);
                    }
                }
                return ausstattungGefunden;
            }
        }
        // Charakter c = new Charakter();
        // var eq = c["botte"];
        // var eq = c.GetAusstattungByKategorie("Botte")
        public List<Ausstattung> GetAusstattungByKategorie(string kategorie)
        {
            List<Ausstattung> ausstattungGefunden = [];
            foreach (Ausstattung ausstattung in AusstattungListe)
            {
                if (ausstattung.Kategorie == kategorie)
                {
                    ausstattungGefunden.Add(ausstattung);
                }
            }
            return ausstattungGefunden;
        }

    }
}
