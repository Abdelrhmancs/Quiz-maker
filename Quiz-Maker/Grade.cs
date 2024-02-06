using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CREATE_QUIZ
{
    public partial class Grade : Form
    {
        public Grade()
        {
            InitializeComponent();
        }

        public void SetData(string data, string total)
        {
            // Do something with the data (e.g., display it in a label)
            label2.Text = data + " / " + total;
        }

        private void Grade_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}