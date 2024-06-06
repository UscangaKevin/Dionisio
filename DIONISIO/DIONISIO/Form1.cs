using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIONISIO
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox4_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox4.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            Form formulrio = new Form2();
            formulrio.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox1_Click(object sender, EventArgs e)
        {
           
            
            string nuevaVia = materialMaskedTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox2_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox2.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox3_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox3.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox5_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox4.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox6_Click(object sender, EventArgs e)
        {
            

            string nuevaVia = materialMaskedTextBox6.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox7_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox7.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox8_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox8.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox9_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox9.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox10_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox10.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox11_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox11.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox12_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox12.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox13_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox13.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialMaskedTextBox14_Click(object sender, EventArgs e)
        {
            string nuevaVia = materialMaskedTextBox14.Text.Trim();

            if (string.IsNullOrEmpty(nuevaVia))
            {
                MessageBox.Show("Por favor, ingresa un nombre de vía de administración válido.");
                return;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private bool validarCampos()
        {
            bool ok = true;
            if (txt_materialMaskedTextBox1.Text == "")
            {
                ok = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialMaskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR LETRAS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
           
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void materialMaskedTextBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("SOLO SE PUEDEN UTILIZAR NUMEROS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
