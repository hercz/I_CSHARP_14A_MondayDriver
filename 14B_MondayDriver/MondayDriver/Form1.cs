using System;
using System.Windows.Forms;

namespace MondayDriver
{
    public partial class Form1 : Form
    {
        public OperationHandler OperationHandler { get; set; }
        public DriveHandler DriveHandler { get; set; }

        public Form1()
        {
            InitializeComponent();
            OperationHandler = new OperationHandler(items_ListBox,path_TextBox);
            DriveHandler = new DriveHandler(path_TextBox,items_ListBox,drive_ComboBox);
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveHandler.FillDriveCombobox();
        }

        private void drive_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {        
            DriveHandler.SetPathTextBoxFromComboBox();
            DriveHandler.SetItemListBoxFromComboBox();
        }

        private void items_ListBox_Click(object sender, EventArgs e)
        {         
                 
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            OperationHandler.OpenDirectory();
        }
    }
}
