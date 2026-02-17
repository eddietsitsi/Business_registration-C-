using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trying_something
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {

            txtbusinessemail.ResetText();
            txtlocation.ResetText();
            txtmission.ResetText();
            txtnamebusiness.ResetText();
            txtreenterbusiness.ResetText();
            txtserviceandproduct.ResetText();
            txtvision.ResetText();
            rbtnlimited.Checked = false;
            
            rbtnprivate.Checked = false;
            rbtnpublic.Checked = false;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration cost is R250 would you like to continue?");
        }
    }
}
