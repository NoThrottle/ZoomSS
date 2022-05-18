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

namespace ZoomSS
{
    public partial class Form3 : Form
    {
        //This Partial Class controls where the settings are saved and controls the settings form.

        static string defaultpath = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)), "ZoomSS");
        static string path = defaultpath;
        public override string Text { get; set; }

        public static string MainPath()
        {

            //if settings file is not found, return default and create the file. If it is found, return what is written.
            if (!File.Exists(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "ZoomSS", 
                        "path.txt")))//ProgramFiles-ZoomSS-path.txt
            {
                WritetoDisc(defaultpath);
                return defaultpath;
            }
            else
            {
                string _mainpath = path;
                return _mainpath;
            }
        }

        public Form3()
        {
            InitializeComponent();
            PathDisplay();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    path = fbd.SelectedPath;
                    textBox1.Text = path;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PathDisplay();
        }

        private void PathDisplay()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string pictures = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                path = System.IO.Path.Combine(pictures, "ZoomSS");
                textBox1.Text = path;
                label3.Text = "Path: " + path;
                WritetoDisc(path);

            }
        }

        private static void WritetoDisc(string savepath)
        {
            //Saves the Path to settings folder in Program Files
            string settings = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); //get Appdata
            string subpath = System.IO.Path.Combine(settings, "ZoomSS", "path.txt");//ProgramFiles - ZoomSS - path.txt

            if(Directory.Exists(Path.Combine(settings, "ZoomSS")))
            {
                System.IO.File.WriteAllText(@subpath, savepath);
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(settings, "ZoomSS"));
                System.IO.File.WriteAllText(@subpath, savepath);
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form ZoomSS = new ZoomSS();
            ZoomSS.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
