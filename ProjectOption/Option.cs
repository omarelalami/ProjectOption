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


        public void  setnbA(int nbA)

        {
            this.nbA = nbA;


        }
        public void setnbG(int nbG)
        {


            this.nbG = nbG;

        }
       public  void setnbR(int nbR)
        {


            this.nbR = nbR;

        }

        public int getnbA()
        { return nbA; }
        public int getnbG()
        { return nbG; }
        public int getnbR()
        { return nbR; }
















        Etudiant et = new Etudiant();
        
        



        public void range()
        {
            for (int i = et.getnbE() - 1; i >= 1; i--)
                for (int j = 2; j <= i; j++)
                {


                    int tempNote = et.note[j - 1];
                    et.note[j - 1] = et.note[j];
                    et.note[j] = tempNote;



                    string tempNom = et.nom[j - 1];
                    et.nom[j - 1] = et.nom[j];
                    et.nom[j] = tempNom;

                }
        }
         



         





















        }
}
