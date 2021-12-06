using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_ejercicio02
{
    public partial class frmEjercicio02 : Form
    {
        public frmEjercicio02()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //valido si el usuario ingresó una frase
            if(this.txtString.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingresa una frase...");
                //ubica el cursor en el cuadro de texto txtString
                this.txtString.Focus();
            }

            // creo el array de palabras
            string[] palabras = this.txtString.Text.Split(' ', ',', '.', ';');
            this.lstPalabras.Items.Clear();

            //leno el listbox 
            for (int i = 0; i < palabras.Length; i++)
            {
                if(palabras[i].Length > 0)
                this.lstPalabras.Items.Add(palabras[i] + " --> " + palabras[i].Length + " caracteres...");
            }
        }
    }
}
