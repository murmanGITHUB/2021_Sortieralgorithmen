using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2021_Sortieralgorithmen
{
    public partial class Form1 : Form
    {

        //Attribute
        Selectionsort mySelectionSort = new Selectionsort();
        Insertionsort myInsertionSort = new Insertionsort();
        Bubblesort myBubbleSort = new Bubblesort();
        MergeSort myMergeSort = new MergeSort();
        QuickSort myQuickSort = new QuickSort();
        double zeitdauer = 0;
        double startzeit = 0;
        double endzeit = 0;

        Helper myHelper = new Helper();
        int[] myIntArray;
        int[] array = { 1,2,3,4,5,6,7,8,9};
     

        //Konstruktor
        public Form1()
        {
            InitializeComponent();
            
        }
  

        private void Form1_Load(object sender, EventArgs e)
        {
 
            textBoxAnzahlElemente.Text = Convert.ToString(100);
            myMergeSort.myForm = this;

        }


        //Selectionsort
        private void Button4_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Selectionsort Anzahl Elemente: " + array.Length + "\r\n";

            //Zeiterfassung
            var beginnTime = DateTime.UtcNow;
            string beginnTimeString = beginnTime.ToString("HH:mm:ss.fffff");
            textBoxInfo.Text += "Beginn Zeit: " + beginnTimeString + "\r\n";

            //Sortierung
            array = mySelectionSort.selectionSort(array);

            //Zeiterfassung
            var endTime = DateTime.UtcNow;
            string endTimeString = endTime.ToString("HH:mm:ss.fffff");
            var seconds = System.Math.Abs((endTime - beginnTime).TotalSeconds);

            //Ausgaben
            textBoxInfo.Text += "Ende Zeit: " + endTimeString + "\r\n";
            textBoxInfo.Text += "Dauer: " + seconds + "\r\n";
            //Helper.ShowArrayInTextBox(array, textBox1);
        }

        //InsertionSort

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Insertionsort Anzahl Elemente: " + array.Length + "\r\n";

            //Zeiterfassung
            var beginnTime = DateTime.UtcNow;
            string beginnTimeString = beginnTime.ToString("HH:mm:ss.fffff");
            textBoxInfo.Text += "Beginn Zeit: " + beginnTimeString + "\r\n";

            //Sortierung
            array = myInsertionSort.insertionSort(array);

            //Zeiterfassung
            var endTime = DateTime.UtcNow;
            string endTimeString = endTime.ToString("HH:mm:ss.fffff");
            var seconds = System.Math.Abs((endTime - beginnTime).TotalSeconds);

            //Ausgaben
            textBoxInfo.Text += "Ende Zeit: " + endTimeString + "\r\n";
            textBoxInfo.Text += "Dauer: " + seconds + "\r\n";
            Helper.ShowArrayInTextBox(array, textBox1);
        }


        //Bubblesort
        private void Button3_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Bubblesort Anzahl Elemente: " + array.Length + "\r\n";

            //Zeiterfassung
            var beginnTime = DateTime.UtcNow;
            string beginnTimeString = beginnTime.ToString("HH:mm:ss.fffff");
            textBoxInfo.Text += "Beginn Zeit: " + beginnTimeString + "\r\n";

            //Sortierung
            array = myBubbleSort.bubbleSort(array);

            //Zeiterfassung
            var endTime = DateTime.UtcNow;
            string endTimeString = endTime.ToString("HH:mm:ss.fffff");
            var seconds = System.Math.Abs((endTime - beginnTime).TotalSeconds);

            //Ausgaben
            textBoxInfo.Text += "Ende Zeit: " + endTimeString + "\r\n";
            textBoxInfo.Text += "Dauer: " + seconds + "\r\n";
            //Helper.ShowArrayInTextBox(array, textBox1);
        }
        //Mergesort
        private void Button1_Click(object sender, EventArgs e)
        {
            
            textBoxInfo.Text = "Mergesort Anzahl Elemente: " + array.Length + "\r\n";

            //Zeiterfassung
            var beginnTime = DateTime.UtcNow;
            string beginnTimeString = beginnTime.ToString("HH:mm:ss.fffff");
            textBoxInfo.Text += "Beginn Zeit: " + beginnTimeString + "\r\n";

            //Sortierung
            array = myMergeSort.mergeSort(array, textBox1);

            //Zeiterfassung
            var endTime = DateTime.UtcNow;
            string endTimeString = endTime.ToString("HH:mm:ss.fffff");
            var seconds = System.Math.Abs((endTime - beginnTime).TotalSeconds);

            //Ausgaben
            textBoxInfo.Text += "Ende Zeit: " + endTimeString + "\r\n";
            textBoxInfo.Text += "Dauer: " + seconds + "\r\n";
            //Helper.ShowArrayInTextBox(array, textBox1);
        }

        //Quicksort
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "Quicksort Anzahl Elemente: " + array.Length + "\r\n";
            //Zeiterfassung
            var beginnTime = DateTime.UtcNow;
            string beginnTimeString = beginnTime.ToString("HH:mm:ss.fffff");
            textBoxInfo.Text += "Beginn Zeit: " + beginnTimeString + "\r\n";

            //Sortierung
            array = myQuickSort.quickSort(array,textBox1);
           
            //Zeiterfassung
            var endTime = DateTime.UtcNow;
            string endTimeString = endTime.ToString("HH:mm:ss.fffff");
            var seconds = System.Math.Abs((endTime - beginnTime).TotalSeconds);

            //Ausgaben
            textBoxInfo.Text += "Ende Zeit: " + endTimeString + "\r\n";
            textBoxInfo.Text += "Dauer: " + seconds + "\r\n";
            Helper.ShowArrayInTextBox(array, textBox1);
        }

        //Array erzeugen
        private void Button5_Click(object sender, EventArgs e)
        {
            int anzahl = Int32.Parse(textBoxAnzahlElemente.Text);
            array = Helper.CreateRandomArray(anzahl, 0, 100);
            //array = Helper.CreateReverseArray(anzahl);
            textBoxUnsortiert.Clear();
            textBoxUnsortiert.Text = "Array erzeugt Anz Ele: " + array.Length;
            //foreach (var x in array)Console.WriteLine(x);
            Helper.ShowArrayInTextBox(array, textBoxUnsortiert);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            zeitdauer++;
            textBoxInfo.Text = "Zeit in Millisekunden" + zeitdauer.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Array");
            Console.WriteLine(" ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Array Ende");
        }


    }
}
