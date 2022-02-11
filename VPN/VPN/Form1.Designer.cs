
namespace VPN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LicenseTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButton_agree = new System.Windows.Forms.RadioButton();
            this.radioButton_disagree = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.FreeSpace_label = new System.Windows.Forms.Label();
            this.path_textBox = new System.Windows.Forms.TextBox();
            this.browse_butt = new System.Windows.Forms.Button();
            this.AdditShortCut_checkBox = new System.Windows.Forms.CheckBox();
            this.final_richTextBox = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.launch_checkBox = new System.Windows.Forms.CheckBox();
            this.next_butt = new System.Windows.Forms.Button();
            this.back_butt = new System.Windows.Forms.Button();
            this.launch_cb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "License agreement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please read the following important information before continuing.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(621, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please read the following License Agreement. You must accept the terms of this \r\n" +
    "agreement before continuing installation.";
            // 
            // LicenseTextBox1
            // 
            this.LicenseTextBox1.Location = new System.Drawing.Point(36, 174);
            this.LicenseTextBox1.Name = "LicenseTextBox1";
            this.LicenseTextBox1.ReadOnly = true;
            this.LicenseTextBox1.Size = new System.Drawing.Size(703, 229);
            this.LicenseTextBox1.TabIndex = 3;
            this.LicenseTextBox1.Text = resources.GetString("LicenseTextBox1.Text");
            // 
            // radioButton_agree
            // 
            this.radioButton_agree.AutoSize = true;
            this.radioButton_agree.Checked = true;
            this.radioButton_agree.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_agree.Location = new System.Drawing.Point(36, 431);
            this.radioButton_agree.Name = "radioButton_agree";
            this.radioButton_agree.Size = new System.Drawing.Size(209, 27);
            this.radioButton_agree.TabIndex = 4;
            this.radioButton_agree.TabStop = true;
            this.radioButton_agree.Text = "I accept the agreement";
            this.radioButton_agree.UseVisualStyleBackColor = true;
            this.radioButton_agree.CheckedChanged += new System.EventHandler(this.radioButton_agree_CheckedChanged);
            // 
            // radioButton_disagree
            // 
            this.radioButton_disagree.AutoSize = true;
            this.radioButton_disagree.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_disagree.Location = new System.Drawing.Point(36, 462);
            this.radioButton_disagree.Name = "radioButton_disagree";
            this.radioButton_disagree.Size = new System.Drawing.Size(265, 27);
            this.radioButton_disagree.TabIndex = 5;
            this.radioButton_disagree.Text = "I do not accept the agreement";
            this.radioButton_disagree.UseVisualStyleBackColor = true;
            this.radioButton_disagree.CheckedChanged += new System.EventHandler(this.radioButton_disagree_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(666, 543);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FreeSpace_label
            // 
            this.FreeSpace_label.AutoSize = true;
            this.FreeSpace_label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FreeSpace_label.Location = new System.Drawing.Point(36, 508);
            this.FreeSpace_label.Name = "FreeSpace_label";
            this.FreeSpace_label.Size = new System.Drawing.Size(333, 23);
            this.FreeSpace_label.TabIndex = 6;
            this.FreeSpace_label.Text = "At least 173,6 MB of free space is required.";
            this.FreeSpace_label.Visible = false;
            // 
            // path_textBox
            // 
            this.path_textBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.path_textBox.Location = new System.Drawing.Point(36, 218);
            this.path_textBox.Name = "path_textBox";
            this.path_textBox.Size = new System.Drawing.Size(598, 30);
            this.path_textBox.TabIndex = 8;
            this.path_textBox.Visible = false;
            // 
            // browse_butt
            // 
            this.browse_butt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.browse_butt.Location = new System.Drawing.Point(651, 219);
            this.browse_butt.Name = "browse_butt";
            this.browse_butt.Size = new System.Drawing.Size(94, 29);
            this.browse_butt.TabIndex = 7;
            this.browse_butt.Text = "Browse";
            this.browse_butt.UseVisualStyleBackColor = true;
            this.browse_butt.Visible = false;
            this.browse_butt.Click += new System.EventHandler(this.browse_butt_Click);
            // 
            // AdditShortCut_checkBox
            // 
            this.AdditShortCut_checkBox.AutoSize = true;
            this.AdditShortCut_checkBox.Checked = true;
            this.AdditShortCut_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AdditShortCut_checkBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditShortCut_checkBox.Location = new System.Drawing.Point(36, 220);
            this.AdditShortCut_checkBox.Name = "AdditShortCut_checkBox";
            this.AdditShortCut_checkBox.Size = new System.Drawing.Size(231, 27);
            this.AdditShortCut_checkBox.TabIndex = 9;
            this.AdditShortCut_checkBox.Text = "Create a Desktop shortcut";
            this.AdditShortCut_checkBox.UseVisualStyleBackColor = true;
            this.AdditShortCut_checkBox.Visible = false;
            this.AdditShortCut_checkBox.CheckedChanged += new System.EventHandler(this.AdditShortCut_checkBox_CheckedChanged);
            // 
            // final_richTextBox
            // 
            this.final_richTextBox.BackColor = System.Drawing.Color.White;
            this.final_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.final_richTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.final_richTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.final_richTextBox.Location = new System.Drawing.Point(36, 200);
            this.final_richTextBox.Name = "final_richTextBox";
            this.final_richTextBox.ReadOnly = true;
            this.final_richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.final_richTextBox.Size = new System.Drawing.Size(703, 229);
            this.final_richTextBox.TabIndex = 10;
            this.final_richTextBox.Text = "";
            this.final_richTextBox.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(703, 38);
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Visible = false;
            // 
            // launch_checkBox
            // 
            this.launch_checkBox.Checked = true;
            this.launch_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.launch_checkBox.Location = new System.Drawing.Point(0, 0);
            this.launch_checkBox.Name = "launch_checkBox";
            this.launch_checkBox.Size = new System.Drawing.Size(104, 24);
            this.launch_checkBox.TabIndex = 0;
            // 
            // next_butt
            // 
            this.next_butt.Location = new System.Drawing.Point(539, 543);
            this.next_butt.Name = "next_butt";
            this.next_butt.Size = new System.Drawing.Size(121, 37);
            this.next_butt.TabIndex = 11;
            this.next_butt.Text = "Next";
            this.next_butt.UseVisualStyleBackColor = true;
            this.next_butt.Click += new System.EventHandler(this.next_butt_Click);
            // 
            // back_butt
            // 
            this.back_butt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_butt.Location = new System.Drawing.Point(412, 544);
            this.back_butt.Name = "back_butt";
            this.back_butt.Size = new System.Drawing.Size(121, 37);
            this.back_butt.TabIndex = 12;
            this.back_butt.Text = "Back";
            this.back_butt.UseVisualStyleBackColor = true;
            this.back_butt.Visible = false;
            this.back_butt.Click += new System.EventHandler(this.back_butt_Click);
            // 
            // launch_cb
            // 
            this.launch_cb.AutoSize = true;
            this.launch_cb.Checked = true;
            this.launch_cb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.launch_cb.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.launch_cb.Location = new System.Drawing.Point(250, 305);
            this.launch_cb.Name = "launch_cb";
            this.launch_cb.Size = new System.Drawing.Size(205, 27);
            this.launch_cb.TabIndex = 14;
            this.launch_cb.Text = "Launch VPN Unlimited";
            this.launch_cb.UseVisualStyleBackColor = true;
            this.launch_cb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.LicenseTextBox1);
            this.Controls.Add(this.AdditShortCut_checkBox);
            this.Controls.Add(this.launch_cb);
            this.Controls.Add(this.browse_butt);
            this.Controls.Add(this.FreeSpace_label);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.radioButton_disagree);
            this.Controls.Add(this.radioButton_agree);
            this.Controls.Add(this.back_butt);
            this.Controls.Add(this.next_butt);
            this.Controls.Add(this.path_textBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.final_richTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Setup - VPN Unlimited ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox LicenseTextBox1;
        private System.Windows.Forms.RadioButton radioButton_agree;
        private System.Windows.Forms.RadioButton radioButton_disagree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button next_butt;
        private System.Windows.Forms.Label FreeSpace_label;
        private System.Windows.Forms.Button back_butt;
        private System.Windows.Forms.Button browse_butt;
        private System.Windows.Forms.TextBox path_textBox;
        private System.Windows.Forms.CheckBox AdditShortCut_checkBox;
        private System.Windows.Forms.RichTextBox final_richTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox launch_checkBox;
        private System.Windows.Forms.CheckBox launch_cb;
    }
}

