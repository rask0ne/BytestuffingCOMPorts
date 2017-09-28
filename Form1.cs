using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RS232_Communicator
{
    public partial class Form1 : Form
    {
        public SerialPort comPortA = new SerialPort();
        public SerialPort comPortB = new SerialPort();
        public delegate void AddDataDelegate(string data, string recvPort);
        public AddDataDelegate myDelegate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BAUD RATES
            int[] baudRates = new int [] {300, 600, 1200, 2400, 9600, 14400, 19200, 38400, 57600, 115200};
            //add baud rates to comboBoxes of ports
            for (int i = 0; i < baudRates.Length; i++)
            {
                baudBoxA.Items.Add(baudRates[i]);
                baudBoxB.Items.Add(baudRates[i]);
            }
            //setting 9600 rate as default by start
            baudBoxA.SelectedIndex = 4;
            baudBoxB.SelectedIndex = 4;
            
            //AVAILABLE COM PORTS
            string[] ArrayComPortsNames = null;
            int index = -1;
            string ComPortName = null;
            
            ArrayComPortsNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                comBoxA.Items.Add(ArrayComPortsNames[index]);
                comBoxB.Items.Add(ArrayComPortsNames[index]);
            }

            while (!((ArrayComPortsNames[index] == ComPortName) || (index == ArrayComPortsNames.GetUpperBound(0))));
            Array.Sort(ArrayComPortsNames);

            if (index == ArrayComPortsNames.GetUpperBound(0))
            {
                ComPortName = ArrayComPortsNames[0];
            }
            comBoxA.Text = ArrayComPortsNames[0];
            comBoxB.Text = ArrayComPortsNames[0];

            //Invoke function outside of thread
            this.myDelegate = new AddDataDelegate(PostData);
        }

        private void connectButtonA_Click(object sender, EventArgs e)
        {
            //Open Port
            if (Convert.ToString(portButtonA.Text) == "Connect")
            {
                try
                {
                    //Set Port Settings
                    comPortA.PortName = Convert.ToString(comBoxA.SelectedItem);
                    comPortA.BaudRate = Convert.ToInt32(baudBoxA.SelectedItem);
                    comPortA.DataBits = 8;
                    comPortA.Handshake = Handshake.XOnXOff;
                    comPortA.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerA);

                    comPortA.Open();
                    portButtonA.Text = "Disconnect";
                    comBoxA.Enabled = false;
                    baudBoxA.Enabled = false;
                }
                catch(UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//Close Port
            else if (Convert.ToString(portButtonA.Text) == "Disconnect")
            {
                comPortA.Close();
                portButtonA.Visible = false;
            }
        }

        private void connectButtonB_Click(object sender, EventArgs e)
        {
            //Open Port
            if (Convert.ToString(portButtonB.Text) == "Connect")
            {
                try
                {
                    //Set Port Settings
                    comPortB.PortName = Convert.ToString(comBoxB.SelectedItem);
                    comPortB.BaudRate = Convert.ToInt32(baudBoxB.SelectedItem);
                    comPortB.DataBits = 8;
                    comPortB.Handshake = Handshake.XOnXOff;
                    comPortB.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandlerB);
                    
                    comPortB.Open();
                    portButtonB.Text = "Disconnect";
                    comBoxB.Enabled = false;
                    baudBoxB.Enabled = false;
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//Close port
            else if (Convert.ToString(portButtonB.Text) == "Disconnect")
            {
                comPortB.Close();
                portButtonB.Visible = false;
            }
        }

        private void sendButtonA_Click(object sender, EventArgs e)
        {
            if(!(comPortA.IsOpen))
            {
                MessageBox.Show("COM Port A not open. Cannot send message.");
            }
            else //send message
            {
                String message = msgBoxA.Text;
                byte[] data = new byte[message.Length];

                int index = 0;
                foreach (var ch in message)
                {
                    data[index++] = (byte)ch;
                }
                byte[] newData = ByteStuffing.Direct(data, 2, 1);
                //comPortA.RtsEnable = true;
                comPortA.Write(newData, 0, newData.Length);
                //Thread.Sleep(100); // пауза для корректного завершения работы передатчика
                //comPortA.RtsEnable = false;
                msgBoxA.Text = "";
            }
        }

        private void sendButtonB_Click(object sender, EventArgs e)
        {
            if (!(comPortB.IsOpen))
            {
                MessageBox.Show("COM Port B not open. Cannot send message.");
            }
            else //send message
            {
                String message = msgBoxB.Text;
                byte[] data = new byte[message.Length];

                int index = 0;
                foreach (var ch in message)
                {
                    data[index++] = (byte)ch;
                }
                byte[] newData = ByteStuffing.Direct(data, 1, 2);
                //comPortB.RtsEnable = true;
                comPortB.Write(newData, 0, newData.Length);
                //comPortB.RtsEnable = false;
                msgBoxB.Text = "";
            }
        }

        private void DataReceivedHandlerA(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            byte[] data = new byte[sp.BytesToRead];
            sp.Read(data, 0, data.Length);
            data = ByteStuffing.Reverse(data, 1);
            if (data != null)
            {
                string message_temp = "";
                if (data[0] == 1)
                    message_temp = "Message from COM1";
                else
                    message_temp = "Message from COM2";
                data[0] = (byte)' ';
                foreach (var a in data)
                {
                    message_temp += (char)a;
                }
                recvTextA.Invoke(this.myDelegate, new Object[] { message_temp, "A" });
            }            
        }

        private void DataReceivedHandlerB(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            byte[] data = new byte[sp.BytesToRead];
            sp.Read(data, 0, data.Length);
            data = ByteStuffing.Reverse(data, 2);
            if (data != null)
            {
                string message_temp = "";
                if (data[0] == 1)
                    message_temp = "From COM1";
                else
                    message_temp = "From COM2";
                data[0] = (byte)' ';
                foreach (var a in data)
                {
                    message_temp += (char)a;
                }
                recvTextB.Invoke(this.myDelegate, new Object[] { message_temp, "B" });
            }
        }

        public void PostData(string data, string recvPort)
        {
            if (recvPort == "A")
            {
                recvTextA.Text = Convert.ToString(data);
            }
            else if (recvPort == "B")
            {
                recvTextB.Text = Convert.ToString(data);
            }
        }
    }
}
