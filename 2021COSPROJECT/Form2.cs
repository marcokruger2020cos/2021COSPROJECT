using System;
using System.Windows.Forms;

namespace _2021COSPROJECT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
