namespace Mega2560_Hex_Flasher
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
            this.CB_Port_Selector = new System.Windows.Forms.ComboBox();
            this.BTN_Browse = new System.Windows.Forms.Button();
            this.OFD_FileOpen = new System.Windows.Forms.OpenFileDialog();
            this.BTN_Begin_Flash = new System.Windows.Forms.Button();
            this.cmd = new System.Diagnostics.Process();
            this.button2 = new System.Windows.Forms.Button();
            this.LB_Port = new System.Windows.Forms.Label();
            this.TB_File_Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Msg = new System.Windows.Forms.TextBox();
            this.TB_FW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PB_Status = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // CB_Port_Selector
            // 
            this.CB_Port_Selector.BackColor = System.Drawing.SystemColors.Control;
            this.CB_Port_Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Port_Selector.FormattingEnabled = true;
            this.CB_Port_Selector.Location = new System.Drawing.Point(35, 38);
            this.CB_Port_Selector.Name = "CB_Port_Selector";
            this.CB_Port_Selector.Size = new System.Drawing.Size(99, 21);
            this.CB_Port_Selector.TabIndex = 0;
            // 
            // BTN_Browse
            // 
            this.BTN_Browse.Location = new System.Drawing.Point(224, 8);
            this.BTN_Browse.Name = "BTN_Browse";
            this.BTN_Browse.Size = new System.Drawing.Size(54, 23);
            this.BTN_Browse.TabIndex = 2;
            this.BTN_Browse.Text = "Browse";
            this.BTN_Browse.UseVisualStyleBackColor = true;
            this.BTN_Browse.Click += new System.EventHandler(this.BTN_Browse_Click);
            // 
            // OFD_FileOpen
            // 
            this.OFD_FileOpen.Filter = " HEX File (*.hex)|*.hex|All files (*.*)|*.*";
            // 
            // BTN_Begin_Flash
            // 
            this.BTN_Begin_Flash.Location = new System.Drawing.Point(198, 163);
            this.BTN_Begin_Flash.Name = "BTN_Begin_Flash";
            this.BTN_Begin_Flash.Size = new System.Drawing.Size(80, 23);
            this.BTN_Begin_Flash.TabIndex = 4;
            this.BTN_Begin_Flash.Text = "Flash";
            this.BTN_Begin_Flash.UseVisualStyleBackColor = true;
            this.BTN_Begin_Flash.Click += new System.EventHandler(this.BTN_Flash_Click);
            // 
            // cmd
            // 
            this.cmd.StartInfo.Domain = "";
            this.cmd.StartInfo.LoadUserProfile = false;
            this.cmd.StartInfo.Password = null;
            this.cmd.StartInfo.StandardErrorEncoding = null;
            this.cmd.StartInfo.StandardOutputEncoding = null;
            this.cmd.StartInfo.UserName = "";
            this.cmd.SynchronizingObject = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "s";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LB_Port
            // 
            this.LB_Port.BackColor = System.Drawing.SystemColors.Window;
            this.LB_Port.Location = new System.Drawing.Point(8, 38);
            this.LB_Port.Name = "LB_Port";
            this.LB_Port.Size = new System.Drawing.Size(36, 21);
            this.LB_Port.TabIndex = 6;
            this.LB_Port.Text = "Port: ";
            this.LB_Port.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_File_Path
            // 
            this.TB_File_Path.Location = new System.Drawing.Point(35, 10);
            this.TB_File_Path.Name = "TB_File_Path";
            this.TB_File_Path.Size = new System.Drawing.Size(183, 20);
            this.TB_File_Path.TabIndex = 7;
            this.TB_File_Path.WordWrap = false;
            this.TB_File_Path.TextChanged += new System.EventHandler(this.TB_File_Path_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "File: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Msg
            // 
            this.TB_Msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Msg.Location = new System.Drawing.Point(12, 65);
            this.TB_Msg.Multiline = true;
            this.TB_Msg.Name = "TB_Msg";
            this.TB_Msg.ReadOnly = true;
            this.TB_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Msg.Size = new System.Drawing.Size(266, 92);
            this.TB_Msg.TabIndex = 9;
            // 
            // TB_FW
            // 
            this.TB_FW.Location = new System.Drawing.Point(173, 38);
            this.TB_FW.Name = "TB_FW";
            this.TB_FW.ReadOnly = true;
            this.TB_FW.Size = new System.Drawing.Size(105, 20);
            this.TB_FW.TabIndex = 10;
            this.TB_FW.WordWrap = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(141, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "F/W:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_Status
            // 
            this.PB_Status.Location = new System.Drawing.Point(11, 163);
            this.PB_Status.Name = "PB_Status";
            this.PB_Status.Size = new System.Drawing.Size(181, 23);
            this.PB_Status.TabIndex = 12;
            this.PB_Status.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(290, 191);
            this.Controls.Add(this.PB_Status);
            this.Controls.Add(this.TB_FW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_File_Path);
            this.Controls.Add(this.CB_Port_Selector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Port);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTN_Begin_Flash);
            this.Controls.Add(this.BTN_Browse);
            this.Controls.Add(this.TB_Msg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JL UA Hex Flasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_Port_Selector;
        private System.Windows.Forms.Button BTN_Browse;
        private System.Windows.Forms.OpenFileDialog OFD_FileOpen;
        private System.Windows.Forms.Button BTN_Begin_Flash;
        private System.Diagnostics.Process cmd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LB_Port;
        private System.Windows.Forms.TextBox TB_File_Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Msg;
        private System.Windows.Forms.TextBox TB_FW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PB_Status;
    }
}

