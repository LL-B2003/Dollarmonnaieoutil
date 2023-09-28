// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;

{
    string type_monnaie = "";
    string type_monnaie_cad = "CAD";
    string type_monnaie_usd = "USD";
    string montant_str = "";
    double montant = 0;
    double taux_usd = 1.36;
    double taux_cad = 0.74;

    while (type_monnaie != type_monnaie_cad && type_monnaie != type_monnaie_usd)
    {
        Console.WriteLine(string.Format("Type de monnaie vise ({0}=Canadien ou {1}=americain x=sortir)", type_monnaie_cad, type_monnaie_usd));
        type_monnaie = Console.ReadLine();
        type_monnaie = type_monnaie.ToUpper();

        if (type_monnaie == "X")
        {
            return;
        }

        if (type_monnaie != type_monnaie_cad && type_monnaie != type_monnaie_usd)
        {
            Console.WriteLine("Vous devez saisir un type de monnaie valide");
        }
    }

    while (montant == 0)
    {
        Console.WriteLine("Veuiller saisir le montant");
        montant_str = Console.ReadLine();

        if (montant_str.ToUpper() == "X")
        {
            return;
        }
        montant_str = montant_str.Replace(".", ",");
        double.TryParse(montant_str, out montant);
        if (montant == 0)
        {
            Console.WriteLine("Vous devez saisir un montant valide");
        }
    }

    if (type_monnaie == type_monnaie_cad)
    {
        Console.WriteLine(string.Format("Conversion CAD a USD : {0}$ {1}", montant * taux_usd,type_monnaie));
    }
    else
    {
        Console.WriteLine(string.Format("Conversion USD a CAD : {0}$ {1}", montant * taux_cad,type_monnaie));
    }



    Console.WriteLine("");
    Console.WriteLine("Appuyer une touche pour fermer");
    Console.ReadKey();


}