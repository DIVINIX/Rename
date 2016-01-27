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

namespace Rename
{
    public partial class Rename : Form
    {
        string ext = "*";
        string bifore = "";
        string after = "";
        string path;
        int cpt;

        FileInfo[] files;
        FileInfo[] testFiles;

        public Rename()
        {
            InitializeComponent();
        }

        #region Choix du dossier et affichage des fichiers
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog opfd = new FolderBrowserDialog();
            if (opfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = opfd.SelectedPath;
                listBox2.ForeColor = Color.Red;
                listBox2.Items.Add(path);
            }

            DirectoryInfo dir = new DirectoryInfo(path);
            files = dir.GetFiles("*." + ext);
            cpt++;
            listBox1.Items.Add("Fichiers du  " + cpt + " rennomage.");
            foreach (FileInfo fichier in files)
            {
                
                listBox1.Items.Add(fichier.Name);
            }
        }
        #endregion

        #region Gestion de l'extention et des rajouts
        private void button2_Click(object sender, EventArgs e)
        {
            ext = textBox3.Text;
            button2.ForeColor = Color.Red;
        }

        private void extension_Click(object sender, EventArgs e)
        {
            bifore = textBox5.Text;
            extension.ForeColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            after = textBox7.Text;
            button3.ForeColor =  Color.Red;
        }
        #endregion

        #region Rennomage dans un dossier tmp
        private void renameCreate_Click(object sender, EventArgs e)
        {
            foreach (FileInfo fichier in files)
            {
                string NewDirectory = Path.Combine(path, "tmp");
                Directory.CreateDirectory(NewDirectory);
                string FileLocation = Path.Combine(path, fichier.Name);
                string NewFileLocation = Path.Combine(NewDirectory, bifore + Path.GetFileNameWithoutExtension(FileLocation) + after + "." + ext);
                File.Copy(FileLocation, NewFileLocation, true);
            }

            button2.ForeColor = Color.Black;
            extension.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            
            listBox2.Items.Add("Rennomage numéro " + cpt + " fait.");

        }
        #endregion

        #region Rennomage dans le meme dossier en supprimant les anciens fichiers
        private void renameDelete_Click(object sender, EventArgs e)
        {
            foreach (FileInfo fichier in files)
            {
                string NewDirectory = Path.Combine(path, "tmp");
                Directory.CreateDirectory(NewDirectory);
                string FileLocation = Path.Combine(path, fichier.Name);
                string NewFileLocation = Path.Combine(NewDirectory, bifore + Path.GetFileNameWithoutExtension(FileLocation) + after + "." + ext);
                File.Copy(FileLocation, NewFileLocation, true);
                File.Delete(FileLocation);

                string TestNewFileLocation = Path.Combine(path, bifore + Path.GetFileNameWithoutExtension(FileLocation) + after + "." + ext);

                DirectoryInfo dir = new DirectoryInfo(NewDirectory);
                testFiles = dir.GetFiles();

                foreach (FileInfo testFichier in testFiles)
                {
                    File.Move(NewFileLocation, TestNewFileLocation);
                    File.Delete(NewFileLocation);
                }
                Directory.Delete(NewDirectory);
            }

            button2.ForeColor = Color.Black;
            extension.ForeColor = Color.Black;
            button3.ForeColor = Color.Black;
            listBox2.Items.Add("Rennomage numéro " + cpt + " fait.");
        }
        #endregion
    }
}