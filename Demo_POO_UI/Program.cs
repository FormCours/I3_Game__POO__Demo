using Demo_POO__Contructeur.Models;
using Demo_POO__Props_Indexeur.Models;

// ---Indexeur----------------------------------------------------------------
/*
Console.WriteLine("Hello, World!");

Charakter c = new Charakter();

c.Name = "Della"; // En interne -> c.set_Name("Della");
Console.WriteLine(c.Name);
*/

//---Constructeur-------------------------------------------------------------
Person p1 = new Person("Della", "Duck", new DateTime(1987, 7, 1));
Person p2 = new("Donald", "Duck", new DateTime(1987, 7, 1));

Person p3 = new Person("Picsou", new DateTime(1967, 12, 1));


Console.WriteLine($"Bonjour {p1.FirstName} {p1.LastName}");