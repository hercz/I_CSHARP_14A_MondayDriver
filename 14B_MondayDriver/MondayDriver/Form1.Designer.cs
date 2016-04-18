namespace MondayDriver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drive_ComboBox = new System.Windows.Forms.ComboBox();
            this.path_TextBox = new System.Windows.Forms.TextBox();
            this.items_ListBox = new System.Windows.Forms.ListBox();
            this.open_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.drive_lbl = new System.Windows.Forms.Label();
            this.path_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drive_ComboBox
            // 
            this.drive_ComboBox.FormattingEnabled = true;
            this.drive_ComboBox.Location = new System.Drawing.Point(54, 29);
            this.drive_ComboBox.Name = "drive_ComboBox";
            this.drive_ComboBox.Size = new System.Drawing.Size(322, 21);
            this.drive_ComboBox.TabIndex = 0;
            // 
            // path_TextBox
            // 
            this.path_TextBox.Location = new System.Drawing.Point(54, 69);
            this.path_TextBox.Name = "path_TextBox";
            this.path_TextBox.Size = new System.Drawing.Size(322, 20);
            this.path_TextBox.TabIndex = 1;
            // 
            // items_ListBox
            // 
            this.items_ListBox.FormattingEnabled = true;
            this.items_ListBox.Location = new System.Drawing.Point(12, 107);
            this.items_ListBox.Name = "items_ListBox";
            this.items_ListBox.Size = new System.Drawing.Size(364, 199);
            this.items_ListBox.TabIndex = 2;
            // 
            // open_button
            // 
            this.open_button.Location = new System.Drawing.Point(70, 318);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 3;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(228, 318);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 4;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // drive_lbl
            // 
            this.drive_lbl.AutoSize = true;
            this.drive_lbl.Location = new System.Drawing.Point(13, 36);
            this.drive_lbl.Name = "drive_lbl";
            this.drive_lbl.Size = new System.Drawing.Size(35, 13);
            this.drive_lbl.TabIndex = 5;
            this.drive_lbl.Text = "Drive:";
            // 
            // path_lbl
            // 
            this.path_lbl.AutoSize = true;
            this.path_lbl.Location = new System.Drawing.Point(13, 75);
            this.path_lbl.Name = "path_lbl";
            this.path_lbl.Size = new System.Drawing.Size(32, 13);
            this.path_lbl.TabIndex = 6;
            this.path_lbl.Text = "Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 353);
            this.Controls.Add(this.path_lbl);
            this.Controls.Add(this.drive_lbl);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.open_button);
            this.Controls.Add(this.items_ListBox);
            this.Controls.Add(this.path_TextBox);
            this.Controls.Add(this.drive_ComboBox);
            this.Name = "Form1";
            this.Text = "Monday Driver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drive_ComboBox;
        private System.Windows.Forms.TextBox path_TextBox;
        private System.Windows.Forms.ListBox items_ListBox;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Label drive_lbl;
        private System.Windows.Forms.Label path_lbl;
    }
}

