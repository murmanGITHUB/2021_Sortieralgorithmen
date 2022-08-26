using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_Sortieralgorithmen
{
    class Bubblesort
    {
        public int[] bubbleSort(int[] a)
        {   // statische Methode sort
            int count = 0;
            int tmp;                 // Hilfsvariable zum Tauschen
            bool getauscht;          // merkt sich, ob getauscht

            do
            {
                getauscht = false;          // nimm an, dass nicht getauscht

                for (int i = 0; i < a.Length - 1; i++)
                {   // durchlaufe Array
                    count++;
                    if (a[i] > a[i + 1])
                    {                       // falls Nachbarn falsch herum
                        tmp = a[i];         // bringe
                        a[i] = a[i + 1];    // beide Elemente
                        a[i + 1] = tmp;     // in die richtige Ordnung
                        getauscht = true;   // vermerke, dass getauscht wurde


                    }
                }
            } while (getauscht);            // solange getauscht wurde
            return a;
        }
    }
}
