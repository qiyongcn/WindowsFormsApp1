using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            for(int i=0; i< 100; i=i+5)
            { 
                chart1.Series[0].Points.AddXY(i,i*i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[1].Points.Clear();
            for (int i = 0; i < 100; i = i + 5)
            {
                chart1.Series[1].Points.AddXY(i+10, i * i);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
