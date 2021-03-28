using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comoression_d_images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        // Processus de compression
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
                
            {
                if (codec.FormatID==format.Guid)
                {
                    return codec;
                }

               
            }
            return null;
        }

        private string CompressImage(string ImageSource, int Quality, string DossierDeSortie)
        {
            using (Bitmap mybitmap = new Bitmap(@ImageSource))
            {
                ImageCodecInfo jpgEndcoder = GetEncoder(ImageFormat.Jpeg);
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;


                EncoderParameter myEncoderParameter = new EncoderParameter(1);
                EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, Quality);
                myEncoderParameter.Param[0] = myEncoderParameter;

            }
        }
    }
}
