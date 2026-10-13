using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace usúario_e_pets
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCrudPET_Click(object sender, EventArgs e)
        {
            Form3 cadastroPet = new Form3();
            cadastroPet.Show();

            this.Hide();
        }
    }
}
