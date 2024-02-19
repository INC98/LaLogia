using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaLogia
{
    public partial class Form1 : Form
    {
        private LJugadores jugador;
        public Form1()
        {
            InitializeComponent();

            // ver como agregar los otros campos que no sean textos -> seguro tenga que crear un objeto o lista con ese tipo de dato
            // sino dejarlo
            var listTextBox = new List<TextBox>(); //coleccion de objetos de la clase textbox
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxApellido);
            listTextBox.Add(textBoxNumero);
            Object[] objetos = { pictureBoxImage };
            jugador = new LJugadores(listTextBox, objetos); // objeto jugador q de parametros se le pasan los valores de los texts.

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            jugador.uploadimage.CargarImagen(pictureBoxImage);
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            jugador.textBoxEvent.textKeyPress(e);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (textBoxApellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellido.ForeColor = Color.Green;
                labelApellido.Text = "Apellido";
            }
        }
    

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            jugador.textBoxEvent.textKeyPress(e);
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            jugador.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumero.Text.Equals(""))
            {
                labelCamiseta.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelCamiseta.ForeColor = Color.Green;
                labelCamiseta.Text = "Numero camiseta";
            }
        }

        private void dateTimePickerNacimiento_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerNacimiento.Value != null)
            {
                labelNacimiento.ForeColor = Color.Green;
            }
            else
            {
                labelNacimiento.ForeColor = Color.LightSlateGray;
                labelNacimiento.Text = "Fecha de nacimiento";
            }
        }

        private void dateTimePickerNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //No anda del todo bien
        private void checkedListBoxPosiciones_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
            {
                labelPosiciones.ForeColor = Color.Green;
            }
            else
            {
                bool anyChecked = checkedListBoxPosiciones.CheckedItems.Count > 1 || (checkedListBoxPosiciones.CheckedItems.Count == 1 && e.NewValue == CheckState.Unchecked);

                if (anyChecked)
                {
                    labelPosiciones.ForeColor = Color.LightSlateGray;

                }
                else
                {
                    labelPosiciones.ForeColor = Color.Green;
                    labelPosiciones.Text = "Posiciones";
                }
            
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNombre.ForeColor = Color.Green;
                labelNombre.Text = "Nombre";
            }
        }

        private void checkedListBoxPosiciones_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listBoxPiernaH_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listBoxPiernaH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPiernaH.SelectedIndex != -1)
            {
                labelPiernaH.ForeColor = Color.Green;
            }
            else
            {
                labelPiernaH.ForeColor = Color.LightSlateGray;
                labelPiernaH.Text = "Pierna habil";
            }
        }

        private void numericUpDownPiernaM_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void numericUpDownPiernaM_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownPiernaM.Value>0)
            {
                labelPiernaM.ForeColor = Color.Green;
            }
            else
            {
                labelPiernaM.ForeColor = Color.LightSlateGray;
                labelPiernaM.Text = "Pierna Mala";
            }
        }

        private void numericUpDownSkills_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void numericUpDownSkills_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownSkills.Value > 0)
            {
                labelSkills.ForeColor = Color.Green;
            }
            else
            {
                labelSkills.ForeColor = Color.LightSlateGray;
                labelSkills.Text = "Skills";
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            jugador.Registrar();
        }
    }
}
