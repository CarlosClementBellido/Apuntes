using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main()
        {
            /*  Declaración 1   UNIDIMENSIONAL  */
            string[] matrizDeCadenas1 = new string[]
            {
                "Hola", "Mundo"
            };

            /*  Declaración 2   UNIDIMENSIONAL  */
            string[] matrizDeCadenas2 = new string[3];

            /*  Declaración 1   MULTIDIMENSIONAL    */
            int[,] matrizMultidimensional1 = new int[,]
                { 
                        { 50, 120, 100 },
                        { 10, 80, 110 },
                        { 130, 40, 60 }
                };

            /*  Declaración 2   MULTIDIMENSIONAL    */    
            int[,] matrizMultidimensional2 = new int[3,3];

            matrizMultidimensional2[0, 0] = 50;
            matrizMultidimensional2[0, 1] = 120;
            matrizMultidimensional2[0, 2] = 100;

            matrizMultidimensional2[1, 0] = 10;
            matrizMultidimensional2[1, 1] = 80;
            matrizMultidimensional2[1, 2] = 110;

            matrizMultidimensional2[2, 0] = 60;
            matrizMultidimensional2[2, 1] = 40;
            matrizMultidimensional2[2, 2] = 130;

            /*  Declaración 1   ESCALONADA  */
            int[][] matrizEscalonada1 = new int[][]
            {
                new int[]
                {
                    50, 120, 100,
                    180, 60, 20
                },
                new int[]
                {
                    10, 80, 110
                },
                new int[]
                {
                    60, 40, 130,
                    130
                }
            };

            /*  Declaración 2   ESCALONADA  */
            int[][] matrizEscalonada2 = new int[3][];

            matrizEscalonada2[0] = 
                new int[] 
                {
                    50, 120, 100,
                    180, 60, 20
                };
            matrizEscalonada2[1] = 
                new int[] 
                {
                    10, 80, 110
                };
            matrizEscalonada2[2] = 
                new int[] 
                {
                    60, 40, 130,
                    130
                };

        }
    }
}
