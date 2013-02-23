using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.SMS;
using System.IO.Ports;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        #region Private Variables
        SerialPort port = new SerialPort();
        clsSMS objclsSMS = new clsSMS();
        ShortMessageCollection objShortMessageCollection = new ShortMessageCollection();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SmsClass sms = new SmsClass("COM3"); //new SmsClass("COM11");
            sms.sendSms(txtFone.Text, rtxtMsg.Text);            
        }

        private void btreceber_Click(object sender, EventArgs e)
        {
            SmsClass sms = new SmsClass("COM3"); //new SmsClass("COM11");
            rtxtMsg.Text = sms.receivedSms();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //.............................................. Send SMS ....................................................
            try
            {

                if (objclsSMS.sendMsg(this.port, this.txtFone.Text, this.rtxtMsg.Text))
                {
                    MessageBox.Show("Message has sent successfully");
                }
                else
                {
                    MessageBox.Show("Failed to send message");
                }

            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void btConectar_Click(object sender, EventArgs e)
        {
            try
            {
                //Open communication port 
                this.port = objclsSMS.OpenPort(this.txtPorta.Text, /*baud rate*/9600, /*data bits*/8, /*read time out*/300, /*write time out*/300);

                if (this.port != null)
                {
                    status.Text = "Modem is connected at PORT " + this.txtPorta.Text;                   
                }

                else
                {
                    status.Text = "Invalid port settings";
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        #region Error Log
        public void ErrorLog(string Message)
        {
            StreamWriter sw = null;

            try
            {
                string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
                string sPathName = @"D:\";

                string sYear = DateTime.Now.Year.ToString();
                string sMonth = DateTime.Now.Month.ToString();
                string sDay = DateTime.Now.Day.ToString();

                string sErrorTime = sDay + "-" + sMonth + "-" + sYear;

                sw = new StreamWriter(sPathName + "SMSapplication_ErrorLog_" + sErrorTime + ".txt", true);

                sw.WriteLine(sLogFormat + Message);
                sw.Flush();

            }
            catch (Exception ex)
            {
                ErrorLog(ex.ToString());
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();
                    sw.Close();
                }
            }


        }
        #endregion 

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {               
                objclsSMS.ClosePort(this.port);
                status.Text = "Desconectado";
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //count SMS 
                int uCountSMS = objclsSMS.CountSMSmessages(this.port);
                if (uCountSMS > 0)
                {
                    // If SMS exist then read SMS
                    #region Read SMS
                    //.............................................. Read all SMS ....................................................
                    objShortMessageCollection = objclsSMS.ReadSMS(this.port);
                    foreach (ShortMessage msg in objShortMessageCollection)
                    {

                        ListViewItem item = new ListViewItem(new string[] { msg.Index, msg.Sender, msg.Message });
                        item.Tag = msg;
                        resultado.Text += msg.Message.ToString();
                       // lvwMessages.Items.Add(item);

                    }
                    #endregion
                }
                else
                {
                   // lvwMessages.Clear();
                    resultado.Text = "";
                    status.Text = "There is no message in SIM";


                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                //Count SMS
                int uCountSMS = objclsSMS.CountSMSmessages(this.port);
                this.txtTotSMS.Text = uCountSMS.ToString();
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Count SMS 
                int uCountSMS = objclsSMS.CountSMSmessages(this.port);
                if (uCountSMS > 0)
                {
                    DialogResult dr = MessageBox.Show("Are u sure u want to delete the SMS?", "Delete confirmation", MessageBoxButtons.YesNo);

                    if (dr.ToString() == "Yes")
                    {
                        #region Delete SMS                       
                            //...............................................Delete all SMS ....................................................

                            #region Delete all SMS
                            string strCommand = "AT+CMGD=1,4";
                            if (objclsSMS.DeleteMsg(this.port, strCommand))
                            {
                                status.Text = "Messages has deleted successfuly ";
                            }
                            else
                            {
                                status.Text = "Failed to delete messages ";
                            }
                            #endregion                       
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //Count SMS 
                int uCountSMS = objclsSMS.CountSMSmessages(this.port);
                if (uCountSMS > 0)
                {
                    DialogResult dr = MessageBox.Show("Are u sure u want to delete the SMS?", "Delete confirmation", MessageBoxButtons.YesNo);

                    if (dr.ToString() == "Yes")
                    {
                        #region Delete SMS
                            //...............................................Delete Read SMS ....................................................

                            #region Delete Read SMS
                            string strCommand = "AT+CMGD=1,3";
                            if (objclsSMS.DeleteMsg(this.port, strCommand))
                            {
                               status.Text = "Messages has deleted successfuly ";
                            }
                            else
                            {
                                status.Text = "Failed to delete messages ";
                            }
                            #endregion

                       
                        #endregion
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message);
            }


          
        }
    }
}
