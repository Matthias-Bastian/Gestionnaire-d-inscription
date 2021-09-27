using System;

namespace Activite
{
    class Program
    {
        static class Tableau
        {

            public static string[,] Activite = new string[20, 5];
            public static string[,] Participant = new string[20, 5];
            public static int[,] Gestion_Activite = new int[20, 20];



        }

        static string Menu()
        {
            //Choix du Menu
            Console.WriteLine("Que voulez vous faire");
            Console.WriteLine("1 - Afficher les activite");
            Console.WriteLine("2 - Afficher les Utilisateur");
            Console.WriteLine("3 - Ajouter Activite");
            Console.WriteLine("4 - Ajouter Utilisateur");
            Console.WriteLine("5 - Afficher le gestionnaire d'activite ");
            Console.WriteLine("6 - Ajouter un utilisateur à une activite ");
            Console.WriteLine("7 - Information utilisateur ");
            Console.WriteLine("8 - Supprimer ");
            Console.WriteLine("9 - Quitter ");
            Console.WriteLine();

            string Choix = Console.ReadLine();
            Console.WriteLine();


            return Choix;
        }
        static void Afficher_Activite(string[,] Activite)
        {
            /* i et j sont des compteur */
            int i, j;

            /* Affiche la valeur de chaque élément du tableau Activite */
            for (i = 0; i < 20; i++)
            {
                if (Tableau.Activite[i, 1] != null)
                {
                    Console.Write(i + "  ");
                }
                for (j = 0; j < 5; j++)
                {
                    Console.Write(Activite[i, j]);
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
        static void Afficher_Participant(string[,] Participant)
        {
            /* i et j sont des compteur */
            int i, j;

            /* Affiche la valeur de chaque élément du tableau Participant */
            for (i = 0; i < 20; i++)
            {
                if (Tableau.Participant[i, 1] != null)
                {
                    Console.Write(i + "  ");
                }
                for (j = 0; j < 5; j++)
                {
                    Console.Write(Participant[i, j]);
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
        static void Ajouter_Activite(string[,] _2, int x)
        {
            string Reponse;
            Console.WriteLine("Veuillez saisir un libellé");
            Reponse = Console.ReadLine();
            Tableau.Activite[x, 0] = Reponse + "           ";
            Console.WriteLine("Veuillez saisir un organisateur");
            Reponse = Console.ReadLine();
            Tableau.Activite[x, 1] = Reponse + "           ";
            Console.WriteLine("Veuillez saisir un lieux");
            Reponse = Console.ReadLine();
            Tableau.Activite[x, 2] = Reponse + "           ";
            Console.WriteLine("Veuillez saisir une date");
            Reponse = Console.ReadLine();
            Tableau.Activite[x, 3] = Reponse + "             ";
            Console.WriteLine("Veuillez saisir un prix");
            Reponse = Console.ReadLine();
            Tableau.Activite[x, 4] = Reponse;

        }
        static void Ajouter_Utilisateur(string[,] _2, int y)
        {
            string Reponse;
            Console.WriteLine("Veuillez saisir un nom");
            Reponse = Console.ReadLine();
            Tableau.Participant[y, 0] = Reponse + "          ";
            Console.WriteLine("Veuillez saisir un prenom");
            Reponse = Console.ReadLine();
            Tableau.Participant[y, 1] = Reponse + "          ";
            Console.WriteLine("Veuillez saisir un mails");
            Reponse = Console.ReadLine();
            Tableau.Participant[y, 2] = Reponse + "          ";
            Console.WriteLine("Veuillez saisir un date d'inscription");
            Reponse = Console.ReadLine();
            Tableau.Participant[y, 3] = Reponse + "          ";
            Console.WriteLine("Veuillez saisir un mot de passe");
            Reponse = Console.ReadLine();
            Tableau.Participant[y, 4] = Reponse;

        }
        static void Afficher_Gestion_Activite(int[,] _1)
        {
            /* i et j sont des compteur */
            int i, j,temp;

            /* Affiche la valeur de chaque élément du tableau Participant */
            for (i = 0; i < 20; i++)
            {
                temp = 0;
                int p1;
                j = 1;

                if (Tableau.Gestion_Activite[i, 0] != -1)
                {
                    Console.Write(Tableau.Gestion_Activite[i, 0] + "  ///  ");
                }
                else {
                }
                while (Tableau.Gestion_Activite[i, j] != -1)
                {
                    if (temp == 0)
                    {
                        Console.Write(Tableau.Activite[i+1, 0]+"      ");
                        temp = 1;
                    }
                    p1 = Tableau.Gestion_Activite[i, j];
                    Console.Write(Tableau.Participant[p1, 0] + Tableau.Participant[p1, 1]+" , " );
                    Console.Write("   ");

                    j = j + 1;
                }

                Console.WriteLine();
            }
        }
        static void Ajouter_Participant_Activite(int[,] _1)
        {
            /* ------------------- */
            /* Choisir l'activité */

            Console.WriteLine("Veuilliez choisir un numéro d'activité");

            Afficher_Activite(Tableau.Activite);
            int Activite;
            Activite = int.Parse(Console.ReadLine());

            /* ---------------------- */
            /* Choisir un Participant */

            Console.WriteLine("Veuilliez choisir un numéro de particicpant");

            Afficher_Activite(Tableau.Participant);
            int Participant;
            Participant = int.Parse(Console.ReadLine());

            for(int j = 1; j<20; j++)
            {
                if(Tableau.Gestion_Activite[Activite, j] == -1)
                {
                    Tableau.Gestion_Activite[Activite, 0] = Activite;

                    Tableau.Gestion_Activite[Activite, j] = Participant;
                    j = 99;
                }
            }       

        }
        static void Information_Utilisateur(int[,] _1)
        {
            /* ---------------------- */
            /* Choisir un Participant */

            Console.WriteLine("Veuilliez choisir un numéro de particicpant");

            Afficher_Activite(Tableau.Participant);
            int Participant,Argent;
            Participant = int.Parse(Console.ReadLine());
            Argent = 0;
            string NomP,PrenomP;

            NomP = Tableau.Participant[Participant, 0];
            PrenomP = Tableau.Participant[Participant, 1];

            {
                /* i et j sont des compteur */
                int i, j;
                Console.Write(NomP + " " + PrenomP + "participe à(aux) activité :");
                /* Retrouver les activite du participant */
                for (i = 0; i < 20; i++)
                {

                    //int p1;
                    j = 1;

                    while (j<20)
                    {

                        if (Tableau.Gestion_Activite[i,j]==Participant)
                        {
                          //  Console.WriteLine("444");
                            int.TryParse(Tableau.Activite[Tableau.Gestion_Activite[i,0], 4], out int temp);
                            Console.Write(Tableau.Activite[Tableau.Gestion_Activite[i, 0], 0] + ", ");
                            //Console.WriteLine(temp);
                            Argent = Argent + temp;
                        }

                        j = j + 1;
                    }

                }
                    Console.WriteLine("et doit "+Argent+"Euros à l'association.");
                //    Console.WriteLine(NomP+" "+PrenomP+" doit "+Argent+"Euros à l'association.");
            }
        }
        static void Supprimer(int[,] _1)
        {
            Console.WriteLine("Que voulez vous supprimer ?");
            Console.WriteLine("1 - Une activité");
            Console.WriteLine("2 - Un utilisateur");
            Console.WriteLine("3 - Une participation à une activité");
            Console.WriteLine("4 - Annuler");


            int Choix,ChoixA,ChoixP,ChoixPA,OuiNon=1;
            Choix = int.Parse(Console.ReadLine());

            if (Choix==1)
            {
                Console.WriteLine("Quelle activité voulez supprimer ?");
                Afficher_Activite(Tableau.Activite);
                ChoixA = int.Parse(Console.ReadLine());

                if (Tableau.Gestion_Activite[ChoixA-1,1]!=-1)
                {
                    Console.WriteLine("Attention il y a des participant voulez vous continuer ?");
                    Console.WriteLine("1 - OUI");
                    Console.WriteLine("2 - NON");
                    OuiNon = int.Parse(Console.ReadLine());
                    if (OuiNon == 1)
                    {
                        int CompteurA=0;
                        while (Tableau.Activite[CompteurA, 0] != null)
                        {
                            CompteurA = CompteurA + 1;
                        }
                        CompteurA = CompteurA - ChoixA;
                        for(CompteurA=CompteurA; CompteurA!=-1; CompteurA--)
                        {

                            Tableau.Activite[ChoixA, 0] = Tableau.Activite[ChoixA + 1, 0];
                            Tableau.Activite[ChoixA, 1] = Tableau.Activite[ChoixA + 1, 1];
                            Tableau.Activite[ChoixA, 2] = Tableau.Activite[ChoixA + 1, 2];
                            Tableau.Activite[ChoixA, 3] = Tableau.Activite[ChoixA + 1, 3];
                            Tableau.Activite[ChoixA, 3] = Tableau.Activite[ChoixA + 1, 4];


                            ChoixA = ChoixA + 1;
                        }
                    }
                    else
                    {
                        Supprimer(Tableau.Gestion_Activite);
                    }


                }


            }
            else 
                if(Choix==2)
                {
    
                }
                else
                    if (Choix==3)
                    {
                         Console.WriteLine("Dans quelle activité voulez-vous supprimer un participant ?");
                         Afficher_Activite(Tableau.Activite);
                         ChoixA = int.Parse(Console.ReadLine());

                         Console.WriteLine("Quelle participant voulez-vous supprimer ?");
                         Afficher_Activite(Tableau.Participant);
                         ChoixP = int.Parse(Console.ReadLine());
                         int i = 1; 

                         while (i<20)
                         {
                            if(Tableau.Gestion_Activite[ChoixA - 1, i] == ChoixP)
                            {
                                Tableau.Gestion_Activite[ChoixA - 1, i] = Tableau.Gestion_Activite[ChoixA - 1, i]+1;
                            }
                    i = i + 1;
                         }
                    }




        }

        static void Main(string[] args)
                {
                    for (int i = 0; i < 20; i++)
                    {
                        for (int j = 0; j < 20; j++)
                        {
                            Tableau.Gestion_Activite[i, j] = -1;
                        }
                    }

                    /* Ajout d'activite */
                    Tableau.Activite[0, 0] = "Libellé    ";
                    Tableau.Activite[0, 1] = "Organisateur    ";
                    Tableau.Activite[0, 2] = "Lieux           ";
                    Tableau.Activite[0, 3] = "Date            ";
                    Tableau.Activite[0, 4] = "Prix            ";

                    Tableau.Activite[1, 0] = "Randonnée  ";
                    Tableau.Activite[1, 1] = "Arthur          ";
                    Tableau.Activite[1, 2] = "Foret           ";
                    Tableau.Activite[1, 3] = "09/09/2021      ";
                    Tableau.Activite[1, 4] = "2";

                    Tableau.Activite[2, 0] = "Foot salle  ";
                    Tableau.Activite[2, 1] = "Cloe            ";
                    Tableau.Activite[2, 2] = "Gymnase         ";
                    Tableau.Activite[2, 3] = "01/02/21        ";
                    Tableau.Activite[2, 4] = "5";

                    Tableau.Activite[3, 0] = "Dance  ";
                    Tableau.Activite[3, 1] = "Quelqu'un       ";
                    Tableau.Activite[3, 2] = "Quelque part    ";
                    Tableau.Activite[3, 3] = "Un jour         ";
                    Tableau.Activite[3, 4] = "7";

                    // x represente n+1 activite
                    int x = 3;

                    /* Ajout de participant */
                    Tableau.Participant[0, 0] = "Nom        ";
                    Tableau.Participant[0, 1] = "Prenom          ";
                    Tableau.Participant[0, 2] = "Mails                     ";
                    Tableau.Participant[0, 3] = "Date inscirption";
                    Tableau.Participant[0, 4] = "Mot de passe    ";

                    Tableau.Participant[1, 0] = "Bastian    ";
                    Tableau.Participant[1, 1] = "Matthias        ";
                    Tableau.Participant[1, 2] = "mat.bastian@gmail.com     ";
                    Tableau.Participant[1, 3] = "24/01/2019      ";
                    Tableau.Participant[1, 4] = "1234            ";

                    Tableau.Participant[2, 0] = "Begin      ";
                    Tableau.Participant[2, 1] = "Bruno           ";
                    Tableau.Participant[2, 2] = "Bruno.begin@gmail.com     ";
                    Tableau.Participant[2, 3] = "12/10/2019      ";
                    Tableau.Participant[2, 4] = "5678            ";

                    Tableau.Participant[3, 0] = "Gauthier   ";
                    Tableau.Participant[3, 1] = "Louis           ";
                    Tableau.Participant[3, 2] = "Gauthier.Louis@gmail.com  ";
                    Tableau.Participant[3, 3] = "01/01/2021      ";
                    Tableau.Participant[3, 4] = "9012            ";

                    /* Ajout de participant à des activité*/

                    //Tableau.Gestion_Activite[i,j] ou i = numero d'activite et J = numero des participant

                    Tableau.Gestion_Activite[0, 0] = 1;
                    Tableau.Gestion_Activite[0, 1] = 1;
                    Tableau.Gestion_Activite[0, 2] = 2;

                    Tableau.Gestion_Activite[1, 0] = 2;
                    Tableau.Gestion_Activite[1, 1] = 1;
                    Tableau.Gestion_Activite[1, 2] = 2;
                    Tableau.Gestion_Activite[1, 3] = 3;

                    Tableau.Gestion_Activite[2, 0] = 3;
                    Tableau.Gestion_Activite[2, 1] = 2;


            // y represente n+1 Participant
            int y = 3;

                    /* Création du menu */



                    string choix = Menu();

                    while (choix != "9")
                    {
                        switch (choix)
                        {
                            case "1":
                                Afficher_Activite(Tableau.Activite);
                                Console.WriteLine();
                                break;
                            case "2":
                                Afficher_Participant(Tableau.Participant);
                                Console.WriteLine();
                                break;
                            case "3":
                                x = x + 1;
                                Ajouter_Activite(Tableau.Activite, x);
                                Console.WriteLine();
                                break;
                            case "4":
                                y = y + 1;
                                Ajouter_Utilisateur(Tableau.Participant, y);
                                Console.WriteLine();
                                break;
                            case "5":
                                Afficher_Gestion_Activite(Tableau.Gestion_Activite);
                                Console.WriteLine();
                                break;
                            case "6":
                                Ajouter_Participant_Activite(Tableau.Gestion_Activite);
                                Console.WriteLine();
                                break;
                            case "7":
                                Information_Utilisateur(Tableau.Gestion_Activite);
                                Console.WriteLine();
                                break;
                            case "8":
                                Supprimer(Tableau.Gestion_Activite);
                                Console.WriteLine();
                                break;
                            default:
                                Console.WriteLine("Erreur de saisie.");
                                Console.WriteLine("Veuillez saisir une nouvelle valeur.");
                                Console.WriteLine();

                                break;
                        }//fin du switch

                        choix = Menu();

                    }
        }
    }
}
