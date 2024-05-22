using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String playerone;
        String playertwo;
        String playerthree;
        String playerfour;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerone = textBox1.Text;
            playertwo = textBox2.Text;
            playerthree = textBox3.Text;
            playerfour = textBox4.Text;

            richTextBox1.Text = playerone;
            richTextBox2.Text = playertwo;
            richTextBox3.Text = playerthree;
            richTextBox4.Text = playerfour;

            RegistryKey key = Registry.CurrentUser.CreateSubKey("Uygulama");
            key.SetValue("PlayerOne", playerone);
            key.SetValue("PlayerTwo", playertwo);
            key.SetValue("PlayerThree", playerthree);
            key.SetValue("PlayerFour", playerfour);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Text = playerone;
            textBox6.Text = playertwo;
            textBox7.Text = playerone;
            textBox8.Text = playerfour;
            textBox9.Text = playerone;
            textBox10.Text = playerfour;
            textBox11.Text = playertwo;
            textBox12.Text = playerthree;
            textBox13.Text = playertwo;
            textBox14.Text = playerfour;
            textBox15.Text = playerthree;
            textBox16.Text = playerfour;

            RegistryKey key = Registry.CurrentUser.CreateSubKey("Uygulama");
            key.SetValue("TextBox5", textBox5.Text);
            key.SetValue("TextBox6", textBox6.Text);
            key.SetValue("TextBox7", textBox7.Text);
            key.SetValue("TextBox8", textBox8.Text);
            key.SetValue("TextBox9", textBox9.Text);
            key.SetValue("TextBox10", textBox10.Text);
            key.SetValue("TextBox11", textBox11.Text);
            key.SetValue("TextBox12", textBox12.Text);
            key.SetValue("TextBox13", textBox13.Text);
            key.SetValue("TextBox14", textBox14.Text);
            key.SetValue("TextBox15", textBox15.Text);
            key.SetValue("TextBox16", textBox16.Text);

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            button4.Visible = true;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int RastgeleSayi1 = rnd.Next(0, 100);
            int RastgeleSayi2 = rnd.Next(0, 100);
            int RastgeleSayi3 = rnd.Next(0, 100);
            int RastgeleSayi4 = rnd.Next(0, 100);
            int RastgeleSayi5 = rnd.Next(0, 100);
            int RastgeleSayi6 = rnd.Next(0, 100);
            int RastgeleSayi7 = rnd.Next(0, 100);
            int RastgeleSayi8 = rnd.Next(0, 100);
            int RastgeleSayi9 = rnd.Next(0, 100);
            int RastgeleSayi10 = rnd.Next(0, 100);
            int RastgeleSayi11 = rnd.Next(0, 100);
            int RastgeleSayi12 = rnd.Next(0, 100);
            int RastgeleSayi13 = rnd.Next(0, 100);

            label13.Text = RastgeleSayi1 + "-" + RastgeleSayi2;
            label14.Text = RastgeleSayi3 + "-" + RastgeleSayi4;
            label15.Text = RastgeleSayi5 + "-" + RastgeleSayi6;
            label16.Text = RastgeleSayi7 + "-" + RastgeleSayi8;
            label17.Text = RastgeleSayi9 + "-" + RastgeleSayi10;
            label18.Text = RastgeleSayi11 + "-" + RastgeleSayi12;

            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
           
            label19.Text = playerone;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            richTextBox1.BackColor = dialog.Color;
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            richTextBox2.BackColor = dialog.Color;
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            richTextBox3.BackColor = dialog.Color;
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.AllowFullOpen = true;
            dialog.ShowHelp = true;
            if (dialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            richTextBox4.BackColor = dialog.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Uygulama");

            if (key != null)
            {
                textBox1.Text = key.GetValue("PlayerOne", "").ToString();
                textBox2.Text = key.GetValue("PlayerTwo", "").ToString();
                textBox3.Text = key.GetValue("PlayerThree", "").ToString();
                textBox4.Text = key.GetValue("PlayerFour", "").ToString();
            }
        }
    }
}
