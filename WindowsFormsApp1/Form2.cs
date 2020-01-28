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
        DateTime currentDate = DateTime.Now;


        private void btnBack_Click(object sender, EventArgs e){
            this.Close();
        }
        private void tbIncrementAmount_TextChanged(object sender, EventArgs e){
            incrementNum = Int32.Parse(tbIncrementAmount.Text);
        }
        private void tbRepeatThisAction_TextChanged(object sender, EventArgs e){
            repeatAmount = Int32.Parse(tbRepeatThisAction.Text);
        }
        private void cbDaysWeeksMonths_SelectedIndexChanged(object sender, EventArgs e){
            TimeFrame();
        }
        private void cbRepeat_SelectedIndexChanged(object sender, EventArgs e){
            Repeat();
        }

        private void btnOpenFile_Click(object sender, EventArgs e){
            GetFiles();
        }
        private void btnDelete_Click(object sender, EventArgs e){

            string popupContent = btnDelete.Text = "Delete " + filesToDelete.Count + " Items that were created before " + currentDate.AddDays(-numOfDays).ToString("MM-dd-yyy") + ". This " + "action will repeat every " + numRepeat + " hours. This action will repeat on " + willRepeat;
            MessageBox.Show(popupContent);
            if (numOfDays == 0){
                MessageBox.Show("Please specify a number of days");
            }
            else{
                foreach (String i in filesToDelete){
                    Delete(i);
                }
            }
        }
        private void GetDirect(String target){

            string[] folder = Directory.GetFiles(target);
            foreach (string files in folder){
                DateTime creation = Creation(files);
                int compareTimes = DateTime.Compare(creation, currentDate.AddDays(-numOfDays));
                if (compareTimes < 0){
                    filesToDelete.Add(files);
                    btnDelete.Text = "Delete " + filesToDelete.Count + " Items";
                }
            }
            string[] subDirectories = Directory.GetDirectories(target);
            foreach (string s in subDirectories){
                DateTime creation = Creation(s);
                int compareTimes = DateTime.Compare(creation, currentDate.AddDays(-numOfDays));
                if (compareTimes == -1){
                    filesToDelete.Add(s);
                    btnDelete.Text = "Delete " + filesToDelete.Count + " Items";
                }
            }
            lblTestLabel.Text = target.ToString();
        }
        private void GetFiles(){
            folder.ShowNewFolderButton = true;
            DialogResult result = folder.ShowDialog();
            if (result == DialogResult.OK){
                GetDirect(folder.SelectedPath);
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
            numOfDays = 0;
            if (cbDaysWeeksMonths.SelectedItem == "Days"){
                numOfDays = 1 * incrementNum;
            }else if (cbDaysWeeksMonths.SelectedItem == "Weeks"){
                numOfDays = 7 * incrementNum;
            }
        }
        private void Repeat(){
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
                willRepeat = currentDate.AddDays(numRepeat);
            }
            if (willRepeat == DateTime.Now){
                GetFiles();
                foreach (String i in filesToDelete){
                    Delete(i);
                }
            }

        }
    }
}
