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

namespace MondayDriver
{
    public partial class Form1 : Form
    {
        public DriveHandler DriveHandler { get; set; }
        public PathHandler PathHandler { get; set; }


        public Form1()
        {
            InitializeComponent();
            DriveHandler = new DriveHandler(drive_ComboBox);
            PathHandler = new PathHandler(path_TextBox,items_ListBox,drive_ComboBox);
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            PathHandler.FillDriveCombobox();
        }

        private void drive_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {        
            PathHandler.SetPathTextBoxFromComboBox();
            PathHandler.SetItemListBoxFromComboBox();
        }

        private void items_ListBox_Click(object sender, EventArgs e)
        {

        }
    }
}
