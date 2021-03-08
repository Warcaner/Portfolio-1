using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 1000;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Red); // Paint exterior of our shape
            Brush myBrush = new SolidBrush(Color.AliceBlue); // Paint interior of our shape

            g.DrawRectangle(myPen, 100, 100, 200, 200);
           g.DrawLine(myPen, 100, 100, 500, 500);
            g.DrawEllipse(myPen, 100, 100, 500, 500);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Constructor(object sender,System.EventArgs e)
        {
            // The CheckBox control's Text property is changed each time the
            // control is clicked, indicating a checked or unchecked state.  
            if (checkBox1.Checked)
            {
                MessageBox.Show("Hello");
            }
            else
            {
                checkBox1.Text = "Unchecked";
            }

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }
    }
}