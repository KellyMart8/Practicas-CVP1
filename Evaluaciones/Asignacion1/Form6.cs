using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignacion1
{
    public partial class Form6 : Form
    {
        int n = 0;
        int i;
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            txtSubtotal.Enabled = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double precio, cantidad, stp;
            precio = Convert.ToDouble(mtPrecio.Text);
            cantidad = Convert.ToDouble(mtCantidad.Text);
            stp = precio * cantidad;
            txtSubtotal.Text = stp.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int f = dataGridView1.Rows.Add();

            dataGridView1.Rows[f].Cells[0].Value = mtPrecio.Text;
            dataGridView1.Rows[f].Cells[1].Value = mtCantidad.Text;
            dataGridView1.Rows[f].Cells[2].Value = txtSubtotal.Text;

            mtCantidad.Clear();
            mtPrecio.Clear();
            txtSubtotal.Clear();
            double stf = 0;

            for (i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                stf = stf + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                txtSubTFact.Text = stf.ToString();  
            }

            double totf;
            totf = stf * 1.15;
            txtTotFact.Text = totf.ToString();
        }

        
    }
}
