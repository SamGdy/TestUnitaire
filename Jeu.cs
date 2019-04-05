using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeuGrattageTestU
{
    class Jeu
    {
        int[,] carte;
        public Jeu(int[,] carte)
        {
            this.carte = carte;
        }
        public int Gagne()
        {
            int somme1=0, somme2=0, somme3=0;
            for (int ligne = 0; ligne < 3; ligne++)
            {
                
                for (int colonne = 0; colonne < 3; colonne++)
                {
                    switch (carte[ligne, colonne])
                    {
                        case 1:
                            somme1 += 1;
                            break;
                        case 2:
                            somme2 += 1;
                            break;
                        case 3:
                            somme3 += 1;
                            break;
                            
                    }
                    if (colonne == 2)
                    {
                        if (carte[ligne, colonne] == carte[ligne, colonne - 1] && carte[ligne, colonne] == carte[ligne, colonne - 2])
                        {
                                return 100;
                        }
                    }
                    if (ligne == 2)
                    {
                        if (carte[ligne, colonne] == carte[ligne - 1, colonne] && carte[ligne - 1, colonne]== carte[ligne - 2, colonne])
                        {
                                return 100;
                        }
                    }
                    if (ligne == 2)
                    {
                        if (colonne == 0)
                        {
                            if (carte[ligne, colonne] == carte[ligne - 1, colonne + 1] && carte[ligne, colonne] == carte[ligne - 2, colonne + 2])
                            {
                                return 100;
                            }
                        }
                        if (colonne == 2)
                        {
                            if (carte[ligne, colonne] == carte[ligne - 1, colonne - 1] && carte[ligne, colonne] == carte[ligne - 2, colonne - 2])
                            {
                                return 100;
                            }
                        }
                    }
                    
                        
                }
                
            }
            if (somme1 >= 6 || somme2 >= 6 || somme3 >= 6)
            {
                return 50;
            }
            return 0;
            
        }
        public override string ToString()
        {
            return "";
        }
    }
}
