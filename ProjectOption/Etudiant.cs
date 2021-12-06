using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOption
{
    class Etudiant
    {

          static int nbE; //le nombre totale des étudiante 
          static int ajouter=0;

        private string[] nom = new string[nbE]; //un tableau pour stocker les noms des étudiates
        private int[] note = new int[nbE];   //un tableau pour stocker les noms des étudiates
        public string[,] Petud = new string[nbE, 4]; //un tableau pour stocker les noms et les trois choix de chaque étudiante 
        public Etudiant(int nbe)  // Constructeur pour l'initialisation de Nombre des étudiate
        {

            this.nbE = nbe;
        }

        public  void setnbE(nbe) //Un setter pour changer le nombre des étudiantes
        {
           this.nbE = nbe;

            }
        public int getnbE () // getter pour returner le nombre des étudiantes
        { return nbE; }
    




          public void setListE(string nom,string note) //Un setter pour affecter la note et le nom d'un étudiante
        {     if (nbE > ajouter)
            {
                this.nom[i] = nom;
                this.note[i] = note;
                ajouter++;
            }


        }
          public  string getNom(int i) //getter pour retourner le nom de l'rudiande de l'indice i

        { 
            return nom[i];
        }
          public int getNote(int i) //getter pour retourner le nom de l'rudiande de l'indice i
        {

            return note[i];
        }
          public void setPetud(string option1,string option2,string option3,int i) //Un setter pour affcter le nom et les trois choix d'un étudiante
        {

            
                Petud[i, 0] = getEtudiante(i) ;
                

                    Petud[i, 1] = option1;
                    Petud[i, 2] = option2;
                    Petud[i, 3] = option3;

                 
            }
          public void setNote(string note,int i)  //un setter pour changer la note de l'étudiante de l'indice i 
        {
            note[i] = note;
        }
          public void setNom (string nom,int i) //un setter pour changer le nom de l'étudiante de l'indice i 
        {
            nom[i] = nom;


        }

        
          public void gettPetud() //un getter pour retourner le nom et les trois choix de toute les étudiantes

        {
            for (int i = 0; i < nbE; i++)
                for (int j = 1; j < 4; j++)
                    Console.WriteLine(Petud[i, j] + "\t");

       }


    }
}
