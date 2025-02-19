using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B1_Calcualator_63_An
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cong_63_An_Click(object sender, EventArgs e)
        {
            int a_63_An, b_63_An, ketqua_63_An;
            a_63_An = int.Parse(txt1_63_An.Text);
            b_63_An = int.Parse(txt2_63_An.Text);
            Calculation_63_An c_63_An = new Calculation_63_An(a_63_An, b_63_An);
            ketqua_63_An = c_63_An.Execute_63_An("+");
            txtkq_63_An.Text = ketqua_63_An.ToString();
        }

        private void btn_Tru_63_An_Click(object sender, EventArgs e)
        {
            int a_63_An, b_63_An, ketqua_63_An;
            a_63_An = int.Parse(txt1_63_An.Text);
            b_63_An = int.Parse(txt2_63_An.Text);
            Calculation_63_An c_63_An = new Calculation_63_An(a_63_An, b_63_An);
            ketqua_63_An = c_63_An.Execute_63_An("-");
            txtkq_63_An.Text = ketqua_63_An.ToString();
        }

        private void btn_Nhan_63_An_Click(object sender, EventArgs e)
        {
            int a_63_An, b_63_An, ketqua_63_An;
            a_63_An = int.Parse(txt1_63_An.Text);
            b_63_An = int.Parse(txt2_63_An.Text);
            Calculation_63_An c_63_An = new Calculation_63_An(a_63_An, b_63_An);
            ketqua_63_An = c_63_An.Execute_63_An("*");
            txtkq_63_An.Text = ketqua_63_An.ToString();
        }

        private void btn_Chia_63_An_Click(object sender, EventArgs e)
        {
            int a_63_An, b_63_An, ketqua_63_An;
            a_63_An = int.Parse(txt1_63_An.Text);
            b_63_An = int.Parse(txt2_63_An.Text);
            Calculation_63_An c_63_An = new Calculation_63_An(a_63_An, b_63_An);
            ketqua_63_An = c_63_An.Execute_63_An("/");
            txtkq_63_An.Text = ketqua_63_An.ToString();
        }
    }
}
