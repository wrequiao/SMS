using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{

    //modulo com as funções de ligação a um modem GMS (telemovel), e envio de sms's
    namespace SMS
    {
        class SmsClass //cria a class smsClass
        {
            SerialPort serialPort;
            public SmsClass(string comPort)//passar COM1
            {
                this.serialPort = new SerialPort(); //abre uma nova porta serie
                this.serialPort.PortName = comPort; //chama-lhe comPort
                this.serialPort.BaudRate = 9600; //define a BaudRate para 9600bps
                this.serialPort.Parity = Parity.None; // define a paridade como nenhuma
                this.serialPort.DataBits = 8; //define os bits de dados como 8 bits
                this.serialPort.StopBits = StopBits.One; // define o valor de stopbits como 1
                this.serialPort.Handshake = Handshake.None;//Handshake.RequestToSend; // define a forma com é feito o HandShake

                this.serialPort.Encoding = Encoding.GetEncoding("iso-8859-1");
                this.serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                this.serialPort.Open();

                this.serialPort.DtrEnable = true; //activa o DTR
                this.serialPort.RtsEnable = true; //activa o RTS
                this.serialPort.NewLine = System.Environment.NewLine;                
            }

            public bool sendSms(string telemovel, string sms) // envia sms
            {
                string messages = null;
                messages = sms;
                if (this.serialPort.IsOpen == true) //valida se a porta serie está aberta
                {
                    try
                    {
                        this.serialPort.WriteLine("AT" + (char)(13)); // escreve na porta serie "AT + char(13)"
                        Thread.Sleep(4); //delay
                        this.serialPort.WriteLine("AT+CMGF=1" + (char)(13)); //escreve na porta serie "AT+CMGF=1 + char(13)"
                        Thread.Sleep(5); // delay
                        this.serialPort.WriteLine("AT+CMGS=\"" + telemovel + "\""); //Escreve na porta AT+CMGS=\"telemovel"\"
                        Thread.Sleep(10); //delay
                        this.serialPort.WriteLine(messages + (char)(26)); // escreve a mensagem na porta
                        this.serialPort.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Source);
                    }
                    return true;
                }
                else
                    return false;
            }

            public void Opens()
            {
                if (this.serialPort.IsOpen == false)
                {
                    this.serialPort.Open();
                }
            }
            public void Closes()
            {
                if (this.serialPort.IsOpen == true)
                {
                    this.serialPort.Close();
                }
            }





            private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadExisting();
                Console.WriteLine("Data Received:");
                Console.Write(indata);
            }


            public string receivedSms() // envia sms
            {
                string messages = null;
                if (this.serialPort.IsOpen == true) //valida se a porta serie está aberta
                {
                    try
                    {
                       // this.serialPort.WriteLine("AT" + (char)(13)); // escreve na porta serie "AT + char(13)"
                       // Thread.Sleep(4); //delay
                       // this.serialPort.WriteLine("AT+CMGL=ALL" + (char)(13)); //escreve na porta serie "AT+CMGF=1 + char(13)"
                       // Thread.Sleep(5);

                        this.serialPort.Write("AT+CMGR=1\n\r");
                        System.Threading.Thread.Sleep(1000);
                        messages = this.serialPort.ReadExisting();


                      //  messages += this.serialPort.ReadLine();
                       // Thread.Sleep(5);

                        //while (this.serialPort.IsOpen)
                        //{
                        //    this.serialPort.WriteLine("AT+CMGL=ALL" + (char)(13)); //escreve na porta serie "AT+CMGF=1 + char(13)"
                        //    Thread.Sleep(5);
                        //    messages += this.serialPort.ReadLine();
                        //    MessageBox.Show(messages);
                        //}                     
                                            
                        this.serialPort.Close();
                        return messages;
                    }
                    catch (Exception ex)
                    {
                        this.serialPort.Close();
                        MessageBox.Show(ex.Source);
                    }
                    return "nada";
                }
                else
                    return "portafechada";
            }

        }
    }
}