namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblTestLabel = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tbIncrementAmount = new System.Windows.Forms.TextBox();
            this.cbDaysWeeksMonths = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblRepeatAction = new System.Windows.Forms.Label();
            this.cbRepeat = new System.Windows.Forms.ComboBox();
            this.tbRepeatThisAction = new System.Windows.Forms.TextBox();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.lbSelectedFiles = new System.Windows.Forms.ListBox();
            this.lbSummary = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // lblTestLabel
            // 
            this.lblTestLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTestLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestLabel.Location = new System.Drawing.Point(11, 85);
            this.lblTestLabel.Name = "lblTestLabel";
            this.lblTestLabel.Size = new System.Drawing.Size(300, 30);
            this.lblTestLabel.TabIndex = 5;
            this.lblTestLabel.Text = "Choose A File";
            this.lblTestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(317, 84);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(72, 31);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tbIncrementAmount
            // 
            this.tbIncrementAmount.Location = new System.Drawing.Point(11, 27);
            this.tbIncrementAmount.Multiline = true;
            this.tbIncrementAmount.Name = "tbIncrementAmount";
            this.tbIncrementAmount.Size = new System.Drawing.Size(50, 23);
            this.tbIncrementAmount.TabIndex = 6;
            this.tbIncrementAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbIncrementAmount.TextChanged += new System.EventHandler(this.tbIncrementAmount_TextChanged);
            // 
            // cbDaysWeeksMonths
            // 
            this.cbDaysWeeksMonths.AllowDrop = true;
            this.cbDaysWeeksMonths.FormattingEnabled = true;
            this.cbDaysWeeksMonths.ItemHeight = 15;
            this.cbDaysWeeksMonths.Location = new System.Drawing.Point(67, 27);
            this.cbDaysWeeksMonths.Name = "cbDaysWeeksMonths";
            this.cbDaysWeeksMonths.Size = new System.Drawing.Size(114, 23);
            this.cbDaysWeeksMonths.TabIndex = 7;
            this.cbDaysWeeksMonths.SelectedIndexChanged += new System.EventHandler(this.cbDaysWeeksMonths_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(219, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(171, 47);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Delete files created before:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 276);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 47);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblRepeatAction
            // 
            this.lblRepeatAction.AutoSize = true;
            this.lblRepeatAction.Location = new System.Drawing.Point(237, 9);
            this.lblRepeatAction.Name = "lblRepeatAction";
            this.lblRepeatAction.Size = new System.Drawing.Size(125, 15);
            this.lblRepeatAction.TabIndex = 12;
            this.lblRepeatAction.Text = "Repeat this action every:";
            // 
            // cbRepeat
            // 
            this.cbRepeat.AllowDrop = true;
            this.cbRepeat.FormattingEnabled = true;
            this.cbRepeat.ItemHeight = 15;
            this.cbRepeat.Location = new System.Drawing.Point(275, 27);
            this.cbRepeat.Name = "cbRepeat";
            this.cbRepeat.Size = new System.Drawing.Size(114, 23);
            this.cbRepeat.TabIndex = 14;
            this.cbRepeat.SelectedIndexChanged += new System.EventHandler(this.cbRepeat_SelectedIndexChanged);
            // 
            // tbRepeatThisAction
            // 
            this.tbRepeatThisAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbRepeatThisAction.Location = new System.Drawing.Point(219, 27);
            this.tbRepeatThisAction.MaxLength = 10000;
            this.tbRepeatThisAction.Multiline = true;
            this.tbRepeatThisAction.Name = "tbRepeatThisAction";
            this.tbRepeatThisAction.Size = new System.Drawing.Size(50, 23);
            this.tbRepeatThisAction.TabIndex = 13;
            this.tbRepeatThisAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRepeatThisAction.TextChanged += new System.EventHandler(this.tbRepeatThisAction_TextChanged);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Enabled = true;
            this.tmrTimer.Interval = 1000;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // lbSelectedFiles
            // 
            this.lbSelectedFiles.FormattingEnabled = true;
            this.lbSelectedFiles.ItemHeight = 15;
            this.lbSelectedFiles.Location = new System.Drawing.Point(11, 118);
            this.lbSelectedFiles.Name = "lbSelectedFiles";
            this.lbSelectedFiles.ScrollAlwaysVisible = true;
            this.lbSelectedFiles.Size = new System.Drawing.Size(378, 139);
            this.lbSelectedFiles.TabIndex = 16;
            // 
            // lbSummary
            // 
            this.lbSummary.FormattingEnabled = true;
            this.lbSummary.ItemHeight = 15;
            this.lbSummary.Location = new System.Drawing.Point(11, 329);
            this.lbSummary.Name = "lbSummary";
            this.lbSummary.ScrollAlwaysVisible = true;
            this.lbSummary.Size = new System.Drawing.Size(378, 79);
            this.lbSummary.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 423);
            this.Controls.Add(this.lbSummary);
            this.Controls.Add(this.lbSelectedFiles);
            this.Controls.Add(this.cbRepeat);
            this.Controls.Add(this.tbRepeatThisAction);
            this.Controls.Add(this.lblRepeatAction);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbDaysWeeksMonths);
            this.Controls.Add(this.tbIncrementAmount);
            this.Controls.Add(this.lblTestLabel);
            this.Controls.Add(this.btnOpenFile);
            this.Font = new System.Drawing.Font("Franklin Gothic Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incremental Deletion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTestLabel;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tbIncrementAmount;
        private System.Windows.Forms.ComboBox cbDaysWeeksMonths;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblRepeatAction;
        private System.Windows.Forms.ComboBox cbRepeat;
        private System.Windows.Forms.TextBox tbRepeatThisAction;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.ListBox lbSelectedFiles;
        private System.Windows.Forms.ListBox lbSummary;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}