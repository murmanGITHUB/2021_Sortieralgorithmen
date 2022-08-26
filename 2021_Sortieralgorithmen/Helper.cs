using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_Sortieralgorithmen
{
    class Helper
    {



        //SchowArray
        public static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("," + array[i]);
            }
            Console.WriteLine("\r\n");
        }
        //SchowArrayin TextBox
        public static void ShowArrayInTextBox(int[] array, TextBox textbox)
        {
            textbox.Clear();
            textbox.Text += "Array Ausgabe\r\n";
            for (int i = 0; i < array.Length; i++)
            {
                textbox.Text += "," + array[i];
            }
            //textbox.Text += "|\r\n";
        }

        //CreateArray
        public static int[] CreateArray(int anzahl)
        {
            int[] array = new int[anzahl];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Array created.");
            return array;
        }
        //CreateReverseArray
        public static int[] CreateReverseArray(int anzahl)
        {
            int[] array = new int[anzahl];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array.Length-1-i;
            }
            Console.WriteLine("Reverse Array created.");
            return array;
        }
        //CreateRandomArray
        public static int[] CreateRandomArray(int anzahl, int unten, int oben)//anzahl = Länge des Array, unten und oben = Grenzen
        {
            int[] array = new int[anzahl];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(unten, oben);
            }
            Console.WriteLine("Array created.");
            return array;
        }

        private static void sortierung()
        {
            int[] arr = { 9, 4, 4, 4, 8, 7, 6, 5, 4, 3, 5, 5, 2, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) // Fehler
                    {
                        arr[j] = 0;

                    }
                }
            }
        }


        public static void createLable(Form myForm, int[] array, int posXstart, int posYstart)
        {
            int posX = posXstart;
            int posY = posYstart;
            Label[] lableArray = new Label[array.Length];
            int anzahl = array.Length;
            Console.WriteLine(array.Length);
            for (int i = 0; i < anzahl; i++)
            {
                posX = posX + 21;
                lableArray[i] = new Label();
                lableArray[i].Text = array[i].ToString();
                lableArray[i].Width = 20;
                lableArray[i].Height = 20;
                lableArray[i].BorderStyle = BorderStyle.FixedSingle;
                lableArray[i].Location = new Point(posX, posY);
       
                myForm.Controls.Add(lableArray[i]);
            }
        }


    }
}
