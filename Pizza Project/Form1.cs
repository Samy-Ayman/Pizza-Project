using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(txtPassWord.Text == txtPassWord.Tag.ToString())
            {
                MessageBox.Show("The PassWord and UserName is Correct", "Message enter", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Form frm = new PizzaOptions();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("The passWord is Faild ,Please enter another PassWord ?","Message enter" ,MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button2);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
