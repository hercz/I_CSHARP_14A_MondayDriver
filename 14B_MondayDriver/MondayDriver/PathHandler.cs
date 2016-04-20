using System;
using System.IO;
using System.Windows.Forms;

namespace MondayDriver
{
    public class PathHandler
    {
        public TextBox FilePathTextBox { get; set; }
        public ListBox ItemListBox { get; set; }
        public ComboBox Drive { get; set; }
        public DriveInfo[] AllDrives { get; } = DriveInfo.GetDrives();
        public string PathForTextBox { get; set; }

        public PathHandler(TextBox filepath, ListBox elements, ComboBox drive)
        {
            FilePathTextBox = filepath;
            ItemListBox = elements;
            Drive = drive;
        }

        public void FillDriveCombobox()
        {
            foreach (DriveInfo drive in AllDrives)
            {
                Drive.Items.Add(drive.Name + " (" + drive.DriveType + ")");
            }
        }

        public void SetPathForTextBox()
        {
            
        }

        public void SetPathTextBoxFromComboBox()
        {
            try
            {
                FilePathTextBox.Text = AllDrives[Drive.SelectedIndex].RootDirectory.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        public void SetItemListBoxFromComboBox()
        {
            try
            {
                string[] dirs = Directory.GetDirectories(AllDrives[Drive.SelectedIndex].RootDirectory.ToString());

                foreach (var dir in dirs)
                {
                    string dirName = Path.GetFileName(dir);
                    ItemListBox.Items.Add("["+dirName+"]");
                }

                string[] files = Directory.GetFiles(AllDrives[Drive.SelectedIndex].RootDirectory.ToString());
                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    ItemListBox.Items.Add(fileName);
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
