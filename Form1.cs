using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            label1.Text = Int64.Parse(text1.Text) + Int64.Parse(text2.Text) + "";
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            label1.Text = Int64.Parse(text1.Text) - Int64.Parse(text2.Text) + "";
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            label1.Text = Int64.Parse(text1.Text) * Int64.Parse(text2.Text) + "";
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            if (text2.Text.Equals("0"))
            {
                label1.Text =  "Error al dividir por 0";
            }
            else
            {
                label1.Text = Int64.Parse(text1.Text) / Int64.Parse(text2.Text) + "";
            }
           
        }
    }
    }

