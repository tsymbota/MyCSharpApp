using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public struct cl
    {
        public Color colorFalse;
        public Color colorTrue;
        public int n;
        public int Size;
    }
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public cl col;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            col.n = 6;              // Изначально число частиц в игре
            col.Size = 10;          // Начальный размер частиц

            col.colorFalse = Color.Red;   // Цвет проигрыша
            col.colorTrue = Color.Green;  // Цвет выигрыша
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
