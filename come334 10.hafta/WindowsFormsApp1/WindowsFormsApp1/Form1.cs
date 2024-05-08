using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawBranch(Graphics gr , Pen pen,int depth, float x, float y,  float length, float theta,float lengt_scale,float dtheta)
        {
            float x1 = (float)(x + length*Math.Cos(theta));
            float y1 =(float)(y + length*Math.Sin(theta));
            gr.DrawLine(pen, x, y, x1, y1);
            // ıf depth>1 , draw the attached branches.
            if(depth > 1 ) {
            
            DrawBranch(gr,pen, depth - 1, x1,y1,length* lengt_scale, theta+dtheta,lengt_scale,dtheta);
            DrawBranch(gr, pen, depth - 1, x1, y1, length * lengt_scale, theta - dtheta, lengt_scale, dtheta);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int depth = (int)numericUpDown1.Value;
            if (!float.TryParse(textBox1.Text, out float lengt_scale))
            {
                // Display an error message if parsing fails
                MessageBox.Show("Invalid length scale value!");
                return;
            }




            // Call the DrawBranch method with the specified depth
            using (Graphics gr = pictureBox1.CreateGraphics())
            {
                // Define parameters for the DrawBranch method
                float x = pictureBox1.Width / 2; // X-coordinate of the starting point
                float y = pictureBox1.Height;     // Y-coordinate of the starting point
                float length = 100;                // Length of the main branch
                float theta = -(float)Math.PI / 2; // Initial angle (straight up)
                      // Length scale factor for child branches
                float dTheta = (float)Math.PI / 4; // Angle change for child branches

                // Create a Pen for drawing
                using (Pen pen = new Pen(Color.Black))
                {
                    // Clear the PictureBox before drawing
                    gr.Clear(Color.White);

                    // Call the DrawBranch method with the specified parameters
                    DrawBranch(gr, pen, depth, x, y, length, theta, lengt_scale, dTheta);
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Get the new length value from the NumericUpDown control
            float length = (float)numericUpDown2.Value;

            // Call the DrawBranch method with the updated length value and other parameters
            using (Graphics gr = pictureBox1.CreateGraphics())
            {
                // Get the depth value from the NumericUpDown control
                int depth = (int)numericUpDown1.Value;

                // Get the length scale value from the TextBox control
                if (!float.TryParse(textBox1.Text, out float lengthScale))
                {
                    // Display an error message if parsing fails
                    MessageBox.Show("Invalid length scale value!");
                    return;
                }

                // Define other parameters for the DrawBranch method
                float x = pictureBox1.Width / 2; // X-coordinate of the starting point
                float y = pictureBox1.Height;     // Y-coordinate of the starting point
                float theta = -(float)Math.PI / 2; // Initial angle (straight up)
                float dTheta = (float)Math.PI / 4; // Angle change for child branches

                // Create a Pen for drawing
                using (Pen pen = new Pen(Color.Black))
                {
                    // Clear the PictureBox before drawing
                    gr.Clear(Color.White);

                    // Call the DrawBranch method with the specified parameters
                    DrawBranch(gr, pen, depth, x, y, length, theta, lengthScale, dTheta);
                }
            }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            float dTheta = (float)numericUpDown3.Value;

            // Call the DrawBranch method with the updated dTheta value and other parameters
            using (Graphics gr = pictureBox1.CreateGraphics())
            {
                // Get the depth value from the NumericUpDown control
                int depth = (int)numericUpDown1.Value;

                // Get the length scale value from the TextBox control
                if (!float.TryParse(textBox1.Text, out float lengthScale))
                {
                    // Display an error message if parsing fails
                    MessageBox.Show("Invalid length scale value!");
                    return;
                }

                // Get the length value from the NumericUpDown control
                float length = (float)numericUpDown2.Value;

                // Define other parameters for the DrawBranch method
                float x = pictureBox1.Width / 2; // X-coordinate of the starting point
                float y = pictureBox1.Height;    // Y-coordinate of the starting point
                float theta = -(float)Math.PI / 2; // Initial angle (straight up)

                // Create a Pen for drawing
                using (Pen pen = new Pen(Color.Black))
                {
                    // Clear the PictureBox before drawing
                    gr.Clear(Color.White);

                    // Call the DrawBranch method with the specified parameters
                    DrawBranch(gr, pen, depth, x, y, length, theta, lengthScale, dTheta);
                }
            }
        }
    }
}
