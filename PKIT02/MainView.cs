using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKIT02
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            dateLabel.Text = date;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {

        }
    }
}
