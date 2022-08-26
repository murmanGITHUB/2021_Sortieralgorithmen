using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_Sortieralgorithmen
{
    class MergeSort
    {
        int[] sortArray;
        public Form myForm;
        int posX = 20;
        int posY = 20;
        public int[] mergeSort(int[] array, TextBox textbox)
        {
            this.sortArray = sort(array, textbox);
            return this.sortArray;
        }


        public int[] sort(int[] array, TextBox textbox)
        {
            posX = posX;
            posY = posY + 25;

            if (array.Length > 1)//Abbruchbedingung für den rekursiven Aufruf
            {
                int mitte = array.Length / 2; //Mitte bestimmen
                //textbox.Text += ("Mitte pos: " + mitte + " Mitte ele: " + array[mitte] + "\r\n");

                int[] links = new int[mitte];//neues Array ertstellen - linke Seite
                for (int i = 0; i < links.Length; i++){links[i] = array[i];}//Array links füllen


                int[] rechts = new int[array.Length - mitte];//neues Array erstellen - rechte Seite
                for (int i = mitte; i < array.Length; i++){rechts[i - mitte] = array[i]; }//Array rechts füllen
                

                //rekursiver Aufruf - Solange, mehr als ein Element im Array
                links  = sort(links, textbox);
                rechts = sort(rechts, textbox);

                return merge(links,rechts);//linke und rechte Seite sortiert mergen
            }
            return array;
        }


        public int[] merge(int[] links, int[] rechts)
        {
            int[] mergeArray = new int[links.Length + rechts.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < links.Length && j < rechts.Length)
            {
                if (links[i] < rechts[j])    //Wenn der Wert in links an der Stelle i < dem Wert in rechts an der Stelle j
                {
                    mergeArray[k] = links[i];
                    k++;
                    i++;
                }
                else
                {
                    mergeArray[k] = rechts[j];
                    k++;
                    j++;
                }
            }
            //Eines der Array ist bereits leer?
            while (i < links.Length) { mergeArray[k] = links[i]; k++; i++; } //Fall 1: Array a noch nicht leer
            while (j < rechts.Length) { mergeArray[k] = rechts[j]; k++; j++; } //Fall 2:  Array b noch nicht leer

            return mergeArray;
        }
    }
}
