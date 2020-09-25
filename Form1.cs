using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoLed
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;

        public Form1()
        {
            InitializeComponent();

            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM4";
            Arduino.BaudRate = 9600;
            Arduino.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Closing(object sender, FormClosedEventArgs e)
        {
            if (Arduino.IsOpen)
                Arduino.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("E");
        }
    }
}
