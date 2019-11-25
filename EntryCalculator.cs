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
    public partial class EntryCalculator : Form
    {
        public delegate void OperasiEventHandler(int index, int a, int b);

        public event OperasiEventHandler OnPerhitungan;

        

        public EntryCalculator()
        {
            InitializeComponent();
            comboBox1.Items.Add("...");
            comboBox1.Items.Add("Penjumlahan");
            comboBox1.Items.Add("Pengurangan");
            comboBox1.Items.Add("Perkalian");
            comboBox1.Items.Add("Pembagian");
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int NilaiA = int.Parse(textBox1.Text);
            int NilaiB = int.Parse(textBox2.Text);

            if(comboBox1.SelectedIndex == 1)
            {
                OnPerhitungan(1, NilaiA, NilaiB);
            }
            else if(comboBox1.SelectedIndex == 2)
            {
                OnPerhitungan(2, NilaiA, NilaiB);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                OnPerhitungan(3, NilaiA, NilaiB);
            }
            else if(comboBox1.SelectedIndex == 4)
            {
                OnPerhitungan(4, NilaiA, NilaiB);
            }
            this.Close();
        }
    }
}
