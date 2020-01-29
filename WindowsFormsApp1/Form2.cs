using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1{
    public partial class Form2 : Form{
        public Form2(){
            InitializeComponent();
            this.tbIncrementAmount.AutoSize = false;
            this.tbRepeatThisAction.AutoSize = false;
            this.tbIncrementAmount.Size = new System.Drawing.Size(50, 23);
            this.tbRepeatThisAction.Size = new System.Drawing.Size(50, 23);

            cbDaysWeeksMonths.Items.Add("Days");
            cbDaysWeeksMonths.Items.Add("Weeks");

            cbRepeat.Items.Add("Hours");
            cbRepeat.Items.Add("Days");
            cbRepeat.Items.Add("Weeks");
        }

        FolderBrowserDialog folder = new FolderBrowserDialog();
        DateTime willRepeat;
        List<String> filesToDelete = new List<String>();
        int incrementNum;
        int repeatAmount;
        int numOfDays = 0;
        int numRepeat = 0;
        string filePath;

        private void btnBack_Click(object sender, EventArgs e){
            this.Close();
        }
        private void tbIncrementAmount_TextChanged(object sender, EventArgs e){
            if (tbIncrementAmount.Text.Length > 0){
                incrementNum = int.Parse(tbIncrementAmount.Text);
            }
        }
        private void tbRepeatThisAction_TextChanged(object sender, EventArgs e){
            if (tbRepeatThisAction.Text.Length > 0){
                repeatAmount = int.Parse(tbRepeatThisAction.Text);
            }
        }
        private void cbDaysWeeksMonths_SelectedIndexChanged(object sender, EventArgs e){
            TimeFrame();
            filesToDelete.Clear();
            lbSelectedFiles.Items.Clear();
            GetDirect();
        }
        private void cbRepeat_SelectedIndexChanged(object sender, EventArgs e){
            Repeat();
        }
        private void btnOpenFile_Click(object sender, EventArgs e){
            lbSelectedFiles.Items.Clear();
            filesToDelete.Clear();
            GetFiles();
        }
        private void tmrTimer_Tick(object sender, EventArgs e){
            if (DateTime.Now.ToString("HH:mm:ss") == willRepeat.ToString("HH:mm:ss")){
                foreach (String i in filesToDelete){
                    Delete(i);
                    willRepeat = DateTime.Now.AddMinutes(numRepeat);
                }
                lbSummary.Items.Add("Successfully removed " + filesToDelete.Count + " items At: " + DateTime.Now);
                lbSummary.Items.Add("Next Remove at: " + willRepeat);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e){
            btnDelete.Text = "Delete " + filesToDelete.Count + " Items";
            string popupContent = "Delete " + filesToDelete.Count + " Items that were created before " + DateTime.Now.AddDays(-numOfDays).ToString("MM-dd-yyy") + ". This " + "action will repeat every " + numRepeat + " hours. This action will repeat on " + willRepeat;
            MessageBox.Show(popupContent);
            if (numOfDays == 0){
                MessageBox.Show("Please specify a number of days");
            }
            else{
                lbSummary.Items.Add("Removing " + filesToDelete.Count + " items from " + filePath.ToString());
                lbSummary.Items.Add("Removing at: " + willRepeat);
                foreach (String i in filesToDelete){
                    Delete(i);
                }
            }
        }
        private void GetDirect(){
            if (filePath == null) { }
            else if(filePath != null){
                string[] folder = Directory.GetFiles(filePath);
                foreach (string files in folder){
                    DateTime creation = Creation(files);
                    int compareTimes = DateTime.Compare(creation, DateTime.Now.AddDays(-numOfDays));
                    if (compareTimes < 0){
                        filesToDelete.Add(files);
                        lbSelectedFiles.Items.Add(files);
                        btnDelete.Text = "Delete " + filesToDelete.Count + " Items";
                    }
                }
                string[] subDirectories = Directory.GetDirectories(filePath);
                foreach (string s in subDirectories){
                    DateTime creation = Creation(s);
                    int compareTimes = DateTime.Compare(creation, DateTime.Now.AddDays(-numOfDays));
                    if (compareTimes == -1){
                        filesToDelete.Add(s);
                        lbSelectedFiles.Items.Add(s);
                        btnDelete.Text = "Delete " + filesToDelete.Count + " Items";
                    }
                }
                lblTestLabel.Text = filePath;
            }
        }
        private void GetFiles(){
            folder.ShowNewFolderButton = true;
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK){
                filePath = folder.SelectedPath;
                GetDirect();
            }
        }
        private DateTime Creation(String target){
            DateTime creation = new DateTime();
            creation = File.GetLastWriteTime(target);
            return creation;
        }
        private void Delete(String file){
            try{
                File.Delete(file);
            }catch{
                //Do nothing
            }
        }
        private void TimeFrame(){
            if (lbSummary.Items.Count > 0){
                lbSummary.Items.Clear();
            }
            numOfDays = 0;
            if (cbDaysWeeksMonths.SelectedItem == "Days"){
                numOfDays = 1 * incrementNum;
            }else if (cbDaysWeeksMonths.SelectedItem == "Weeks"){
                numOfDays = 7 * incrementNum;
            }
        }
        void Repeat(){
            if (lbSummary.Items.Count > 0){
                lbSummary.Items.Clear();
            }

            numRepeat = 0;
            if (cbRepeat.SelectedItem == "Hours"){
                numRepeat = 1 * repeatAmount;
            }
            else if(cbRepeat.SelectedItem == "Days"){
                numRepeat = 24 * repeatAmount;
            }
            else if(cbRepeat.SelectedItem == "Weeks"){
                numRepeat = (24 * 7) * repeatAmount;
            }

            if(numRepeat > 0){
                willRepeat = DateTime.Now.AddMinutes(numRepeat);
            }
        }
    }
}

