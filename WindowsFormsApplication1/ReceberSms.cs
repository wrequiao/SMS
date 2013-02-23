using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class ReceberSms : Form
    {
        SerialPort sp = new SerialPort();

        public ReceberSms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.BaudRate = 19200;
            sp.WriteBufferSize = 1024;
            try
            {
                //Open serial port
                sp.PortName = "COM14";
                sp.Open();
                //sp.Write("Connected" + "\n");
            }
            catch (System.Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Write line to serial port

                string s = txtSMS.Text + "\r";
                //sp.WriteLine("at+CMGR=1\r");
                sp.Write(s);
                txtSMS.Text = "";
            }
            catch (System.Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //Cler text box

                txtSMS.Text = "";
                //Read serial port and displayed the data in text box
                //txtSMS.Text = sp.ReadLine();

                txtSMS.Text = sp.ReadExisting();

            }
            catch (System.Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSMS.Text = "";
            sp.Close();
        }


    }
}
