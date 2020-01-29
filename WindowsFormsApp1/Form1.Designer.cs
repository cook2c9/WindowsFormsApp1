namespace WindowsFormsApp1
{
    partial class frmDeleteFiles
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteItems = new System.Windows.Forms.Button();
            this.lblTestLabel = new System.Windows.Forms.Label();
            this.lbSelectedFiles = new System.Windows.Forms.ListBox();
            this.btnDeleteSelection = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnIncremental = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(272, 291);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(72, 28);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(332, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 28, 8, 45, 58, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnDeleteItems
            // 
            this.btnDeleteItems.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItems.Location = new System.Drawing.Point(381, 216);
            this.btnDeleteItems.Name = "btnDeleteItems";
            this.btnDeleteItems.Size = new System.Drawing.Size(98, 57);
            this.btnDeleteItems.TabIndex = 2;
            this.btnDeleteItems.Text = "Delete Items";
            this.btnDeleteItems.UseVisualStyleBackColor = true;
            this.btnDeleteItems.Click += new System.EventHandler(this.btnDeleteItems_Click);
            // 
            // lblTestLabel
            // 
            this.lblTestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestLabel.Location = new System.Drawing.Point(12, 291);
            this.lblTestLabel.Name = "lblTestLabel";
            this.lblTestLabel.Size = new System.Drawing.Size(254, 28);
            this.lblTestLabel.TabIndex = 3;
            this.lblTestLabel.Text = "Choose A File";
            this.lblTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSelectedFiles
            // 
            this.lbSelectedFiles.FormattingEnabled = true;
            this.lbSelectedFiles.ItemHeight = 15;
            this.lbSelectedFiles.Location = new System.Drawing.Point(12, 59);
            this.lbSelectedFiles.Name = "lbSelectedFiles";
            this.lbSelectedFiles.Size = new System.Drawing.Size(332, 214);
            this.lbSelectedFiles.TabIndex = 6;
            // 
            // btnDeleteSelection
            // 
            this.btnDeleteSelection.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSelection.Location = new System.Drawing.Point(381, 132);
            this.btnDeleteSelection.Name = "btnDeleteSelection";
            this.btnDeleteSelection.Size = new System.Drawing.Size(98, 78);
            this.btnDeleteSelection.TabIndex = 8;
            this.btnDeleteSelection.Text = "Delete Selected Only";
            this.btnDeleteSelection.UseVisualStyleBackColor = true;
            this.btnDeleteSelection.Click += new System.EventHandler(this.btnDeleteSelection_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSelected.Location = new System.Drawing.Point(381, 59);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(98, 67);
            this.btnRemoveSelected.TabIndex = 9;
            this.btnRemoveSelected.Text = "Remove Item From List";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnIncremental
            // 
            this.btnIncremental.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncremental.Location = new System.Drawing.Point(381, 291);
            this.btnIncremental.Name = "btnIncremental";
            this.btnIncremental.Size = new System.Drawing.Size(98, 42);
            this.btnIncremental.TabIndex = 10;
            this.btnIncremental.Text = "Incremental Deletion";
            this.btnIncremental.UseVisualStyleBackColor = true;
            this.btnIncremental.Click += new System.EventHandler(this.btnIncremental_Click);
            // 
            // frmDeleteFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 343);
            this.Controls.Add(this.btnIncremental);
            this.Controls.Add(this.btnRemoveSelected);
            this.Controls.Add(this.btnDeleteSelection);
            this.Controls.Add(this.lbSelectedFiles);
            this.Controls.Add(this.lblTestLabel);
            this.Controls.Add(this.btnDeleteItems);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnOpenFile);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmDeleteFiles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Deletion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDeleteItems;
        private System.Windows.Forms.Label lblTestLabel;
        private System.Windows.Forms.ListBox lbSelectedFiles;
        private System.Windows.Forms.Button btnDeleteSelection;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnIncremental;
    }
}

