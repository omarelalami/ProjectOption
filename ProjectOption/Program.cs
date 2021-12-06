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
            int n = 20;
            Etudiant et = new Etudiant(n);
            Option op = new Option();

            et.setListeE("", "", 0);
            et.setListeE("", "", 1);
            et.setListeE("", "", 2);
            op.range();
            et.setPetud("","","",1);
            et.setPetud("","","",2);
            et.setPetud("","","",3);       
            
            op.setnbA(20);
            int nbA = op.getnbA();
            op.setnbG(20);
            int nbG = op.getnbG();
            op.setnbR(20);
            int nbR = op.getnbR();
          ////********En haut juste un implémentetion de classe*********\\\\ 
          
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
          
          
          /////////////////////////////////********En bas  le début de l'algorithme de gale sheaply pour Sélectioner l'étudiante et leur choi *********\\\\
         
          List<string> libre = new List<string>(); //Liste des étudiante qui ont pas encore obtenir une place  
          for (int i = 0; i < et.getnbE(); i++)  /////En affecter le nom toute des étudiante de la classe
            {


                libre.Add(et.getnom(i));

            }
          string[,] res = new string[et.getnbE(), 2]; //le Tableau res de deux dimension retourne  un paire de nom et de option qui mérite l'tudiante
           int ir = 0;  //une indice de la table res
            int jr; //une indice de la table res
            int je = 0;
            int r = 0; //une indice du suppression sur la liste
            int n = 0; //une indice de la table Petud qui stcoker le nom de l'étudiante et leurs trois choix
            while (libre.Any())   ////La boucle While arreter si la liste des étudiante est vide
            {
                for (int i = 1; i < 4; i++)   


                {
                    jr = 0;
                    if ((et.Petud[je, i] == "abd") && nbA != 0)  //si l'étudiante choisir l'option abd et il ya des place sur cette option alors affcter a la table rses le choi et le nom
                    {                                            //et la boucle va arreter et le nombre des palces décrementer par 1
                        res[ir, jr] = et.Petud[n, 0]; //affectation  de nom
                        jr++; //la varible est incremente pour affecter la paire /l'option)
                        res[ir, jr] = "abd";   //affectation de l'option
                        nbA--;
                        i = 4;





                    }
                    else if (et.Petud[je, i] == "gl" && nbG != 0) sinon GL la meme procedure pour la condtion if
                    {
                        res[ir, jr] = et.Petud[n, 0];
                        jr++;
                        res[ir, jr] = "gl";
                        nbG--;
                        i = 4;

                    }
                    else if (et.Petud[je, i] == "asr" && nbR != 0)  sinon GL la meme procedure pour la condtion else if
                    {
                        res[ir, jr] = et.Petud[n, 0];
                        jr++;
                        res[ir, jr] = "asr";
                        nbR--;
                        i = 4;

                    }




                }

                ir++;
                je++;

                libre.Remove(et.getnom(r));
                r++;
                n++;

            }
            for (int i = 0; i < et.getnbE(); i++)  ///Affichge de résultat

            {
                Console.Write(res[i, 0] + "\t");
                Console.Write(res[i, 1]);
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
