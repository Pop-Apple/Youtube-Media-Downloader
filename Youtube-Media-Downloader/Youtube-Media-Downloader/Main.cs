using MediaToolkit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VideoLibrary;
/*
 * ░▄▀▀▒█▀▄▒██▀░█▀▄░█░▀█▀░░░██▄░▀▄▀░░▒█▀▄░▄▀▄▒█▀▄░▒░▒▄▀▄▒█▀▄▒█▀▄░█▒░▒██▀
 * ░▀▄▄░█▀▄░█▄▄▒█▄▀░█░▒█▒▒░▒█▄█░▒█▒▒░░█▀▒░▀▄▀░█▀▒░▀▀░█▀█░█▀▒░█▀▒▒█▄▄░█▄▄
 * Credit by Pop-Apple
 * [Github](github.com/Pop-Apple)
 */
namespace Youtube_Media_Downloader
{
    public partial class Main : Form{
        public Main(){
            InitializeComponent();
        }
        /*
         * Format [True] = Mp3
         * Format [False] = Mp4
         */
        Boolean format = true;
        private void Main_Load(object sender, EventArgs e){
            this.PreprogressBar.Visible = false;
            this.DefaultprogressBar.Visible = true;
            this.radioMp4.Checked = true;
            //ToolTip Setting
            toolTip.SetToolTip(btnConvert, "Download Start");
            toolTip.SetToolTip(txtAddress, "Please fill in the URL");
            toolTip.SetToolTip(btnON, "Progressbar Visible ON");
            toolTip.SetToolTip(btnOFF, "Progressbar Visible OFF");
        }
        public void ErrorMessage() {
            MessageBox.Show("Downloaded Error (Invid URL)","Youtube Media Downloader", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void SuccessMessage(){
            MessageBox.Show("Downloaded Successfully","Youtube Media Downloader", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        /// <summary>
        /// Progressbar Visible / ON or OFF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOFF_Click(object sender, EventArgs e){
            this.btnOFF.BackColor = Color.SkyBlue;
            this.btnON.BackColor = Color.Transparent;
            //Visible False
            this.PreprogressBar.Visible = false;
            this.DefaultprogressBar.Visible = false;
        }
        private void btnON_Click(object sender, EventArgs e){
            this.btnOFF.BackColor = Color.Transparent;
            this.btnON.BackColor = Color.SkyBlue;
            //Visible True
            this.PreprogressBar.Visible = true;
            this.DefaultprogressBar.Visible = true;
        }
        /// <summary>
        /// MenuStrip Dialog Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e){
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Youtube Video URL";
            ofd.Filter = "Youtube URL | *.yturl; | Unicode File | *.txt; | Shortcut Links | *.lnk;";
            ofd.FileName = "";
            if (ofd.ShowDialog() == DialogResult.OK){
                //StreamWriter
                txtAddress.Text = ofd.FileName;
                StreamReader SR = new StreamReader(txtAddress.Text);
                txtAddress.Text = SR.ReadToEnd();
                SR.Close();
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e){
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Youtube Video URL";
            sfd.Filter = "Youtube URL | *.yturl; | Unicode File | *.txt; | Shortcut Links | *.lnk;";
            sfd.FileName = "";
            if(sfd.ShowDialog()==DialogResult.OK){
                //using (Stream s = File.Open(sfd.FileName, FileMode.CreateNew)
                File.WriteAllText(sfd.FileName, this.txtAddress.Text);
                sfd.Filter = "";
            }
        }
        /// <summary>
        /// MenuStrip Edit Control Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e){
            this.txtAddress.SelectAll();
            this.txtAddress.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e){
            this.txtAddress.Paste();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e){
            this.txtAddress.SelectAll();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e){
            this.txtAddress.Clear();
        }
        /// <summary>
        /// StreamWriter / Export Git
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportGitToolStripMenuItem_Click(object sender, EventArgs e){
            DialogResult result = MessageBox.Show("Start Export ?","Github Language", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes){
                string Git = "*.exe linguist-language=C#";
                StreamWriter SW = new StreamWriter(".gitattributes");
                SW.Write(Git);
                MessageBox.Show("Export Successfully", "Github Language", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SW.Close();
            }
            else if (result == System.Windows.Forms.DialogResult.No){
                //Cancel
            }
        }
        /// <summary>
        /// MenuStrip Tool (Browser)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void googleToolStripMenuItem_Click(object sender, EventArgs e){
            Process.Start("https://www.google.com/?hl=en");
        }
        private void yahooToolStripMenuItem_Click(object sender, EventArgs e){
            Process.Start("https://www.youtube.com/");
        }
        /// <summary>
        /// License
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void licenseToolStripMenuItem_Click(object sender, EventArgs e){
            Information Form2 = new Information();
            Form2.ShowDialog();
        }
        /// <summary>
        ///  Download Youtube Media [mp3 or mp4]
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnConvert_Click(object sender, EventArgs e){
            bool Text1 = txtAddress.Text.Length == 0;
            if (Text1){
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() == DialogResult.OK){
                    this.btnON.Enabled = false;
                    this.btnOFF.Enabled = false;
                    PreprogressBar.Visible = true;
                    DefaultprogressBar.Visible = false;
                    this.ProcessLabel.Text = "Loading ...";
                    timerError.Start();
                }
                else{
                }
            }else{
                /*
                 * Main Event this Class
                 */
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if(fbd.ShowDialog()==DialogResult.OK){
                    this.btnON.Enabled = false;
                    this.btnOFF.Enabled = false;
                    this.DefaultprogressBar.Visible = false;
                    this.PreprogressBar.Visible = true;
                    this.ProcessLabel.Text = "Loading ...";
                    var Youtube = YouTube.Default;
                    var Video = await Youtube.GetVideoAsync(txtAddress.Text);
                    File.WriteAllBytes(fbd.SelectedPath + @"＼" + Video.FullName,  await Video.GetBytesAsync());
                    /*
                     *
                     */
                    var inputfile = new MediaToolkit.Model.MediaFile { Filename = fbd.SelectedPath + @"＼" + Video.FullName};
                    var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{fbd.SelectedPath + @"＼" + Video.FullName}.mp3"};
                    /*
                     * 
                     */
                    using (var enging = new Engine()){
                        enging.GetMetadata(inputfile);
                        enging.Convert(inputfile, outputfile);
                    }
                    /*
                     * 
                     */
                    if (format == true) {
                        File.Delete(fbd.SelectedPath + @"＼" + Video.FullName) ;
                    }
                    else {
                        File.Delete($"{fbd.SelectedPath + @"＼" + Video.FullName}.mp3");
                    }
                    /*
                     * 
                     */
                    this.DefaultprogressBar.Visible = true;
                    this.PreprogressBar.Visible = false;
                    this.ProcessLabel.Text = "Downloaded Successfully";
                    this.btnON.Enabled = true;
                    this.btnOFF.Enabled = true;
                    SuccessMessage();
                    this.ProcessLabel.Text = "Preparation";
                }
            }

        }
        /// <summary>
        /// Error Timer Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerError_Tick(object sender, EventArgs e){
            DefaultprogressBar.Increment(1);
            bool Error = DefaultprogressBar.Value == 100;
            if (Error) {
                timerError.Stop();
                this.btnON.Enabled = true;
                this.btnOFF.Enabled = true;
                DefaultprogressBar.Value = 0;
                PreprogressBar.Visible = false;
                DefaultprogressBar.Visible = true;
                this.ProcessLabel.Text = "Error :(";
                ErrorMessage();
            }
        }
        /// <summary>
        ///  Format mp3 or mp4 
        ///  ture , false
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioMp3_CheckedChanged(object sender, EventArgs e){
            format = true;
        }
        private void radioMp4_CheckedChanged(object sender, EventArgs e){
            format = false;
        }
        /// <summary>
        /// Export Android & iphone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportAndroidiphoneToolStripMenuItem_Click(object sender, EventArgs e){
            Process.Start("explorer.exe");}
        /*
         * 🅴🅽🅳
         */
        private void exitToolStripMenuItem_Click(object sender, EventArgs e){
            Application.Exit();
        }
    }
}
