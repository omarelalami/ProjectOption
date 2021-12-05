using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOption
{
    class Etudiant
    {

          static int nbE;
          static int ajouter=0;

        private string[] nom = new string[nbE];
        private int[] note = new int[nbE];
        public string[,] Petud = new string[nbE, 4];
        public Etudiant(int nbe)
        {

            this.nbE = nbe;
        }

        public  void setnbE(nbe)
        {
           this.nbE = nbe;

            }
        public int getnbE ()
        { return nbE; }
    




          public void setListE(string nom,string note)
        {     if (nbE > ajouter)
            {
                this.nom[i] = nom;
                this.note[i] = note;
                ajouter++;
            }


        }
          public  string getNom(int i)

        { 
            return nom[i];
        }
          public int getNote(int i)
        {

            return note[i];
        }
          public void setPetud(string option1,string option2,string option3,int i)
        {

            
                Petud[i, 0] = getEtudiante(i) ;
                

                    Petud[i, 1] = option1;
                    Petud[i, 2] = option2;
                    Petud[i, 3] = option3;

                 
            }
          public void setNote(string note,int i)
        {
            note[i] = note;
        }
          public void setNom (string nom,int i)
        {
            nom[i] = nom;


        }

        
          public void gettPetud()

        {
            for (int i = 0; i < nbE; i++)
                for (int j = 1; j < 4; j++)
                    Console.WriteLine(Petud[i, j] + "\t");

       }


    }
}
