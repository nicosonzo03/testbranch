using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDLL;


namespace ORDINATEMPERATURA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num = 5000;
        int[] eletemperature = new int[5000];
        int[] bubblesort = new int[5000];
        int[] quicksort = new int[5000];
        int[] selectionsort = new int[5000];
        


        private void carica_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            listBox1.Items.Clear();
            int x = default(int);
            Random random = new Random();
            int numero = default(int);

            while (x!=5000)
            {
                numero = random.Next(70);
                eletemperature[x]= numero;
                listBox1.Items.Add(eletemperature[x]);
                x = x + 1;
            }

        }

        private void bubble_click(object sender, EventArgs e)
        {
            bubblesort = eletemperature;
            listBox2.Items.Clear();
            int x = default(int);

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            stopwatch.Start();
            funzioni.bubblesort(bubblesort, num);
            stopwatch.Stop();
            
            while(x<num)
            {
                listBox2.Items.Add(eletemperature[x]);
                x = x + 1;
            }
            label5.Text = string.Format(stopwatch.ElapsedMilliseconds.ToString()+" ms");
            label5.Visible = true;
        }

        private void quick_click(object sender, EventArgs e)
        {
            quicksort = eletemperature;
            listBox2.Items.Clear();

            int left= 0;
            int right = num-1;
            int x = default(int);

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            stopwatch.Start();
            funzioni.quicksort(quicksort, left, right);
            stopwatch.Stop();

            
            while(x<num)
            {
                listBox2.Items.Add(eletemperature[x]);
                x = x + 1;
            }
            label6.Text = string.Format(stopwatch.ElapsedMilliseconds.ToString()+" ms");
            label6.Visible = true;
        }

        private void selection_click(object sender, EventArgs e)
        {

            selectionsort = eletemperature;
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            stopwatch.Start();
            funzioni.selectionsort(selectionsort, num);
            stopwatch.Stop();

            listBox2.Items.Clear();

            int x = default(int);
            while (x<num)
            {
                listBox2.Items.Add(eletemperature[x]);
                x = x + 1;
            }
            label7.Text = string.Format(stopwatch.ElapsedMilliseconds.ToString()+" ms");
            label7.Visible = true;
        }

        private void annulla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Array.Clear(eletemperature, 0, 365);
            Array.Clear(bubblesort, 0, 365);
            Array.Clear(quicksort, 0, 365);
            Array.Clear(selectionsort, 0, 365);
            label5.Visible=false;
            label6.Visible = false;
            label7.Visible = false;
        }
    }
}
