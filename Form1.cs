using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace MergeFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string fileName1 = null;
        string fileName2 = null;

        public string BrowseFile()
        {
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string filename = System.IO.Path.GetFileName(path);
                //MessageBox.Show(path + filename); //debug
                return path;
            }
            else
            {
                return null;
            }
        }

        /*http://codeskaters.blogspot.ae/2015/11/c-easiest-csv-parser-built-in-net.html*/
        private void ParseFile(string filename)
        {
            using (TextFieldParser csvParser = new TextFieldParser(filename))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                //csvParser.ReadLine(); //Use this to get headings  

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    int arrayLength = fields.GetLength(0);
                    //MessageBox.Show(arrayLength.ToString());
                    string MMSID = fields[0];
                    string Title = fields[1];
                    MessageBox.Show(Title, "Titles");
                }
            }
        }

       

        private void buttonFile1_Click(object sender, EventArgs e)
        {
            fileName1 = BrowseFile();
            if (fileName1==null)
            {
                MessageBox.Show("No file choosen. Please try again.", "Warning");
            }
            else
            {
                MessageBox.Show(fileName1);
                textBoxFile1.Text = fileName1;
                buttonFile2.Enabled = true;
            }
            
        }

        private void buttonFile2_Click(object sender, EventArgs e)
        {
            fileName2 = BrowseFile();
            if (fileName2 == null)
            {
                MessageBox.Show("No file choosen. Please try again.", "Warning");
            }
            else
            {
                MessageBox.Show(fileName2);
                textBoxFile2.Text = fileName2;
            }
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            ParseFile(fileName1);
        }
    }
}
