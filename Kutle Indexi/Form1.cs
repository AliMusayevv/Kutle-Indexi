using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;


namespace Kutle_Indexi
{
   
    


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double boy, ceki, kutleIndex;
                boy = Convert.ToDouble(textBoxB.Text);
                ceki = Convert.ToDouble(textBoxK.Text);
                kutleIndex = ceki / (boy * boy);
                label2.Text = "Kütlə indeksiniz =" + kutleIndex.ToString("#.##");
            }

            catch( Exception exkey )
            {

                MessageBox.Show(exkey.Message);    



            }



        }

        private void textBoxK_TextChanged(object sender, EventArgs e)


        {


            if (textBoxK.Text.Length > 0)
            {
                label2.Text = String.Empty;

            }



        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            // textBoxB.Style.Add("Border", "1px Solid");


            if (textBoxB.Text.Length > 0)
            {
                label2.Text = String.Empty;


            }
        }

        private void textBoxK_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)&& "";
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }


    
    }
}
