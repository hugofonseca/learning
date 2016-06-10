using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learning
{
    public partial class Form1 : Form
    {
        int[] oi = new int[5] { 1, 2, 3, 4, 5 };
        public Form1()
        {
            InitializeComponent();
        }
        // hvsdgvgf
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine(Oi(oi));
        }
        public int Oi(int[] valores)
        {
            int total = 0;
            foreach (int i in valores)
            {
                total += i;
            }
            return total;
        }
    }
}
