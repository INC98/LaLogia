using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            // condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            // para no dar salto de linea si aprieto enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            // permite usar la tecla de borrar
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            // permite utilizar el espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public void numberKeyPress(KeyPressEventArgs e)
        {
            // condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            // para no dar salto de linea si aprieto enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            // no permite ingresar datos de tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            // permite usar la tecla de borrar
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            // permite no utilizar el espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = true; }
            else { e.Handled = true; }
        }
    }
}
