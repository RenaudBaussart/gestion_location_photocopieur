using Application_entreprise_photocopieur.Classes;

#region Function
void Menu(string choixDeMenu)
{
    switch (choixDeMenu)
    {
        case "Principale":
            Console.Clear();
            Console.Write("====|Menu principale|====\n\n" +
                "[1] Ajout client\n" +
                "[2] List des Client\n" +
                "[3] Ajout technicien\n" +
                "[4] List des technicien\n" +
                "[5] Ajout Photocopieur\n" +
                "[6] List des Photocopieur\n" +
                "-------------------------\nSaisie:");
            break;
        #region Ajout de Client
        case "ajoutClientTitre":
            Console.Clear();
            Console.WriteLine("====|Ajout de client|====\n");
            break;
        case "ajoutNomPrenon":
            Console.Write("Entrée le nom Suivie du prénon en les separent d'un espace\nSaisie:");
            break;
        case "ajoutClientVille":
            Console.Write("Entrée la ville\nSaisie:");
            break;
        case "ajoutClientDepartement":
            Console.Write("Entrée le Numero de departement\nSaisie:");
            break;
        case "ajoutClientRue":
            Console.Write("Entrée Rue\nSaisie:");
            break;
        case "ajoutClientNumeroRue":
            Console.Write("Entrée le Numero de Rue\nSaisie:");
            break;
        #endregion
        #region Ajout de Technicien
        case "ajoutTechTitre":
            Console.Clear();
            Console.WriteLine("====|Ajout de technicien|====\n");
            break;
        case "ajoutTechDepartementAction":
            Console.Write("Entrée le departement d'action du technicien\nSaisie:");
            break;
        #endregion
        #region Photocopieur
        case "ajoutPhotocopieurTitre":
            Console.Clear();
            Console.WriteLine("====|Ajout de photocopieur|====\n");
            break;
        case "ajoutPhotocopieurMarque":
            Console.Write("Entrée la marque du Photocopieur\nSaisie:");
            break;
        case "ajoutPhotocopieurModel":
            Console.Write("Entrée le model du photocopieur\nSaisie:");
            break;
        #endregion
    }
}
ClientDeEntreprise AjoutDeClient() 
{
    
    string entreeDeDenomination;
    string nom;
    string prenom;
    string ville;
    string rue;
    int numeroDeRue;
    int departement;
    restartAjoutClient:
    Menu("ajoutClientTitre");
    restartNomPrenom:
    Menu("ajoutNomPrenon");
    entreeDeDenomination = Console.ReadLine();
    if(entreeDeDenomination != null || entreeDeDenomination != "")
    {
        try
        {
            List<string> splitedNomPrenom = new List<string>(entreeDeDenomination.Split(" "));
            nom = splitedNomPrenom[0];
            prenom = splitedNomPrenom[1];
        }
        catch (Exception)
        {
            Console.WriteLine("Erreur:Syntax incorrect");
            goto restartNomPrenom;
        }
    }
    else
    {
        Console.WriteLine("Erreur:Entrée une valeur");
        goto restartNomPrenom;
    }

    restartDepartement:
    Menu("ajoutClientDepartement");
    bool departementCorrect = int.TryParse(Console.ReadLine(), out departement);
    if(!departementCorrect || departement > 989)
    {
        Console.WriteLine("Erreur:Entée une Numero de departement max 989");
        goto restartDepartement;
    }

    restartVille:
    Menu("ajoutClientVille");
    ville = Console.ReadLine();
    if(ville == null || ville == "")
    {
        Console.WriteLine("Erreur:Entée une valeur");
        goto restartVille;
    }

    restartRue:
    Menu("ajoutClientRue");
    rue = Console.ReadLine(); ;
    if(rue == null || rue == "")
    {
        Console.WriteLine("Erreur:Entée une valeur");
        goto restartRue;
    }

    restartNumeroRue:
    Menu("ajoutClientNumeroRue");
    bool numeroRueCorrect = int.TryParse(Console.ReadLine(),out numeroDeRue);
    if (!numeroRueCorrect)
    {
        Console.WriteLine("Erreur:Entée une Numero");
        goto restartNumeroRue;
    }
    ClientDeEntreprise clientRetourFonction = new ClientDeEntreprise(nom,prenom,ville,rue,numeroDeRue,departement,null);
    Console.Clear();
    restartValidationCreation:
    Console.Write($"Confirmer vous la creation de\n" +
        $"nom:{clientRetourFonction.Nom}\n" +
        $"Prenom:{clientRetourFonction.Prenom}\n" +
        $"Adress:{clientRetourFonction.NumeroDeRue} Rue {clientRetourFonction.Rue} {clientRetourFonction.Ville} {clientRetourFonction.Departement}\n" +
        "oui / non:");
    switch(Console.ReadLine())
    {
        case "oui":
            Console.WriteLine("Creation confirmer!");
            Console.ReadKey();
            return clientRetourFonction;
        case "non":
            Console.WriteLine("Creation annuler!");
            Console.ReadKey();
            goto restartAjoutClient;
        default:
            Console.WriteLine("Erreur: entrée invalide");
            Console.ReadKey();
            goto restartValidationCreation;
    }






}
void AfficheClientList(List<ClientDeEntreprise> listClientEntree)
{
    for (int i = 0; i < listClientEntree.Count; i++)
    {
        Console.WriteLine("------------------------------------\n" +
                          $"Client n°:{listClientEntree[i].Id}\n" +
                          $"nom:{listClientEntree[i].Nom}\n" +
                          $"Prenom:{listClientEntree[i].Prenom}\n" +
                          $"Adress:{listClientEntree[i].NumeroDeRue} Rue {listClientEntree[i].Rue} {listClientEntree[i].Ville} {listClientEntree[i].Departement}\n" +
                          "------------------------------------\n");
    }
    Console.WriteLine("Appuyer sur un touche pour revenir au menu");
    Console.ReadKey();
}
Technicien AjoutTechnicien()
{
    string entreeDeDenomination;
    string nom;
    string prenom;
    int departementAction;
    restartAjoutTechnicien:
    Menu("ajoutTechTitre");
    restartNomPrenom:
    Menu("ajoutNomPrenon");
    entreeDeDenomination = Console.ReadLine();
    if (entreeDeDenomination != null || entreeDeDenomination != "")
    {
        try
        {
            List<string> splitedNomPrenom = new List<string>(entreeDeDenomination.Split(" "));
            nom = splitedNomPrenom[0];
            prenom = splitedNomPrenom[1];
        }
        catch (Exception)
        {
            Console.WriteLine("Erreur:Syntax incorrect");
            goto restartNomPrenom;
        }
    }
    else
    {
        Console.WriteLine("Erreur:Entrée une valeur");
        goto restartNomPrenom;
    }
    restartDepartement:
    Menu("ajoutTechDepartementAction");
    bool departementCorrect = int.TryParse(Console.ReadLine(), out departementAction);
    if (!departementCorrect || departementAction > 989)
    {
        Console.WriteLine("Erreur:Entée une Numero de departement max 989");
        goto restartDepartement;
    }
    Technicien technicienRetourFonction = new Technicien(nom,prenom,departementAction);
    restartValidationCreation:
    Console.Write($"Confirmer la creation de\n" +
        $"Nom:{technicienRetourFonction.Nom}\n" +
        $"Prenom:{technicienRetourFonction.Prenom}\n" +
        $"Departement Action:{technicienRetourFonction.DepartementAction}\noui / non:");
    switch (Console.ReadLine())
    {
        case "oui":
            Console.WriteLine("Creation confirmer!");
            Console.ReadKey();
            return technicienRetourFonction;
        case "non":
            Console.WriteLine("Creation annuler!");
            Console.ReadKey();
            goto restartAjoutTechnicien;
        default:
            Console.WriteLine("Erreur: entrée invalide");
            Console.ReadKey();
            goto restartValidationCreation;
    }



}
void AfficheTechnicienList(List<Technicien> listTechnicienEntree)
{
    for (int i = 0; i < listTechnicienEntree.Count; i++)
    {
        Console.WriteLine("------------------------------------\n" +
                          $"Technicien n°:{listTechnicienEntree[i].Id}\n" +
                          $"nom:{listTechnicienEntree[i].Nom}\n" +
                          $"Prenom:{listTechnicienEntree[i].Prenom}\n" +
                          $"Departement action:{listTechnicienEntree[i].DepartementAction}\n" +
                          $"------------------------------------\n");
    }
    Console.WriteLine("Appuyer sur un touche pour revenir au menu");
    Console.ReadKey();
}
Photocopieur AjoutPhotocopieur()
{
    string model,
           marque;
    restartAjoutPhotocopieur:
    Menu("ajoutPhotocopieurTitre");
    restartChoixMarque:
    Menu("ajoutPhotocopieurMarque");
    marque = Console.ReadLine();
    if (marque == null || marque == "")
    {
        Console.WriteLine("Erreur:Entrée une valeur");
        goto restartChoixMarque;
    }
    restartChoixModel:
    Menu("ajoutPhotocopieurModel");
    model = Console.ReadLine();
    if (model == null || model == "")
    {
        Console.WriteLine("Erreur:Entrée une valeur");
        goto restartChoixModel;
    }
    restartValidationCreation:
    Photocopieur photocopieurRetour = new Photocopieur(marque,model);
    Console.Write($"Confirmer l'ajout d'un photocopieur\n" +
                      $"marque:{photocopieurRetour.Marque}\n" +
                      $"model: {photocopieurRetour.Model}\n" +
                      $"oui / non:");
    switch (Console.ReadLine())
    {
        case "oui":
            Console.WriteLine("Creation confirmer!");
            Console.ReadKey();
            return photocopieurRetour;
        case "non":
            Console.WriteLine("Creation annuler!");
            Console.ReadKey();
            goto restartAjoutPhotocopieur;
        default:
            Console.WriteLine("Erreur: entrée invalide");
            Console.ReadKey();
            goto restartValidationCreation;
    }
}
void AffichePhotocopieurList(List<Photocopieur> listPhototcopieurEntree)
{
    for (int i = 0; i < listPhototcopieurEntree.Count; i++)
    {
        Console.WriteLine("------------------------------------\n" +
                          $"Photocopieur n°:{listPhototcopieurEntree[i].Id}\n" +
                          $"Marque:{listPhototcopieurEntree[i].Marque}\n" +
                          $"Model:{listPhototcopieurEntree[i].Model}\n" +
                          $"------------------------------------\n");
    }
    Console.WriteLine("Appuyer sur un touche pour revenir au menu");
    Console.ReadKey();
}

#endregion
bool applicationFonctione = true;
List<ClientDeEntreprise> listDesClient = new List<ClientDeEntreprise>();
listDesClient.Add(new ClientDeEntreprise("Robert", "Quill", "CityTown", "RoadPath", 345, 23, null));
List<Technicien> listDesTechnicien = new List<Technicien>();
listDesTechnicien.Add(new Technicien("heo", "Lienne", 23));
List<Photocopieur> listDesPhotocopieur = new List<Photocopieur>();
listDesPhotocopieur.Add(new Photocopieur("NVIDIA", "RTX 3050"));
while (applicationFonctione)
{
    Menu("Principale");
    switch (Console.ReadLine())
    {
        case "1":
            listDesClient.Add(AjoutDeClient());
            break;
        case "2":
            AfficheClientList(listDesClient);
            break;
        case "3":
            listDesTechnicien.Add(AjoutTechnicien());
            break; 
        case "4":
            AfficheTechnicienList(listDesTechnicien);
            break;
        case "5":
            listDesPhotocopieur.Add(AjoutPhotocopieur());
            break;
        case "6":
            AffichePhotocopieurList(listDesPhotocopieur);
            break;
    }
}


