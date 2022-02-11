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
using System.Threading;

namespace VPN
{
    
    public partial class Form1 : Form
    {
        int frame_num=1;
        string setup_path;
        string shortcut_path = "VPN Unlimited";
        bool additional_shortcut = true;
        public Form1()
        {
            InitializeComponent();
        }

        void Fullfil_ProgressBar()
        {
            next_butt.Enabled = false;
            double counter = 0;
            progressBar1.Maximum = 1000;
            while(progressBar1.Value<1000)
            {
                counter += 0.003;
                if ( Math.Floor(counter)% 15 == 0)
                {
                    progressBar1.Value += 1;
                }
            }
            label3.Text = "\n\nSuccsessfully installed!";
            next_butt.Enabled = true;
        }

        void Draw_Frame()
        {
            switch(frame_num)
            {
                case 1:
                    label1.Text = "License agreement";
                    label2.Text = "Please read the following important information before continuing.";
                    label3.Text = "Please read the following License Agreement. You must accept the terms of this \nagreement before continuing installation.";
                    radioButton_agree.Visible = true;
                    radioButton_disagree.Visible = true;
                    LicenseTextBox1.Visible = true;
                    FreeSpace_label.Visible = false;
                    path_textBox.Visible = false;
                    browse_butt.Visible = false;
                    back_butt.Visible = false;
                    break;
                case 2:
                    label1.Text = "Select destination Location";
                    label2.Text= "Where should VPN Unlimited be installed?";
                    label3.Text = "Setup will install VPN Inlimited into following folder.\nTo continue, click Next. If would like to select a different folder, click Browse.";
                    radioButton_agree.Visible = false;
                    radioButton_disagree.Visible = false;
                    LicenseTextBox1.Visible = false;
                    FreeSpace_label.Visible = true;
                    path_textBox.Visible = true;
                    path_textBox.Text = setup_path;
                    browse_butt.Visible = true;
                    back_butt.Visible = true;
                    if (setup_path == null) next_butt.Enabled = false;
                    else next_butt.Enabled = true;
                    break;
                case 3:
                    label1.Text = "Select Start Menu Folder";
                    label2.Text = "Where should Setup place program`s shortcuts?";
                    label3.Text = "Setup will create program`s shortcut in the following Start Menu folder. \nTo continue, click Next. If would like to select a different folder, click Browse.";
                    
                    FreeSpace_label.Visible = false;
                    path_textBox.Visible = true;
                    path_textBox.Text = shortcut_path;
                    browse_butt.Visible = true;

                    break;
                case 4:
                    label1.Text = "Select Additional Tasks";
                    label2.Text = "Which additional tasks should be performed?";
                    label3.Text = "Select the additional tasks you would like Setup to perform while installing VPN\nUnlimited, then click Next\n\nAdditional shortcuts:";

                    next_butt.Text = "Next";
                    path_textBox.Visible = false;
                    browse_butt.Visible = false;
                    final_richTextBox.Visible = false;
                    AdditShortCut_checkBox.Visible = true;

                    

                    break;

                case 5:
                    
                    label1.Text = "Ready to Install";
                    label2.Text = "Setup is now ready to begin installing VPN Unlimited on your computer.";
                    label3.Text = "Click Install to continue with installation, or click Back if you want to review or\nchange any settings.";
                    final_richTextBox.Text = "Destination location:\n\t" + setup_path + "\n\nStart Menu folder:\n\t" + shortcut_path;
                    if (additional_shortcut) final_richTextBox.Text += "\n\nAdditional tasks:\n\tAdditional shortcuts:\n\t\tCreate a desktop shortcut";
                    
                    next_butt.Text = "Install";
                    final_richTextBox.Visible = true;
                    AdditShortCut_checkBox.Visible = false;
                    break;
                case 6:
                    label1.Text = "Installing";
                    label2.Text = "Please wait while Setup installs VPN Unlimited on your computer.";
                    label3.Text = "Extracting files to...\n"+setup_path;

                    progressBar1.Visible = true;
                   
                    next_butt.Text = "Next";
                    final_richTextBox.Visible = false;
                    back_butt.Visible = false;
                    button2.Visible = false;
                    Fullfil_ProgressBar();
                    break;
                case 7:
                    label1.Text = "Completing The VPN\nUnlimited setup Wizard";
                    label2.Text = "Setup has finished installing VPN Unlimited on your computer. \nThe application may be launched by selecting \nthe installed shortcuts.";
                    label3.Text = "Click finish to exit Setup"; 

                    label1.Top = 65;
                    label1.Left = 250;

                    label2.Top = 150;
                    label2.Left = 250;

                    label3.Top = 260;
                    label3.Left = 250;

                    next_butt.Text = "Finish";
                    pictureBox1.Visible = true;
                    launch_cb.Visible = true;
                    progressBar1.Visible = false;
                    pictureBox1.Visible = true;
                    //pictureBox2.Visible = true;
                    pictureBox1.Image = Image.FromFile(@"C:\Users\Andrew\Desktop\vpn_winform\VPN\logos\big_logo.png");
                    pictureBox1.Top = 74;
                    pictureBox1.Left = 23;
                    pictureBox1.Height = 360;
                    pictureBox1.Width = 185;
                    break;
                case 8:
                    this.Close();
                    

                    break;
            }
                

        }

        private void radioButton_disagree_CheckedChanged(object sender, EventArgs e)
        {
            next_butt.Enabled = false;
        }

        private void radioButton_agree_CheckedChanged(object sender, EventArgs e)
        {
            next_butt.Enabled = true;
        }

        private void next_butt_Click(object sender, EventArgs e)
        {
            frame_num++;
            Draw_Frame();
        }

        private void back_butt_Click(object sender, EventArgs e)
        {
            if (frame_num-- <= 0) frame_num = 1;
            Draw_Frame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Setup is not complete. If you exit now, the programm will be not installed.\n\n You may run setup at another time to complete the installiation. \n\n Exit setup?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, "Exit Setup", buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void browse_butt_Click(object sender, EventArgs e)
        {
            
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                next_butt.Enabled = true;
                path_textBox.Text = openFileDlg.SelectedPath;
                if (frame_num == 2) setup_path = openFileDlg.SelectedPath;
                if (frame_num == 3) shortcut_path = openFileDlg.SelectedPath;
            }
        }

        private void AdditShortCut_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdditShortCut_checkBox.Checked) additional_shortcut = true;
            else additional_shortcut = false;

        }

        
    }
}
