using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormHasilPerhitungan(int index, int a, int b)
        {
            var hitung = new Operasi();

            if(index == 1)
            {
                listBox1.Items.Add(string.Format("Hasil Penjumlahan : {0} + {1} = {2}", a, b, hitung.Penjumlahan(a, b)));
            }
            else if(index == 2)
            {
                listBox1.Items.Add(string.Format("Hasil Pengurangan : {0} - {1} = {2}", a, b, hitung.Pengurangan(a, b)));
            }
            else if (index == 3)
            {
                listBox1.Items.Add(string.Format("Hasil Perkalian : {0} * {1} = {2}", a, b, hitung.Perkalian(a, b)));
            }
            else if(index == 4)
            {
                listBox1.Items.Add(string.Format("Hasil Pembagian : {0} / {1} = {2}", a, b, hitung.Pembagian(a, b)));
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HitungClick(object sender, EventArgs e)
        {
            EntryCalculator entryCalculator = new EntryCalculator();

            entryCalculator.OnPerhitungan += FormHasilPerhitungan;
            entryCalculator.ShowDialog();
        }
    }
}
