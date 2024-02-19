using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class UploadImage
    {   
        // CARGAR IMAGEN
        private OpenFileDialog fd = new OpenFileDialog(); //objeto privado de la clase

        public void CargarImagen(PictureBox pictureBox)
        {
            pictureBox.WaitOnLoad = true; //cuando cargue una imagen se cargue tambien en el pictureBox
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"; //Extensiones de archivos
            fd.ShowDialog();
            if(fd.FileName != string.Empty) // verifico si el objeto es vacio.Si no es vacio tiene el nombre del archivo seleccionado
            {
                pictureBox.ImageLocation = fd.FileName; //le paso la url de la imagen
            }
        }

        public byte[] ImageToByte(Image img)
        {
            var converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}
