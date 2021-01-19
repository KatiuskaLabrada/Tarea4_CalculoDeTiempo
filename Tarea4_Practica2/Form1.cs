using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_Practica2
{
    public partial class Form1 : Form
    {
        int initialDate, finalDate, noYear;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            years.Clear();
            cboInitialDate.SelectedIndex = -1;
            cboFinalDate.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            initialDate = Convert.ToInt32(cboInitialDate.SelectedItem);
            finalDate = Convert.ToInt32(cboFinalDate.SelectedItem);

            noYear = finalDate - initialDate;

            this.years.Text = noYear.ToString();
        }

        private void years_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
