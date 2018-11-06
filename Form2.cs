using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class Form2 : Form
    {
        public bool cancel;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (.txt)|*.txt";
            saveFileDialog1.DefaultExt = "*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

            //    ((Form1)this.Tag).richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);                             
            }
            else
                MessageBox.Show("Access is denied", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.Hide();
        }

        private void btDontSave_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Hide();
        }
    }
}
