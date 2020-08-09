
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mega2560_Hex_Flasher
{
    public partial class Form1 : Form
    {
        String cmdout="==================================================================================";
        const String avr_no_connect = "ser_open(): can't open device";
        const String avr_done = "Thank you.";
        const String avr_bad_file = "ERROR: No valid record found in Intel Hex file";
        const String avr_bad_dir = "can't open input file";
        const String avr_connected = "AVR device initialized and ready to accept instructions";
        const String avr_verifying = "verifying ...";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CB_Port_Selector.Items.AddRange(SerialPort.GetPortNames());
            CheckForIllegalCrossThreadCalls = false;
            OFD_FileOpen.InitialDirectory = Directory.GetCurrentDirectory();

            //my cmd control options
            cmd.StartInfo.CreateNoWindow = true;          
            cmd.StartInfo.RedirectStandardInput = true;    
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.RedirectStandardError = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.EnableRaisingEvents = true;
            cmd.StartInfo.FileName = "CMD.exe"; 
            
        }

        private void BTN_Browse_Click(object sender, EventArgs e)
        {
            if (OFD_FileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //adding quotes to filename just in case there are spaces.
                String strfilename = OFD_FileOpen.FileName;
                strfilename = strfilename.Replace(@"\", "/");
                TB_File_Path.Text = "\""+strfilename+ "\"";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check if path selected
            if (TB_File_Path.Text == "")
            {
                TB_Msg.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + "No file selected!" + Environment.NewLine);
                return;
            }
            //check if port selected
            if (CB_Port_Selector.Text == "")
            {
                //please select com
                TB_Msg.AppendText(DateTime.Now.ToString("[HH:mm:ss] ")+"No COM port selected!"+Environment.NewLine);
                return;
            }
            //command for cmd
            String command = "jl_flasher -Cjl_flasher.conf -cwiring -pm2560 -q -D -Uflash:w:"+ TB_File_Path.Text+":i -P"+ CB_Port_Selector.Text+" & exit";
            String temp = "";

            //start flash msg
            TB_Msg.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + "Please don't disconnect device." + Environment.NewLine);
            cmd.Start();
            cmd.StandardInput.WriteLine(command);


            //check progress and errors
            temp = cmd.StandardError.ReadToEnd();
            cmdout += temp;
            if (temp.Contains(avr_no_connect))
            {
                TB_Msg.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + "ERROR: Could not connect to device." + Environment.NewLine);
            }
            if (temp.Contains(avr_bad_file))
            {
                TB_Msg.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + "ERROR: Please check firmware file." + Environment.NewLine);
            }
            if (temp.Contains(avr_bad_dir))
            {
                TB_Msg.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + "ERROR: Can't find firmware file." + Environment.NewLine);
            }
            if (temp.Contains(avr_verifying))
            {
                TB_Msg.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + "Upload success. Flash Data Verified." + Environment.NewLine);
            }
            if (temp.Contains(avr_done))
            {
                TB_Msg.AppendText(DateTime.Now.ToString("[HH:mm:ss] ") + "Finished. You may disconect." + Environment.NewLine);
            }
            cmd.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write(cmdout);
            System.Diagnostics.Debug.Write("==================================================================================");
        }
    }
}
