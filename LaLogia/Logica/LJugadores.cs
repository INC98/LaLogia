using Logica.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LJugadores : Librarys
    {
        private List<TextBox> listTextBox;
        private PictureBox image;
        

        public LJugadores(List<TextBox> listTextBox, object[] objetos)
        {
            this.listTextBox = listTextBox;
            image = (PictureBox)objetos[0];
            
        }

        public void Registrar()
        {
            var imageArray = uploadimage.ImageToByte(image.Image);
        }
    }
}
