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
        public Form5(string playerName, string playerScore)
        {
            InitializeComponent();
            // get name and score from frmGame and show in lblPlayerName and lblPlayerScore         
            lblplayername.Text = playerName;
            lblplayerscore.Text = playerScore;

        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void EXITbutton_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Menu")
                    Application.OpenForms[i].Close();
            }
        }
    }
}
