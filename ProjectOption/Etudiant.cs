using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectOption
{
    class Etudiant
    {

          static int nbE;

        public string[] nom = new string[nbE];
        public int[] note = new int[nbE];
        public string[,] Petud = new string[nbE, 4];


        public  void setnbE()
        {
            nbE = int.Parse(Console.ReadLine());

            }
        public int getnbE ()
        { return nbE; }
    




       public void setListE()
        {
            for (int i = 0; i < nbE; i++)
            {
                nom[i] = Console.ReadLine();
                note[i] = int.Parse(Console.ReadLine());


            }

        }
          public  void getListe()


        { for (int i = 0; i < nbE; i++)
                Console.WriteLine(nom[i] + "\n" + note[i]);


        }

          public void setPetud()
        {

            for (int i = 0; i < nbE; i++)
            {
                Petud[i, 0] = nom[i];
                for (int j = 1; j < 4; j++)
                {

                    Petud[i, j] = Console.ReadLine();

                }
            }



        }
        public void gettPetud()

        {
            for (int i = 0; i < nbE; i++)
                for (int j = 1; j < 4; j++)
                    Console.WriteLine(Petud[i, j] + "\t");


        }














    }
}
