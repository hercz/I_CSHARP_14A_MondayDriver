using System;
using System.IO;
using System.Windows.Forms;

namespace MondayDriver
{
    public class OperationHandler
    {
        public ListBox ItemListBox { get; set; }
        public TextBox PathTextBox { get; set; }
        public string CurrentPath { get; set; }


        public OperationHandler(ListBox itemListBox, TextBox pathTextBox)
        {
            ItemListBox = itemListBox;
            PathTextBox = pathTextBox;
        }

        public void SetFilePath()
        {
            string past = PathTextBox.Text;
            string present = past + ItemListBox.SelectedItem;

            PathTextBox.Text = present;

        }

        public void OpenDirectory()
        {
            CurrentPath = PathTextBox.Text + ItemListBox.SelectedItem + "\\";
            ItemListBox.Items.Clear();
            PathTextBox.Text = CurrentPath;
            if (CurrentPath.EndsWith(@".txt\"))
            {
                System.Diagnostics.Process.Start(CurrentPath);
            }
            else
            {
                ShowDirsAndTexts();
            }
            
        }

        private void ShowDirsAndTexts()
        {
            try
            {
                string[] dirs = Directory.GetDirectories(CurrentPath);

                foreach (var dir in dirs)
                {
                    string dirName = Path.GetFileName(dir);
                    ItemListBox.Items.Add(dirName);
                }

                string[] files = Directory.GetFiles(CurrentPath);
                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName.EndsWith(".txt"))
                    {
                        ItemListBox.Items.Add(fileName);
                    }
                }
            }
            catch (Exception er)
            {
                ItemListBox.Items.Clear();
                MessageBox.Show(er.Message);
            }
        }

    }
}

