using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace Conversor
{
    public partial class Convertir : Form
    {
        Hexadecimal hexa;
        BLLHexa bllHexa;
        public Convertir()
        {
            InitializeComponent();
            hexa = new Hexadecimal();
            bllHexa = new BLLHexa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hexa.Numero = textBox1.Text;
            MessageBox.Show( bllHexa.DevolverDecimal(hexa).ToString());
        }
    }
}
