using System;
using System.Collections.Generic;
using System.Linq;
namespace ProjectOption
{           
                       //********* Gale shapley Version Pour la selction des Option au étudiant Génie Info **********\\
                        
    class Program
    {
        static void Main(string[] args)
        {

            Etudiant et = new Etudiant();
            Option op = new Option();
            et.setnbE();
            et.setListE();
            op.range();
            et.setPetud();
            List<string> libre = new List<string>(); //Liste des etudiante qui ont pas encore obtenir une place

            for (int i = 0; i < et.getnbE(); i++)
            {


                libre.Add(et.nom[i]);

            }
           
            string[,] res = new string[et.getnbE(), 2];
            op.setnbA(20);
            int nbA = op.getnbA();
            op.setnbG(20);
            int nbG = op.getnbG();
            op.setnbR(20);
            int nbR = op.getnbR();

           int ir = 0;
            int jr;
            int je = 0;
            int r = 0;
            int n = 0;
            while (libre.Any())
            {
                jr = 0;
                for (int i = 1; i < 4; i++)
                {
                    if (et.Petud[je, i] == "abd" && nbA != 0)
                    {
                        res[ir, jr] = et.Petud[n, 0];
                        jr++;
                        res[ir, jr] = et.Petud[ir, i];
                        nbA--;
                        i = 4;





}
                    else if (et.Petud[je, i] == "gl" && nbG != 0)
                    {
                        res[ir, jr] = et.Petud[n, 0];
                        jr++;
                        res[ir, jr] = et.Petud[ir, i];
                        nbG--;
                        i = 4;

                    }
                    else if (et.Petud[je, i] == "asr" && nbR != 0)
                    {
                        res[ir, jr] = et.Petud[n, 0];
                        jr++;
                        res[ir, jr] = et.Petud[ir, i];
                        nbR--;
                        i = 4;

                    }




                }

                ir++;

                libre.Remove(et.nom[r]);
                r++;
                n++;

            }
            for (int i = 0; i < et.getnbE(); i++)

            {
                Console.Write(res[i, 0] + "\t");
                Console.Write(res[i, 1]);
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
