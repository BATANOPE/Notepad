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
    public partial class Form1 : Form
    {

        //путь к файлу
        string way;

        //проверка, был ли сохранен файл
        bool saved = false;

        //если было нажато создать файл и отмена
        bool cancel = false;

        Form2 SaveOrNo = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //открытие файла
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //запоминаем путь к файлу
                way = openFileDialog1.FileName;

                //считываем текст из файла
                richTextBox.LoadFile(way, RichTextBoxStreamType.PlainText);
            }
           

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (.txt)|*.txt";
            saveFileDialog1.DefaultExt = "*.txt";

            //если уже и так сохранен
            if (saved == true)
                return;

            //если уже выбран путь
            if (way != null)
            {
                richTextBox.SaveFile(way, RichTextBoxStreamType.PlainText);
                saved = true;
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //прописываем путь
                    way = saveFileDialog1.FileName;
                    //Сохраняем
                    richTextBox.SaveFile(way, RichTextBoxStreamType.PlainText);

                    saved = true;
                }
                else
                    MessageBox.Show("Вы выбрали не текстовый файл", "Error");
            } 
            
        }

        //если ричтекстбокс был изменен, то считаем, что не сохранен
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (.txt)|*.txt";
            saveFileDialog1.DefaultExt = "*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //сохраняем
                richTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                way = saveFileDialog1.FileName;
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cancel = false;

            if (way != null)
            {
                richTextBox.SaveFile(way, RichTextBoxStreamType.PlainText);
                saved = false;
                richTextBox.Clear();
            }
            else
            {
                SaveOrNo.cancel = cancel;
                //SaveOrNo.Tag = this;
                SaveOrNo.Show();
               
                if (cancel == false)
                    richTextBox.Clear();

            }
                       

            way = null;
            
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == true)
                this.Close();
            else
            {
                SaveOrNo.Show();

                if (cancel == false)
                    return;
            }
        }
    }
    
}
