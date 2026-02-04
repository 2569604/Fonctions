using System.Net.NetworkInformation;

namespace Fonctions
{

    internal class Program
    {
        // Design ASCII
        static string gBar = "+===========================================================+";
        static string gBarThin = "+-----------------------------------------------------------+";

        // Liste des mots qui seront affiché d'une couleur différente
        static object[,] gMotsCouleur =
                { //  Couleur désiré       Mot 1   Mot 2     Mot 3...
                    { ConsoleColor.Yellow, "clé", "coffre", "argent" },
                    { ConsoleColor.Red, "école", "", "elle" },
                    { ConsoleColor.Blue, "parent", "toi", "" }
                };

        // Liste des caractères spéciaux
        static string[] gCaractèresSpéciaux = { "!", "@", "#", "$", "%", "?", "&", "*", "(", ")", "/", "\\", "-", "_", "=", "+", "{", "}", "[", "]", ";", ":", ",", "'", ".", "\"", "<", ">", "°"};
        // Liste des majuscules
        static string[] gMajuscules = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
        static void Main(string[] args)
        {

            Console.Write("Entrez le numéro d'exercice à tester : ");
            while (true)
            {
                string Reponse = Console.ReadLine();

                switch (Reponse)
                {
                    case "1":
                        Console.Clear();
                        Ex1();
                        Restart();
                        break;
                    case "2":
                        Console.Clear();
                        Ex2();
                        Restart();
                        break;
                    case "3":
                        Console.Clear();
                        Ex3();
                        Restart();
                        break;
                    //case "4":
                    //    Console.Clear();
                    //    Ex4();
                    //    Restart();
                    //    break;
                    //case "5":
                    //    Console.Clear();
                    //    Ex5();
                    //    Restart();
                    //    break;
                    //case "6":
                    //    Console.Clear();
                    //    Ex6();
                    //    Restart();
                    //    break;
                    //case "7":
                    //    Console.Clear();
                    //    Ex7();
                    //    Restart();
                    //    break;
                    //case "8":
                    //    Console.Clear();
                    //    Ex8();
                    //    Restart();
                    //    break;
                    //case "9":
                    //    Console.Clear();
                    //    Ex9();
                    //    Restart();
                    //    break;
                    //case "10":
                    //    Console.Clear();
                    //    Ex10();
                    //    Restart();
                    //    break;
                    //case "11":
                    //    Console.Clear();
                    //    Ex11();
                    //    Restart();
                    //    break;
                    //case "12":
                    //    Console.Clear();
                    //    Ex12();
                    //    Restart();
                    //    break;
                    //case "13":
                    //    Console.Clear();
                    //    Ex13();
                    //    Restart();
                    //    break;
                    default:
                        Console.WriteLine("ERREUR\r\n-----------  \r\nAttendez...");
                        Thread.Sleep(1500);
                        Console.Clear();
                        Console.Write("Entrez le numéro d'exercice à tester : ");
                        break;
                }
            }
        }

        static void Restart()
        {
            bool finis = false;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pause, entrez 1 pour continuer.");
            while (finis == false)
            {
                if (Console.ReadLine() == "1")
                {
                    finis = true;
                }
            }
            Console.Clear();
            Console.Write("Entrez le numéro d'exercice à tester : ");
        }

        /// <summary>
        /// Fait un TryParse en int qui, a la place de crasher, met une erreur et repose la question au user.
        /// </summary>
        /// <param name="pQuestion">Question posé au user</param>
        /// <returns>Retourne la réponse du user en int</returns>
        static int IntTryParse(string pQuestion)
        {
            bool succes = false;
            int Choix = 0;

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = int.TryParse(Console.ReadLine(), out Choix);

                if (!succes) { ErreurMsg(); }
            }

            return Choix;
        }
        /// <param name="pPlusPetitRange">Inclut</param>
        static int IntTryParse(string pQuestion, int pPlusPetitRange)
        {
            bool succes = false;
            int Choix = 0;

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = int.TryParse(Console.ReadLine(), out Choix);

                if (Choix < pPlusPetitRange) { succes = false; }
                if (!succes) { ErreurMsg(); }
            }

            return Choix;

        }
        /// <param name="pPlusGrandRange">Inclut</param>
        static int IntTryParse(string pQuestion, int pPlusPetitRange, int pPlusGrandRange)
        {
            bool succes = false;
            int Choix = 0;

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = int.TryParse(Console.ReadLine(), out Choix);

                if (Choix < pPlusPetitRange) { succes = false; }
                if (Choix > pPlusGrandRange) { succes = false; }
                if (!succes) { ErreurMsg(); }
            }

            return Choix;

        }

        /// <summary>
        /// Fait un TryParse en double qui, a la place de crasher, met une erreur et repose la question au user.
        /// </summary>
        /// <param name="pQuestion">Question posé au user</param>
        /// <returns>Retourne la réponse du user en double</returns>
        static double DoubleTryParse(string pQuestion)
        {
            bool succes = false;
            double Choix = 0;

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = double.TryParse(Console.ReadLine(), out Choix);

                if (!succes) { ErreurMsg(); }

            }

            return Choix;

        }
        /// <param name="pPlusPetitRange">Inclut</param>
        static double DoubleTryParse(string pQuestion, double pPlusPetitRange)
        {
            bool succes = false;
            double Choix = 0;

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = double.TryParse(Console.ReadLine(), out Choix);

                if (Choix < pPlusPetitRange) { succes = false; }
                if (!succes) { ErreurMsg(); }

            }

            return Choix;

        }
        /// <param name="pPlusGrandRange">Inclut</param>
        static double DoubleTryParse(string pQuestion, double pPlusPetitRange, double pPlusGrandRange)
        {
            bool succes = false;
            double Choix = 0;

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = double.TryParse(Console.ReadLine(), out Choix);

                if (Choix < pPlusPetitRange) { succes = false; }
                if (Choix > pPlusGrandRange) { succes = false; }
                if (!succes) { ErreurMsg(); }

            }

            return Choix;

        }

        /// <summary>
        /// Fait un TryParse en int qui, a la place de crasher, met une erreur et repose la question au user.
        /// </summary>
        /// <param name="pQuestion">Question posé au user</param>
        /// <returns>Retourne la réponse du user en int</returns>
        static bool BoolTryParse(string pQuestion)
        {
            bool succes = false;
            bool Choix = false;

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = bool.TryParse(Console.ReadLine(), out Choix);

                if (!succes) { ErreurMsg(); }
            }

            return Choix;
        }
        /// <param name="pRempTrue">Ce que le user doit entrez pour retourner true</param>
        /// <param name="pRempFalse">Ce que le user doit entrez pour retourner false</param>
        static bool BoolTryParse(string pQuestion, string pRempTrue, string pRempFalse)
        {
            while (true)
            {
                Console.Write(pQuestion);
                string input = Console.ReadLine();
                if (input == pRempTrue) { return true; }
                if (input == pRempFalse) { return false; }
                ErreurMsg();
            }
        }

        static char CharTryParse(string pQuestion)
        {
            bool succes = false;
            char Choix = 'a';

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = char.TryParse(Console.ReadLine(), out Choix);

                if (!succes) { ErreurMsg(); }
            }

            return Choix;
        }
        /// <param name="pRestriction">Restrictions pour les choix possible, plus d'info dans la fonction</param>
        static char CharTryParse(string pQuestion, string pRestriction)
        {
                                    //     "maj"    ---->     N'accepter que les majuscules
                                    //     "min"    ---->     N'accepter que les minuscules
                                    //     "ltr"    ---->     N'accepter que les lettres
            bool succes = false;
            char Choix = 'a';

            while (!succes)
            {
                Console.Write(pQuestion);
                succes = char.TryParse(Console.ReadLine(), out Choix);

                if (succes)
                {
                    for (int i = 0; i < gMajuscules.Length; i++)
                    {
                        if (pRestriction == "min") { if (Choix == char.Parse(gMajuscules[i])) { succes = false; break; } }
                    }
                    if (pRestriction == "maj") 
                    {
                        succes = false;
                        for (int i = 0; i < gMajuscules.Length; i++)
                        {
                            if (Choix == char.Parse(gMajuscules[i])) { succes = false; }
                        }
                    }
                }

                if (!succes) { ErreurMsg(); }
            }

            return Choix;
        }

        static void Ex1()
        {
            int[] Tab = { 1, 2, 3, 6, 2, 3 };

            Console.WriteLine("Voici le tableau Tab : ");
            for (int i = 0; i < Tab.Length; i++)
            {
                Console.Write($"{Tab[i]} ");
            }

            EcrireFichier("Variables", Tab, "int[] Tab");

            for(int i = 0; i < Tab.Length;i++)
            {
                Tab[i] = int.Parse(InitialiserVar("Variables", "int[] Tab", Tab)[i]);
            }

            Console.WriteLine("Voici le tableau Tab après : ");
            for (int i = 0; i < Tab.Length; i++)
            {
                Console.Write($"{Tab[i]} ");
            }

        }

        static void Ex2()
        {
            CreerViderFichier("Variables");
            string[] tab = { "io", "com", "ca", "fr" };
            AfficherTab(tab, "viresp");
        }

        static void Ex3()
        {
            
        }

        /// <summary>
        /// Affiche les tableaux
        /// </summary>
        /// <param name="pTab"></param>
        /// <param name="pStyle">style d'affichage : cro, crochet; esp, espace; vir, virgule; viresp, virgule espace</param>
        static void AfficherTab(string[] pTab, string pStyle) 
        {
            switch(pStyle.ToLower())
            {
                case "cro":
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        if (i == pTab.Length - 1) { Console.Write($"[{pTab[i]}]"); }
                        else { Console.Write($"[{pTab[i]}] "); }
                    }
                    break;
                case "esp":
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        if (i == pTab.Length - 1) { Console.Write($"{pTab[i]}"); }
                        else { Console.Write($"{pTab[i]} "); }
                    }
                    break;
                case "vir":
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        if (i == pTab.Length - 1) { Console.Write($"{pTab[i]}"); }
                        else { Console.Write($"{pTab[i]},"); }
                        
                    }
                    break;
                case "viresp":
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        if (i == pTab.Length - 1) { Console.Write($"{pTab[i]}"); }
                        else { Console.Write($"{pTab[i]}, "); }
                    }
                    break;
                default:
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        if (i == pTab.Length - 1) { Console.Write($"{pTab[i]}"); }
                        else { Console.Write($"{pTab[i]}, "); }
                    }
                    break;
            }
            
        }
        static void AfficherTab(string[] pTab)
        {
            for (int i = 0; i < pTab.GetLength(0); i++)
            {
                if (i == pTab.Length - 1) { Console.Write($"{pTab[i]}"); }
                else { Console.Write($"{pTab[i]}, "); }
            }
        }
        static void AfficherTab(string[,] pTab, string pStyle) //version pour 2D
        {
            switch (pStyle.ToLower())
            {
                case "cro":
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        for (int j = 0; j < pTab.GetLength(1); j++)
                        {
                            Console.Write($"[{pTab[i, j]}] ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "esp":
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        for (int j = 0; j < pTab.GetLength(1); j++)
                        {
                            Console.Write($"{pTab[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "vir":
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        for (int j = 0; j < pTab.GetLength(1); j++)
                        {
                            Console.Write($"{pTab[i, j]},");
                        }
                        Console.WriteLine();
                    }
                    break;
                case "viresp":
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        for (int j = 0; j < pTab.GetLength(1); j++)
                        {
                            Console.Write($"{pTab[i, j]}, ");
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    for (int i = 0; i < pTab.GetLength(0); i++)
                    {
                        for (int j = 0; j < pTab.GetLength(1); j++)
                        {
                            Console.Write($"{pTab[i, j]}, ");
                        }
                        Console.WriteLine();
                    }
                    break;
            }
            
        }
        static void AfficherTab(string[,] pTab)
        {
            for (int i = 0; i < pTab.GetLength(0); i++)
            {
                for (int j = 0; j < pTab.GetLength(1); j++)
                {
                    Console.Write($"{pTab[i, j]}, ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Crée un fichier ou le vide s'il existe déjà
        /// </summary>
        /// <param name="fichier">nom du fichier</param>
        static void CreerViderFichier(string pFichier)
        {
            StreamWriter Fichier = new StreamWriter($"{pFichier}.txt");
            Fichier.WriteLine();
            Fichier.Close();
        }
        static void CreerViderFichier(string pFichier, string pExtension) //rajouter l'extension si pas un .txt
        {
            StreamWriter Fichier = new StreamWriter($"{pFichier}.{pExtension}");
            Fichier.WriteLine();
            Fichier.Close();
        }

        /// <summary>
        /// Écrit dans un fichier, gardant les informations ultérieures.
        /// </summary>
        /// <param name="pFichier"></param>
        /// <param name="pInfo"></param>
        static void EcrireFichier(string pFichier, string pInfo)
        {
            StreamWriter Fichier = new StreamWriter($"{pFichier}.txt", true);
            Fichier.WriteLine(pInfo);
            Fichier.Close();
        }
        static void EcrireFichier(string pFichier, string pInfo, string pVar) // variante qui précise le type et le nom de la variable
        {
            StreamWriter Fichier = new StreamWriter($"{pFichier}.txt", true);
            Fichier.WriteLine(pVar);
            Fichier.WriteLine(pInfo);
            Fichier.Close();
        }
        static void EcrireFichier(string pFichier, string[] pInfo, string pVar) // variante pour les tableaux 1D
        {
            StreamWriter Fichier = new StreamWriter($"{pFichier}.txt", true);
            Fichier.WriteLine(pVar);
            for(int i = 0;  i < pInfo.Length; i++)
            {
                if (i == pInfo.Length-1) { Fichier.WriteLine($"{pInfo[i]}"); }
                else { Fichier.WriteLine($"{pInfo[i]}, "); }
            }
            Fichier.Close();
        }
        static void EcrireFichier(string pFichier, int[] pInfo, string pVar) // Tab 1D int, on le met en string
        {
            string[] pInfoString = new string[pInfo.Length];
            for (int i = 0; i < pInfo.Length; i++)
            {
                pInfoString[i] = pInfo[i].ToString();
            }
            StreamWriter Fichier = new StreamWriter($"{pFichier}.txt", true);
            Fichier.WriteLine(pVar);
            for (int i = 0; i < pInfoString.Length; i++)
            {
                if (i == pInfoString.Length - 1) { Fichier.WriteLine($"{pInfoString[i]}"); }
                else { Fichier.Write($"{pInfoString[i]}, "); }
            }
            Fichier.Close();
        }
        static void EcrireFichier(string pFichier, double[] pInfo, string pVar) // Tab 1D double, on le met en string
        {
            string[] pInfoString = new string[pInfo.Length];
            for (int i = 0; i < pInfo.Length; i++)
            {
                pInfoString[i] = pInfo[i].ToString();
            }
            StreamWriter Fichier = new StreamWriter($"{pFichier}.txt", true);
            Fichier.WriteLine(pVar);
            for (int i = 0; i < pInfoString.Length; i++)
            {
                if (i == pInfoString.Length - 1) { Fichier.WriteLine($"{pInfoString[i]}"); }
                else { Fichier.WriteLine($"{pInfoString[i]}, "); }
            }
            Fichier.Close();
        }
        static void EcrireFichier(string pFichier, bool[] pInfo, string pVar) // Tab 1D bool, on le met en string
        {
            string[] pInfoString = new string[pInfo.Length];
            for (int i = 0; i < pInfo.Length; i++)
            {
                pInfoString[i] = pInfo[i].ToString();
            }
            StreamWriter Fichier = new StreamWriter($"{pFichier}.txt", true);
            Fichier.WriteLine(pVar);
            for (int i = 0; i < pInfoString.Length; i++)
            {
                if (i == pInfoString.Length - 1) { Fichier.WriteLine($"{pInfoString[i]}"); }
                else { Fichier.WriteLine($"{pInfoString[i]}, "); }
            }
            Fichier.Close();
        }

        /// <summary>
        /// On initialise des variables dans le projet
        /// </summary>
        /// <param name="pFichier"></param>
        /// <param name="pVar"></param>
        /// <returns></returns>
        static string InitialiserVar(string pFichier, string pVar)
        {
            StreamReader Fichier = new StreamReader($"{pFichier}.txt");
            string resultat = "";
            while (!Fichier.EndOfStream)
            {
                if (Fichier.ReadLine() == pVar) { resultat = Fichier.ReadLine(); }
            }
            Fichier.Close();
            return resultat;
        }
        static string[] InitialiserVar(string pFichier, string pVar, string[] pTab) // variante pour tableaux
        {
            StreamReader Fichier = new StreamReader($"{pFichier}.txt");
            string[] resultat = new string[pTab.Length];
            bool reussi = false;
            while (!Fichier.EndOfStream)
            {
                while (!Fichier.EndOfStream)
                {
                    if (Fichier.ReadLine() == pVar)
                    {
                        reussi = true;
                        break;
                    }
                }
                if (reussi)
                {
                    resultat = Fichier.ReadLine().Split(", ");
                }
            }
            Fichier.Close();
            return resultat;
        }
        static string[] InitialiserVar(string pFichier, string pVar, int[] pTab) // pour tab de int
        {
            StreamReader Fichier = new StreamReader($"{pFichier}.txt");
            string[] resultat = new string[pTab.Length];
            bool reussi = false;
            while (!Fichier.EndOfStream)
            {
                while (!Fichier.EndOfStream)
                {
                    if (Fichier.ReadLine() == pVar)
                    {
                        reussi = true;
                        break;
                    }
                }
                if (reussi)
                {
                    resultat = Fichier.ReadLine().Split(", ");
                }
            }
            Fichier.Close();
            return resultat;
        }
        static string[] InitialiserVar(string pFichier, string pVar, double[] pTab) // pour tab de double
        {
            StreamReader Fichier = new StreamReader($"{pFichier}.txt");
            string[] resultat = new string[pTab.Length];
            bool reussi = false;
            while (!Fichier.EndOfStream)
            {
                while (!Fichier.EndOfStream)
                {
                    if (Fichier.ReadLine() == pVar)
                    {
                        reussi = true;
                        break;
                    }
                }
                if (reussi)
                {
                    resultat = Fichier.ReadLine().Split(", ");
                }
            }
            Fichier.Close();
            return resultat;
        }
        static string[] InitialiserVar(string pFichier, string pVar, bool[] pTab) // pour tab de bool
        {
            StreamReader Fichier = new StreamReader($"{pFichier}.txt");
            string[] resultat = new string[pTab.Length];
            bool reussi = false;
            while(!Fichier.EndOfStream)
            {
                while (!Fichier.EndOfStream)
                {
                    if (Fichier.ReadLine() == pVar)
                    {
                        reussi = true;
                        break;
                    }
                }
                if (reussi)
                {
                    resultat = Fichier.ReadLine().Split(", ");
                }
            }
            Fichier.Close();
            return resultat;
        }

        static void CréerFichierCSV(string pInfo, string pNomFichier)
        {
            using (StreamWriter sw = new StreamWriter(pNomFichier))
            {
                sw.WriteLine(pInfo);
            }
        }
        static void CréerFichierCSV(string[,] pInfo, string pNomFichier)
        {
            using (StreamWriter sw = new StreamWriter(pNomFichier))
            {
                for (int i = 0; i < pInfo.GetLength(0); i++)
                {
                    for (int j = 0; j < pInfo.GetLength(1); j++)
                    {
                        if (j == pInfo.GetLength(1) - 1) { sw.Write($"{pInfo[i, j]}"); }
                        else { sw.Write($"{pInfo[i, j]},"); }
                    }
                    sw.WriteLine();
                }
            }
        }
        static void CréerFichierCSV(int[,] pInfo, string pNomFichier)
        {
            using (StreamWriter sw = new StreamWriter(pNomFichier))
            {
                for (int i = 0; i < pInfo.GetLength(0); i++)
                {
                    for (int j = 0; j < pInfo.GetLength(1); j++)
                    {
                        if (j == pInfo.GetLength(1) - 1) { sw.Write($"{pInfo[i, j]}"); }
                        else { sw.Write($"{pInfo[i, j]},"); }
                    }
                    sw.WriteLine();
                }
            }
        }

        static void EcrireFichierCSV(string[,] pInfo, string pNomFichier)
        {
            using (StreamWriter sw = new StreamWriter(pNomFichier, true))
            {
                for (int i = 0; i < pInfo.GetLength(0); i++)
                {
                    for (int j = 0; j < pInfo.GetLength(1); j++)
                    {
                        if (j == pInfo.GetLength(1) - 1) { sw.Write($"{pInfo[i, j]}"); }
                        else { sw.Write($"{pInfo[i, j]},"); }
                    }
                    sw.WriteLine();
                }
            }
        }

        static string[,] LireFichierCSV(string pNomFichier)
        {
            List<string> lignesLu = new List<string>();
            using (StreamReader sr = new StreamReader(pNomFichier))
            {
                while (!sr.EndOfStream)
                {
                    lignesLu.Add(sr.ReadLine());
                }
            }
            string[] lignes = lignesLu[0].Split(",");
            string[,] resultat = new string[lignesLu.Count, lignes.Length];
            for (int i = 0; i < lignesLu.Count; i++)
            {
                lignes =lignesLu[i].Split(",");
                for (int j = 0; j < lignes.Length; j++)
                {
                    resultat[i,j] = lignes[j];
                }
            }
            return resultat;
        }

        /// <summary>
        /// Affiche un message d'erreur avec des point de suspens qui s'anime
        /// </summary>
        static void ErreurMsg()
        {
            Console.Clear();
            Console.Write("Erreur");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write(".");
            Thread.Sleep(350);
            Console.WriteLine(".");
            Thread.Sleep(350);
        }
        /// <param name="pMessage">Le message d'erreur</param>
        static void ErreurMsg(string pMessage) 
        {
            Console.Clear();
            Console.Write(pMessage);
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.WriteLine(".");
            Thread.Sleep(300);
        }
        /// <param name="pTemp">Le temp d'attente</param>
        static void ErreurMsg(string pMessage, int pTemp) // Version ou on peut choisir le temps, en millisecondes
        {
            Console.Clear();
            Console.Write(pMessage);
            Thread.Sleep(Convert.ToInt32(pTemp * 1.5));
            Console.Write(".");
            Thread.Sleep(pTemp);
            Console.Write(".");
            Thread.Sleep(pTemp);
            Console.WriteLine(".");
            Thread.Sleep(pTemp);
        }

        /// <summary>
        /// Une boucle infini pour finir le script. Juste pour qu'à la fin on ne voit pas tout le texte laid avec le chemin absolu et tout XD
        /// </summary>
        static void Fin()
        {
            while (true)
            {
                string inutile = Console.ReadLine();
            }
        }

        /// <summary>
        /// Écrit un message en jaune
        /// </summary>
        /// <param name="pMessage"></param>
        static void EcrireCouleur(string pMessage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(pMessage);
            Console.ResetColor();
        }
        static void EcrireCouleur(string pMessage, ConsoleColor pCouleur) // choisi la couleur
        {
            //for (int i = 0; i < pMessage.Split(' ').Length; i++)
            //{
            //    bool Finis = false;
            //    string motActuel = pMessage.Split(' ')[i];
            //    bool caractereSpec = false;
            //    for (int j = 0; j < CaractèresSpéciaux.Length - 1; j++)
            //    {
            //        if (Char.Parse(CaractèresSpéciaux[j]) == motActuel[i]) { caractereSpec = true; break; }
            //    }
            //    if (!caractereSpec)
            //    {
            //        int nbrDeCouleurs = MotsCouleur.GetLength(0);
            //        for (int j = 0; j < nbrDeCouleurs; j++)
            //        {
            //            int nbrDeMots = MotsCouleur.GetLength(1);
            //            for (int k = 1; k < nbrDeMots; k++)
            //            {
            //                bool sortirDuMot = false;
            //                string motActuelTab = MotsCouleur[j, k].ToString();
            //                for (int l = 0; l < motActuelTab.Length; l++)
            //                {
            //                    if (!(motActuel[l + i] == motActuelTab[l])) { sortirDuMot = true; break; }
            //                    if (l == motActuelTab.Length - 1) { couleurMot = (ConsoleColor)MotsCouleur[j, 0]; Finis = true; motEnCouleur = motActuel; }
            //                }
            //                if (sortirDuMot) { break; }
            //                if (Finis) { break; }
            //            }
            //            if (Finis) { break; }
            //        }
            //        if (Finis) { break; }
            //    }
            //    if (Finis) { break; }
            //}

            for (int i = 0; i < pMessage.Split(' ').Length; i++)
            {
                bool MotEcrit = false;
                string motActuel = pMessage.Split(' ')[i];
                string motActuelOG = motActuel;
                for (int j = 0; j < gCaractèresSpéciaux.Length; j++)
                {
                    motActuel = motActuel.Replace(gCaractèresSpéciaux[j], "");
                }
                for (int j = 0; j < gMotsCouleur.GetLength(0); j++)
                {
                    for (int k = 1; k < gMotsCouleur.GetLength(1); k++)
                    {
                        if ((string)gMotsCouleur[j, k] == motActuel.ToLower())
                        {
                            Console.ForegroundColor = (ConsoleColor)gMotsCouleur[j, 0];
                            Console.Write($"{motActuelOG} ");
                            Console.ResetColor();
                            MotEcrit = true;
                        }
                        else if (k == gMotsCouleur.GetLength(1)-1 && j == gMotsCouleur.GetLength(0)-1)
                        {
                            Console.ForegroundColor = pCouleur;
                            Console.Write($"{motActuelOG} ");
                            Console.ResetColor();
                            MotEcrit = true;
                        }
                        if (MotEcrit) { break; }
                    }
                    if (MotEcrit) { break; }
                }
                
            }
            Console.WriteLine();
        }

    }
}
