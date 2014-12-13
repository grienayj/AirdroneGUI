using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace AirDroneGUI
{
    public partial class Form1 : Form
    {

        volatile List<String> keys = new List<String>();
        Thread ComThread = null;
        volatile Boolean connected = false;
        SerialPort port;
        volatile int motVal = 0;
        volatile int Ctheta = 0;
        volatile int Cphi = 0;
        volatile int Cpsi = 0;

        volatile int rval = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keys.Contains(e.KeyCode.ToString()))
            { keys.Add(e.KeyCode.ToString()); }

            if (keys.Contains("Z"))
            {
                Ctheta++;

            }
            else if (keys.Contains("S"))
            {
                Ctheta--;
            }

            if (keys.Contains("E"))
            {
                Cpsi++;

            }
            else if (keys.Contains("A"))
            {
                Cpsi--;
            }

            if (keys.Contains("D"))
            {
                Cphi++;

            }
            else if (keys.Contains("Q"))
            {
                Cphi--;
            }

            if (keys.Contains("W"))
            {
                motVal++;

            }
            else if (keys.Contains("X"))
            {
                motVal--;
            }

            if (motVal > 100)
            { motVal = 100; }
            if (motVal < 0)
            { motVal = 0; }

            if (Ctheta > 50)
            { Ctheta = 50; }
            if (Ctheta < -50)
            { Ctheta = -50; }

            if (Cphi > 50)
            { Cphi = 50; }
            if (Cphi < -50)
            { Cphi = -50; }

            if (Cpsi > 50)
            { Cpsi = 50; }
            if (Cpsi < -50)
            { Cpsi = -50; }

            /*
            if (connected)
            {
                //byte[] b = new byte[3];
                /*if (keys.Contains("z"))
                {
                    motVal++;

                }
                else if (keys.Contains("s"))
                {
                    motVal--;
                }*

                if (motVal > 100)
                { motVal = 100; }
                if (motVal < 0)
                { motVal = 0; }
                
                b[0] = Convert.ToByte(0);
                b[1] = Convert.ToByte(motVal);
                b[2] = Convert.ToByte(motVal);
                /*b[3] = Convert.ToByte(motVal);
                b[4] = Convert.ToByte(motVal);
                b[5] = Convert.ToByte(motVal);
                b[6] = Convert.ToByte(motVal);
                b[7] = Convert.ToByte(motVal);
                b[8] = Convert.ToByte(motVal);*
                port.Write(b, 0, 3);
                //Thread.Sleep(10);*
            }*/

            trust_label.Text = motVal.ToString();
            Ctheta_label.Text = Ctheta.ToString();
            Cphi_label.Text = Cphi.ToString();
            Cpsi_label.Text = Cpsi.ToString();
            trust_trackBar.Value = motVal;
            Ctheta_trackBar.Value = Ctheta;
            Cphi_trackBar.Value = Cphi;
            Cpsi_trackBar.Value = Cpsi;

            label_rval.Text = rval.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keys.Contains(e.KeyCode.ToString()))
            { keys.Remove(e.KeyCode.ToString()); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
            {
                port.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
/*
        private volatile int _trottleValue = 0;
        public delegate int TrottleValueDelagate(int val);
        public int trottleValue
        {
           // get
          //  {
               // TrottleValueDelagate del = new TrottleValueDelagate(GetTrottleValue);
          //      if (!InvokeRequired)
          //      {
           //         return _trottleValue;
           //         //return true;
           //     }
            //    else
            //    {
                   //return (int)Invoke(del, new int() { val });
                   // return (int)Invoke(del, new int());
            //    }
          //  }
            set
            {
                if (!InvokeRequired)
                {
                    // buttonConnect.Enabled = value;
                    _trottleValue = value;
                    Trottle_label.Text = value.ToString();
                    Trottle_progressBar.Value = value;
                }
                else
                {
                    Invoke(new Action(() => trottleValue = value));
                    //Invoke(new Action<int>(UpdateProgress), percentComplete);
                }

            }
        }
        private int GetTrottleValue(int b)
        {
            return _trottleValue;
        }
        */
        private void Connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connected)
                {
                    port = new SerialPort("COM6", 38400);
                    port.Open();
                    //while (!port.IsOpen) { }
                    Connect_button.Text = "Disconnect";
                    ///
                    Thread.Sleep(100);
                    ComThread = new System.Threading.Thread(() => ComThread_Task());
                    ComThread.Start();
                    connected = true;
                }
                else
                {
                    port.Close();
                    ComThread.Abort();
                    Connect_button.Text = "Connect";
                    connected = false;
                }
            }
            catch(System.IO.IOException err) { MessageBox.Show("connection error : "+err.Message); }
        }

        private void ComThread_Task()
        {
            try
            {
                while (connected)
                {
                    byte[] b = new byte[5];
                    /*if (keys.Contains("z"))
                    {
                        motVal++;

                    }
                    else if (keys.Contains("s"))
                    {
                        motVal--;
                    }*/

                    if (motVal > 100)
                    { motVal = 100; }
                    if (motVal <= 0)
                    { motVal = 1; }

                    b[0] = Convert.ToByte(motVal);
                    b[1] = Convert.ToByte(motVal);
                    b[2] = Convert.ToByte(motVal);
                    b[3] = Convert.ToByte(motVal);
                    //b[4] = Convert.ToByte(motVal);
                    /*b[5] = Convert.ToByte(motVal);
                    b[6] = Convert.ToByte(motVal);
                    b[7] = Convert.ToByte(motVal);
                    b[8] = Convert.ToByte(motVal);*/
                    port.Write(b, 0, 1);
                    port.Write(b, 1, 1);
                    port.Write(b, 2, 1);
                    port.Write(b, 3, 1);
                    //port.Read(b, 0, 1);

                    rval = Convert.ToInt32(b[0]);

                   // Thread.Sleep(10);
                }
            }
            catch (System.IO.IOException err) { MessageBox.Show("send error : " + err.Message); }
        }

    }
}
/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace AirDroneGUI
{
    public partial class Form1 : Form
    {

        volatile List<String> keys = new List<String>();
        Thread ComThread = null;
        volatile Boolean connected = false;
        SerialPort port;
        volatile int motVal = 0;

        volatile byte labelText=6;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keys.Contains(e.KeyCode.ToString()))
            { keys.Add(e.KeyCode.ToString()); }
            
            if (keys.Contains("Z"))
            {
                motVal++;

            }
            else if (keys.Contains("S"))
            {
                motVal--;
            }

            if (motVal > 100)
            { motVal = 100; }
            if (motVal < 0)
            { motVal = 0; }
            /*
            if (connected)
            {
                //byte[] b = new byte[3];
                /*if (keys.Contains("z"))
                {
                    motVal++;

                }
                else if (keys.Contains("s"))
                {
                    motVal--;
                }*

                if (motVal > 100)
                { motVal = 100; }
                if (motVal < 0)
                { motVal = 0; }
                
                b[0] = Convert.ToByte(0);
                b[1] = Convert.ToByte(motVal);
                b[2] = Convert.ToByte(motVal);
                /*b[3] = Convert.ToByte(motVal);
                b[4] = Convert.ToByte(motVal);
                b[5] = Convert.ToByte(motVal);
                b[6] = Convert.ToByte(motVal);
                b[7] = Convert.ToByte(motVal);
                b[8] = Convert.ToByte(motVal);*
                port.Write(b, 0, 3);
                //Thread.Sleep(10);*
            }*

            Trottle_label.Text = motVal.ToString();
            Trottle_progressBar.Value = motVal;
           // label1.Text = labelText.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keys.Contains(e.KeyCode.ToString()))
            { keys.Remove(e.KeyCode.ToString()); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
            {
                port.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
/*
        private volatile int _trottleValue = 0;
        public delegate int TrottleValueDelagate(int val);
        public int trottleValue
        {
           // get
          //  {
               // TrottleValueDelagate del = new TrottleValueDelagate(GetTrottleValue);
          //      if (!InvokeRequired)
          //      {
           //         return _trottleValue;
           //         //return true;
           //     }
            //    else
            //    {
                   //return (int)Invoke(del, new int() { val });
                   // return (int)Invoke(del, new int());
            //    }
          //  }
            set
            {
                if (!InvokeRequired)
                {
                    // buttonConnect.Enabled = value;
                    _trottleValue = value;
                    Trottle_label.Text = value.ToString();
                    Trottle_progressBar.Value = value;
                }
                else
                {
                    Invoke(new Action(() => trottleValue = value));
                    //Invoke(new Action<int>(UpdateProgress), percentComplete);
                }

            }
        }
        private int GetTrottleValue(int b)
        {
            return _trottleValue;
        }
        *
        private void Connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!connected)
                {
                    port = new SerialPort("COM4", 38400);
                    port.Open();
                    //while (!port.IsOpen) { }
                    Connect_button.Text = "Disconnect";
                    ///
                    Thread.Sleep(100);
                    ComThread = new System.Threading.Thread(() => ComThread_Task());
                    ComThread.Start();
                    connected = true;
                }
                else
                {
                    port.Close();
                    ComThread.Abort();
                    Connect_button.Text = "Connect";
                    connected = false;
                }
            }
            catch(System.IO.IOException err) { MessageBox.Show("connection error : "+err.Message); }
        }

        private void ComThread_Task()
        {
            try
            {
                while (connected)
                {
                    byte[] b = new byte[5];
                    /*if (keys.Contains("z"))
                    {
                        motVal++;

                    }
                    else if (keys.Contains("s"))
                    {
                        motVal--;
                    }*

                    if (motVal > 100)
                    { motVal = 100; }
                    if (motVal < 0)
                    { motVal = 0; }

                    b[0] = Convert.ToByte(motVal);
                    
                    b[1] = Convert.ToByte(motVal);
                    b[2] = Convert.ToByte(motVal);
                    b[3] = Convert.ToByte(motVal);
                    b[4] = Convert.ToByte(motVal);
                    
                    //b[5] = Convert.ToByte(crc(b,5));
                    
                    /*b[6] = Convert.ToByte(motVal);
                    b[7] = Convert.ToByte(motVal);
                    b[8] = Convert.ToByte(motVal);*
                    port.Write(b, 0, 1);
                    Thread.Sleep(10);
                }
            }
            catch (System.IO.IOException err) { MessageBox.Show("send error : " + err.Message); }
        }

        private byte crc(byte[] data, int length)
        {
            byte result=0xff;
            byte poly=0xcd;

            for(int i=0;i<length;i++)
            {
                if(((result^data[i]) & 0x80)>0)
                {
                    result = (byte)((result << (int)1) ^ poly);
                }else
                {
                    result = (byte)(result << (int)1);
                }
            }

            labelText = result;

            return result;
        }

    }
}
*/