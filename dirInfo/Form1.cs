using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dirInfo
{
    public partial class Form1 : Form
    {
        string selectedDirectory;
        List<string> folderNamesList = new List<string>();
        string textFilePath;

        public Form1()
        {
            InitializeComponent();


            SetSelectedDirectory();



            selectDirectoryButton.Click += SelectDirectory;

            displaySubFoldersButton.Click += (sender, e) => ButtonClick(sender, e, selectedDirectory);

            selectedDirTextBox.TextChanged += SelectedDirTextBoxTextChanged;

            selectTextFileButton.Click += SelectTextFileButtonClick;

            textFileTextBox.TextChanged += TextFileTextBoxTextChanged;

            writeToTextFileButton.Click += WriteToTextFile;


            writeToMoviesTitlesButton.Click += WriteToMoviesDatabase;



        }

        private void WriteToTextFile(object sender, EventArgs e)
        {
            string path = textFilePath;
            using (var tw = new StreamWriter(path, true))
            {
                foreach (var folderName in folderNamesList)
                {
                    tw.WriteLine($"{folderName}");
                }
                tw.Close();
            }
            //MessageBox.Show(path);
            //if (File.Exists(path))
            //{

            //    MessageBox.Show($"{path} exists");

            //    using (var tw = new StreamWriter(path, true))
            //    {
            //        foreach (var folderName in folderNamesList)
            //        {
            //            tw.WriteLine($"{folderName}");
            //        }
            //        tw.Close();
            //    }

            //}
            //if (!File.Exists(path))
            //{
            //    MessageBox.Show($"creating {path}");
            //    using (var tw = new StreamWriter(path, true))
            //    {                    
            //        foreach (var folderName in folderNamesList)
            //        {
            //            tw.WriteLine($"{folderName}");
            //        }
            //        tw.Close();
            //    }

            //}
            
        }

        private void TextFileTextBoxTextChanged(object sender, EventArgs e)
        {
            textFilePath = textFileTextBox.Text;
        }

        private void SelectTextFileButtonClick(object sender, EventArgs e)
        {
            textFilePath = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textFilePath = ofd.FileName;

                    // display in textFileTextBox
                    textFileTextBox.Text = textFilePath;
                }
            }

        }

        private void WriteToMoviesDatabase(object sender, EventArgs e)
        {
            string connectionString =
                ConfigurationManager.ConnectionStrings["ConnectionStringForMoviesDb"].ConnectionString;
            MessageBox.Show(connectionString);



            foreach (var folderName in folderNamesList)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                string cmdText = $@"INSERT INTO Movies (Title) VALUES ('{folderName}');";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                using (conn)
                {

                    conn.Open();
                    cmd.ExecuteScalar();
                }
            }
        }

        private void SelectedDirTextBoxTextChanged(object sender, EventArgs e)
        {
            selectedDirectory = selectedDirTextBox.Text;
        }

        private void SetSelectedDirectory()
        {

            selectedDirTextBox.Text = selectedDirectory;
        }


        private void SelectDirectory(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    selectedDirectory = fbd.SelectedPath;

                    SetSelectedDirectory();

                }
            }
            infoLabel.Text = "Click the Display Subfolders Button \r\n  " +
                "The folderNames list will be populated with results containing 11 to 99 characters";
        }

        private void ButtonClick(object sender, EventArgs e, string selectedDirectory)
        {
            // clear message
            infoLabel.Text = "";


            sortedSubfoldersListBox.Items.Clear();
            folderNamesList.Clear();
            if (selectedDirectory != null)
            {
                try
                {
                    string[] folders = Directory.GetDirectories(selectedDirectory, "*", SearchOption.AllDirectories);
                    foreach (var d in folders)
                    {
                        // display all subfolders
                        var dirName = new DirectoryInfo(d).Name;
                        sortedSubfoldersListBox.Items.Add(dirName);

                        // register only subfolders with length between 11 and 99 chars
                        string folderName = dirName.ToString().Replace(@"'", "");
                        if (folderName.Length > 10 && folderName.Length < 100)
                        { folderNamesList.Add(folderName); }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    sortedSubfoldersListBox.Items.Add(ex.Message);
                }
            }
        }
    }


}
