using Mnogookno.Окны;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mnogookno
{
    public class ChangeImage
    {
        public PictureBox CImage(string img, PictureBox pb)
        {
            switch(img)
            {
                case "lukgribi": pb.Image = Mnogookno.Properties.Resources.lukgribi; break;
                case "kolbasa": pb.Image = Mnogookno.Properties.Resources.kolbasa; break;
                case "cheese": pb.Image = Mnogookno.Properties.Resources.cheese; break;
                case "grushchick": pb.Image = Mnogookno.Properties.Resources.grushchick; break;
                case "perchic": pb.Image = Mnogookno.Properties.Resources.perchic;break;
                case "kolbasaonly": pb.Image = Mnogookno.Properties.Resources.kolbasaonly;break;
                case "ananas": pb.Image = Mnogookno.Properties.Resources.ananas;break;
                case "sample": pb.Image = Mnogookno.Properties.Resources.sample;break;
            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            return pb;
        }
    }
}