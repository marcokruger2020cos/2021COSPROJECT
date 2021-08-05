using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021COSPROJECT
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            label3.Text = name;
            label4.Text = score;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
