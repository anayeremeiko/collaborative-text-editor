using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Text_Editor : Form
    {
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        static NetworkStream stream;

        public Text_Editor()
        {
            InitializeComponent();
            Start();
        }

        public void Start()
        {
            client = new TcpClient();
            try
            {
                client.Connect(host, port); //подключение клиента
                stream = client.GetStream(); // получаем поток
                
                // запускаем новый поток для получения данных
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(); //старт потока
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ReceiveMessage()
        {
            try
            {
                string[] temp;
                while (true)
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    int bytes = 0;

                    bytes = stream.Read(data, 0, data.Length);
                    string msg = Encoding.Unicode.GetString(data, 0, bytes);
                    temp = msg.Split(' ');
                    if (temp[0] == "key")
                    {
                        if (temp[1] == "backspace")
                        {
                            if (richTextBox1.Text != "")
                            {
                                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
                            }
                        }
                        else if (temp[1] == "enter") richTextBox1.AppendText(String.Format("{0}", Environment.NewLine));
                        else if (temp[1] == "space") richTextBox1.AppendText(" ");
                        else richTextBox1.AppendText(temp[1]);
                    }
                    else if (temp[0] == "bold")
                    {
                        boldButton_Click(richTextBox1, null);
                    }
                    else if (temp[0] == "italic")
                    {
                        italicButton_Click(richTextBox1, null);
                    }
                    else if (temp[0] == "underline")
                    {
                        underlineButton_Click(richTextBox1, null);
                    }
                    else if (temp[0] == "center")
                    {
                        centerAButton_Click(centerAButton, null);
                    }
                    else if (temp[0] == "left")
                    {
                        leftAButton_Click(leftAButton, null);
                    }
                    else if (temp[0] == "right")
                    {
                        rightAButton_Click(rightAButton, null);
                    }
                    else if (temp[0] == "smaller")
                    {
                        smallerButton_Click(smallerButton, null);
                    }
                    else if (temp[0] == "larger")
                    {
                        largerButton_Click(largerButton, null);
                    }
                }
            }
            catch
            {
            }
        }

        public void sendMessage(string message)
        {
            try
            {
                byte[] data = Encoding.Unicode.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
            catch
            {
                if (stream == null)
                {
                    MessageBox.Show("Server not found");
                    Environment.Exit(0);
                }
            }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string msg = "key ";
            if (e.KeyChar == 8) msg += "backspace";
            else if (e.KeyChar == 13) msg += "enter";
            else if (e.KeyChar == 32) msg += "space";
            else msg += e.KeyChar.ToString();
            sendMessage(msg);
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = richTextBox1.SelectionFont;
            if(oldFont.Bold)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);
            }
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
            if (e != null) { sendMessage("bold"); }
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = richTextBox1.SelectionFont;
            if (oldFont.Italic)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);
            }
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
            if (e != null) { sendMessage("italic"); }
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = richTextBox1.SelectionFont;
            if (oldFont.Underline)
            {
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            }
            else
            {
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);
            }
            richTextBox1.SelectionFont = newFont;
            richTextBox1.Focus();
            if (e != null) { sendMessage("underline"); }
        }

        private void centerAButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment == HorizontalAlignment.Center)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            }
            if (e != null)
            { sendMessage("center"); }
            richTextBox1.Focus();
            
        }

        private void leftAButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            if (e != null) 
            { sendMessage("left"); }
            richTextBox1.Focus();
            
        }

        private void rightAButton_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionAlignment == HorizontalAlignment.Right)
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            }
            else
            {
                richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            }
            if (e != null) 
            { sendMessage("right"); }
            richTextBox1.Focus();
            
        }

        private void smallerButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size - 1);
            if ( e != null)
            {
                sendMessage("smaller");
            }
            richTextBox1.Focus();
        }

        private void largerButton_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size + 1);
            if (e != null)
            {
                sendMessage("larger");
            }
            richTextBox1.Focus();
        }
    }
}
