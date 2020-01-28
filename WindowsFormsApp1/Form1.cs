using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1{
    public partial class frmDeleteFiles : Form{
        public frmDeleteFiles(){
            InitializeComponent();
        }

        FolderBrowserDialog folder = new FolderBrowserDialog();
        DateTime selectedDate;
        List<String> filesToDelete = new List<String>();
        string fileType;

        private void Form1_Load(object sender, EventArgs e){

        }
        private void btnOpenFile_Click(object sender, EventArgs e){
            folder.ShowNewFolderButton = true;
            DialogResult result = folder.ShowDialog();
            if(result == DialogResult.OK){
                GetDirect(folder.SelectedPath);
            }
        }
        private void btnDeleteItems_Click(object sender, EventArgs e){
            if (filesToDelete.Count == 0){
                MessageBox.Show("Please select a folder to delete from");
            }else{
                foreach (String i in filesToDelete){
                    Delete(i);
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e){
            selectedDate = dateTimePicker1.Value;
            selectedDate.ToString("MM-dd-yyy");
        }
        private void GetDirect(String target){

            string[] folder = Directory.GetFiles(target);
            foreach(string i in folder){
                DateTime creation = Creation(i);
                int compareTimes = DateTime.Compare(creation, selectedDate);
                if (compareTimes < 0){
                    filesToDelete.Add(i);
                    lbSelectedFiles.Items.Add(i);
                    btnDeleteItems.Text = "Delete " + filesToDelete.Count + " Items";
                }
            }
            string [] subDirectories = Directory.GetDirectories(target);
            foreach(string s in subDirectories){
                DateTime creation = Creation(s);
                int compareTimes = DateTime.Compare(creation, selectedDate);
                if (compareTimes == -1){
                    filesToDelete.Add(s);
                    lbSelectedFiles.Items.Add(s);
                    btnDeleteItems.Text = "Delete " + filesToDelete.Count + " Items";
                }
            }
            lblTestLabel.Text = target.ToString();
        }
        private DateTime Creation(String target){
            DateTime creation = new DateTime();
            creation = File.GetLastWriteTime(target);
            return creation;
        }
        private void Delete(String file){
            File.Delete(file);
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e){
            if (filesToDelete.Count > 0){
                filesToDelete.Remove(lbSelectedFiles.SelectedItem.ToString());
                lbSelectedFiles.Items.Remove(lbSelectedFiles.SelectedItem);
            }else{
                MessageBox.Show("Please Select a folder to delete from");
            }
        }
        private void btnDeleteSelection_Click(object sender, EventArgs e){
            if(filesToDelete.Count > 0)
            {
                string filePath = lbSelectedFiles.Items[lbSelectedFiles.SelectedIndex].ToString();
                File.Delete(filePath);
                lbSelectedFiles.Items.Remove(lbSelectedFiles.SelectedItem);
            }
            else{
                MessageBox.Show("Please Select a file to delete");
            }
        }

        private void btnIncremental_Click(object sender, EventArgs e){
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void cbFileTypes_SelectedIndexChanged(object sender, EventArgs e){
            fileType = cbFileTypes.SelectedItem.ToString();
        }
    }
}
