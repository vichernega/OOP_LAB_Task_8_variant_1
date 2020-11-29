using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8_variant_1
{
    public partial class Form1 : Form
    {
        private MyComplex A, B, C, D;
        private double num;
        public Form1()
        {
            InitializeComponent();
            ClearLabels();
        }

        private void btn_AplusB_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                C = A + B;
                DisplayResult("A + B = ", C);
            }
        }

        private void btn_AplusDouble_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                C = A + num;
                DisplayResult("A + double = ", C);
            }
        }

        private void btn_DoublePlusA_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                C = num + A;
                DisplayResult("double + A = ", C);
            }
        }

        private void btn_negativeC_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                C = - D;
                DisplayResult("- D = ", C);
            }
        }

        private void btn_AplusBplusCplusD_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                C = A + B + C + D;
                DisplayResult("A + B + C + D = ", C);
            }
        }

        private void btn_C_eqA_eqB_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                C = A = B = C;
                DisplayResult("A = B = C = ", C);
            }
        }
        // according to variant 1
        private void btn_subtract_sum_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                DisplayResult("(A + Bi) - (C + Di) = ", (A + B) - (C + D));
            }
        }

        private void btn_add_difference_Click(object sender, EventArgs e)
        {
            if (GetData())
            {
                DisplayResult("(A - C) + (B - D)i = ", (A - C) + (B - D));
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            ClearLabels();
            ClearTextBoxes();
        }

        private bool GetData()
        {
            try
            {
                A = new MyComplex(Convert.ToDouble(tb_A_Re.Text), Convert.ToDouble(tb_A_Im.Text));
                B = new MyComplex(Convert.ToDouble(tb_B_Re.Text), Convert.ToDouble(tb_B_Im.Text));
                C = new MyComplex(Convert.ToDouble(tb_C_Re.Text), Convert.ToDouble(tb_C_Im.Text));
                D = new MyComplex(Convert.ToDouble(tb_D_Re.Text), Convert.ToDouble(tb_D_Im.Text));
                num = Convert.ToDouble(tb_double.Text);
                return true;
            }
            catch 
            { 
                label_alert.Text = "Неправильне введення.\n     Очікується число."; 
                return false; 
            }
        }

        private void ClearLabels()
        {
            label_alert.Text = String.Empty;
            label_result.Text = String.Empty;
        } 
        private void ClearTextBoxes()
        {
            tb_A_Re.Text = "0";
            tb_A_Im.Text = "0";

            tb_B_Re.Text = "0";
            tb_B_Im.Text = "0";

            tb_C_Re.Text = "0";
            tb_C_Im.Text = "0";

            tb_D_Re.Text = "0";
            tb_D_Im.Text = "0";

            tb_double.Text = "0";
        }
        private void DisplayResult(string str, MyComplex myComplex)
        {
            label_result.Text = str + myComplex.ToString();
        }
    }
}
