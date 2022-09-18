using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resta_Propiedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //Objeto
            clresta pResta = new clresta();
            pResta.Nume1 = int.Parse(txtNum1.Text);
            pResta.Nume2 = int.Parse(txtNum2.Text);
            textBox3.Text = pResta.resta().ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            textBox3.Clear();
        }
    }
}
