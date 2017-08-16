using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            blast.BackColor = Color.Red;
            mega.BackColor = Color.Red;
        }

        private void open_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "fasta files (*.fasta)|*.fasta|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            String str = "";
                            System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                            Console.WriteLine("Reading in File");
                            while (!sr.EndOfStream)
                            {
                                str = sr.ReadLine();
                            }
                            Console.WriteLine("File Read in");
                            Console.WriteLine(str);
                            sr.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void files_Enter(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
