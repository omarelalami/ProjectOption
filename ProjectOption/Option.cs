using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOption
{
    class Option
    {
        int nbA; //Nomber de place ABD
        int nbG; //Nomber de place GL
        int nbR; //Nomber de place ASR


        public void setnbA(int nbA) //Pour affecter le nombre de place ABD

        {
            this.nbA = nbA;


        }
        public void setnbG(int nbG) //Pour affecter le nombre de place GL
        {


            this.nbG = nbG;

        }
        public void setnbR(int nbR) //Pour affecter le nombre de place ASR
        {


            this.nbR = nbR;

        }

        public int getnbA() //Pour retourner le nombre de place ABD
        { return nbA; }
        public int getnbG() //Pour retourner le nombre de place GL
        { return nbG; }
        public int getnbR() //Pour retourner le nombre de place ASR
        { return nbR; }

        
        Etudiant et = new Etudiant(); //une composition juste pour récuperer les données de l'étudiante et trier 
        
        public void range() //une fonction de trie par ordre décroissante de la note 
        {
            for (int i = et.getnbE() - 1; i >= 1; i--)
                for (int j = 2; j <= i; j++)
                {
                    if (et.getNote(i)) //Si le trie effectuer A la case et le note prend un emplacement i alors le nom aussi prend la meme position pour respectere le paire

                    {
                        int tempNote = et.getNote(j - 1);
                        et.setNote(et.getnote(j), j - 1);
                        et.setNote(tempNote, j);



                        string tempNom = et.getNom(j - 1);
                        et.setNom(et.getnom(j), j - 1);
                        et.setNom(tempNom, j);
                    }
                }




        }
    }
}
