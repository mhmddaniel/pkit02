using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System;


namespace PKIT02
{
    public partial class InputWorker : Form
    {
        string desktopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        string cs = @"URI=file:C:\Users\mhmdd\Documents\test.db";

        public InputWorker()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {


             var con = new SQLiteConnection(cs);
        }
    }
}
