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


        public void setnbA(int nbA)

        {
            this.nbA = nbA;


        }
        public void setnbG(int nbG)
        {


            this.nbG = nbG;

        }
        public void setnbR(int nbR)
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
                    if (et.getNote(i))

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
