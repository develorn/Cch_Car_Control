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


namespace Car_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btClose.Enabled = false;
            btRight.Enabled = false;
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())  //przypisuje do s znalezione porty i dodaje do panelu. jest tak dlugo az bedzie puste getport
            {
                cmbPort.Items.Add(s);
            }  
        }

        public System.IO.Ports.SerialPort sport;
        string Data_uart = String.Empty;
        bool open_port = false;
        bool keyup = false;   //to checked double pressed key
        bool keydown = false;
        bool keyleft = false;
        bool keyright = false;
        /*********************/
        bool forw = true;    //to send data to Arm just one time
        bool forwleft = true;
        bool forwright = true;
        bool back = true;
        bool backleft = true;
        bool backright = true;
        bool left = true;
        bool right = true;        
        /*********************/

        public void serialport_connect(string port, int baudRate, Parity parity, int dataBits, StopBits stopbits)
        {
            
            sport = new System.IO.Ports.SerialPort(port, baudRate, parity, dataBits, stopbits); //nowy obiekt klasy o tych parametrach          

            try
            {
                sport.Open(); //otwarcie portu
                btOpen.Enabled = false; //zablokowanie przed ponownym otwarciem
                btClose.Enabled = true; //odblokowanie aby zamknac polaczenie
                        
                sport.DataReceived += new SerialDataReceivedEventHandler(sport_DataReceived); // handler do przerwania gdy nastapi nadejscie danych. datareceived tak samo jak w F12 napisane
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error ;(");
            }
        }

        private void sport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Data_uart = sport.ReadExisting();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in data received");
            }
            
        }
        private void SendText(string text)
        {

            try
            {
                sport.Write(text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error in sending data");
            } 
                       
        }        
        private void btOpen_Click(object sender, EventArgs e)
        {
            try
            {
                int baudrate = 19200;
                int databits = 8;
                string parity_bits = "0";
                string stop_bits = "1";
                //int baudrate = Convert.ToInt32(cmbBaudrate.Text);
                //int databits = Convert.ToInt32(cmbDatabits.Text);
                Parity parity = (Parity)Enum.Parse(typeof(Parity), parity_bits);
                string port = cmbPort.Text;
                StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), stop_bits);

                serialport_connect(port, baudrate, parity, databits, stopbits);
                flControl.BackColor = System.Drawing.Color.DarkGreen;
                open_port = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Check your settings\n Port can't be open", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            if (sport.IsOpen)
            {
                sport.Close();
                btClose.Enabled = false;
                btOpen.Enabled = true;
                flControl.BackColor = System.Drawing.Color.DarkRed;  //zmiana koloru kontrolki
            }
        }
       
        private void key_press_check()
        {
            if (keyup == true && keydown == false && keyleft == false && keyright == false && forw == true)
            { 
                //"up"
                btUp.BackColor = System.Drawing.Color.DarkRed;
                btDown.BackColor = System.Drawing.Color.MediumBlue;
                btLeft.BackColor = System.Drawing.Color.MediumBlue;
                btRight.BackColor = System.Drawing.Color.MediumBlue;
                SendText("forw%");
                forw = false;
                forwleft = true;
                forwright = true;
                left = true;
                right = true;
                lbl.Text = "up";
            }
            else if ((keyup == true && keydown == false && keyleft == true && keyright == false) && forwleft == true)
            {
                //"up and left";
                btUp.BackColor = System.Drawing.Color.DarkRed;
                btDown.BackColor = System.Drawing.Color.MediumBlue;
                btLeft.BackColor = System.Drawing.Color.DarkRed;
                btRight.BackColor = System.Drawing.Color.MediumBlue;
                SendText("forwleft%");
                forwleft = false;
                forw = true;
                left = true;
                lbl.Text = "up & left";
            }
            else if ((keyup == true && keydown == false && keyleft == false && keyright == true) && forwright == true)
            {
                //"up and right";
                btUp.BackColor = System.Drawing.Color.DarkRed;
                btDown.BackColor = System.Drawing.Color.MediumBlue;
                btLeft.BackColor = System.Drawing.Color.MediumBlue;
                btRight.BackColor = System.Drawing.Color.DarkRed;
                SendText("forwright%");
                forwright = false;
                forw = true;
                right = true;
                lbl.Text = "up & right";
            }
            else if (keyup == false && keydown == true && keyleft == false && keyright == false && back == true)
            {
                //"down";
                btUp.BackColor = System.Drawing.Color.MediumBlue;
                btDown.BackColor = System.Drawing.Color.DarkRed;
                btLeft.BackColor = System.Drawing.Color.MediumBlue;
                btRight.BackColor = System.Drawing.Color.MediumBlue;
                SendText("back%");
                back = false;
                backleft = true;
                backright = true;
                lbl.Text = "down";
            }
            else if (keyup == false && keydown == true && keyleft == true && keyright == false && backleft == true)
            {
                //"down and left";
                btUp.BackColor = System.Drawing.Color.MediumBlue;
                btDown.BackColor = System.Drawing.Color.DarkRed;
                btLeft.BackColor = System.Drawing.Color.DarkRed;
                btRight.BackColor = System.Drawing.Color.MediumBlue;
                SendText("backleft%");
                backleft = false;
                back = true;
                left = true;
                lbl.Text = "down & left";
            }
            else if (keyup == false && keydown == true && keyleft == false && keyright == true && backright == true)
            {
                //"down and right";
                btUp.BackColor = System.Drawing.Color.MediumBlue;
                btDown.BackColor = System.Drawing.Color.DarkRed;
                btLeft.BackColor = System.Drawing.Color.MediumBlue;
                btRight.BackColor = System.Drawing.Color.DarkRed;
                SendText("backright%");
                backright = false;
                back = true;
                right = true;
                lbl.Text = "down & right";
            }
            else if (keyup == false && keydown == false && keyleft == true && keyright == false && left == true && left == true)
            {
                //"left";
                btUp.BackColor = System.Drawing.Color.MediumBlue;
                btDown.BackColor = System.Drawing.Color.MediumBlue;
                btLeft.BackColor = System.Drawing.Color.DarkRed;
                btRight.BackColor = System.Drawing.Color.MediumBlue;
                SendText("left%");    
                left = false;
                backright = true;
                backleft = true;
                forwleft = true;
                forwright = true;
                lbl.Text = "left";
            }
            else if (keyup == false && keydown == false && keyleft == false && keyright == true && right == true)
            {
                //"right";
                btUp.BackColor = System.Drawing.Color.MediumBlue;
                btDown.BackColor = System.Drawing.Color.MediumBlue;
                btLeft.BackColor = System.Drawing.Color.MediumBlue;
                btRight.BackColor = System.Drawing.Color.DarkRed;
                SendText("right%");
                backright = true;
                backleft = true;
                forwleft = true;
                forwright = true;
                right = false;
                lbl.Text = "right";
            }
            else if (keyup == false && keydown == false && keyleft == false && keyright == false)
            {
                //"stop";
                btUp.BackColor = System.Drawing.Color.MediumBlue;
                btDown.BackColor = System.Drawing.Color.MediumBlue;
                btLeft.BackColor = System.Drawing.Color.MediumBlue;
                btRight.BackColor = System.Drawing.Color.MediumBlue;
                SendText("stop%");
                forw = true;
                forwleft = true;
                forwright = true;
                back = true;
                backleft = true;
                backright = true;
                left = true;
                right = true;
                lbl.Text = "stop";
            }
        }
        private void k_down(object sender, KeyEventArgs e)
        {
            if (open_port == true)
            {
                if (e.KeyCode == Keys.W)
                {
                    keyup = true;
                }
                else if (e.KeyCode == Keys.S)
                {
                    keydown = true;
                }
                else if (e.KeyCode == Keys.A)
                {
                    keyleft = true;
                }
                else if (e.KeyCode == Keys.D)
                {
                    keyright = true;
                }
                key_press_check();
            }   
        }
        private void k_up(object sender, KeyEventArgs e)
        {
            if (open_port == true)
            {
                if (e.KeyCode == Keys.W)
                {
                    keyup = false;
                }
                else if (e.KeyCode == Keys.S)
                {
                    keydown = false;
                }
                else if (e.KeyCode == Keys.A)
                {
                    keyleft = false;
                }
                else if (e.KeyCode == Keys.D)
                {
                    keyright = false;
                }

                key_press_check();
            }          

        }



     

       
    }
}
