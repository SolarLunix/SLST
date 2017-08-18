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
using System.Diagnostics;
using System.Collections;

namespace SLST
{
    public partial class Form1 : Form
    {
        ArrayList fileNames;

        public Form1()
        {
            InitializeComponent();

            fileNames = new ArrayList();

            //Make the default colour Red
            blast.BackColor = Color.Red;
            mega.BackColor = Color.Red;

            //Set up the Command line
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;

            //Check if Blastn is installed
            cmd.Start();
            cmd.StandardInput.WriteLine("blastn -version");
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            String str = cmd.StandardOutput.ReadToEnd();
            if (str.Contains("Package"))
            {
                blast.BackColor = Color.Green;
            }

            //Check if MegaCC is installed
            cmd.Start();
            cmd.StandardInput.WriteLine("megacc -v");
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            str = cmd.StandardOutput.ReadToEnd();
            Console.WriteLine(str);
            if (str.Contains("Evolution"))
            {
                mega.BackColor = Color.Green;
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "fasta files (*.fasta)|*.fasta|All files (*.*)|*.*";
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
                            String file = openFileDialog1.FileName;
                            System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                            Console.WriteLine("Reading in File");
                            while (!sr.EndOfStream)
                            {
                                str = sr.ReadLine();
                            }
                            Console.WriteLine("File Read in");
                            Console.WriteLine(str);
                            sr.Close();

                            String[] fileSplit = file.Split('\\');
                            String name = fileSplit.Last();
                            fileNames.Add(name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void updateFileList()
        {
            fileList.
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
