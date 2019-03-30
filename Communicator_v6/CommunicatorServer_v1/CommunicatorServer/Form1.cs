using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace CommunicatorServer
{
    
    public partial class mainWindow : Form
    {

        public TcpListener server;
        private TcpClient client = null;

        BinaryReader reading = null;
        BinaryWriter writing = null;

        private bool activeCall = false;
        //private bool activeCall = false;
        private bool activeMusic = false;
        bool connectionListen = true;

        private string nick = "";

        private string messagePrepend = "";
        private string messageAppend = "";

        public object Interaction { get; private set; }

        public mainWindow()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bwConnection.RunWorkerAsync();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            server.Stop();
            if(client != null)
            {
                activeCall = false;
                writing.Write("END");
            }
            else
            {
                connectionListen = false;
            }
            lbCommunique.Items.Add("Zakończono pracę serwera");
            bStart.Enabled = true;
            bStop.Enabled = false;
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            IPAddress addressIP = null;
            try
            {
                addressIP = IPAddress.Parse(tbAddress.Text);
                
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP!", "Błąd");
                tbAddress.Invoke(new MethodInvoker(delegate { tbAddress.Text = String.Empty; }));
                return;
            }

            int port = Convert.ToInt16(nudPort.Value);
            try
            {
                server = new TcpListener(addressIP, port);
                server.Start();

                lbCommunique.Invoke(new MethodInvoker(delegate { lbCommunique.Items.Add("Serwer startuje :" + port); }));

                bStart.Invoke(new MethodInvoker(delegate { bStart.Enabled = false; }));
                bStop.Invoke(new MethodInvoker(delegate { bStop.Enabled = true; }));
            }
            catch (Exception ex)
            {
                lbCommunique.Invoke(new MethodInvoker(delegate { lbCommunique.Items.Add("Błąd inicjacji serwera" + port); }));
                MessageBox.Show(ex.ToString(), "Błąd");
                return;
            }

            connectionListen = true;
            while(connectionListen)
            {
                try
                {
                    client = server.AcceptTcpClient();

                    IPEndPoint IP = (IPEndPoint)client.Client.RemoteEndPoint;
                    lbCommunique.Invoke(new MethodInvoker(delegate { lbCommunique.Items.Add("[" + IP.ToString() + "] :Nawiązano połączenie"); }));
                    NetworkStream ns = client.GetStream();
                    reading = new BinaryReader(ns);
                    writing = new BinaryWriter(ns);
                    if(reading.ReadString() == "password")
                    {
                        activeCall = true;
                        bwConversation.RunWorkerAsync();
                    }
                    else
                    {
                        client.Close();
                        client = null;
                        activeCall = false;
                    }
                    connectionListen = false;
                    
                }
                catch { }
            }
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            /*if (activeCall)
             {
                 string messageAdd = "<div><span style=\"color:green;\">&lt;" + nick + "&gt;</span> " + tbMessage.Text + "</div>";
                 string messageSend = "<div><span>&lt;" + nick + "&gt;</b> " + tbMessage.Text + "</div>";
                 wbMessages.DocumentText += messageAdd;
                 writing.Write(messageSend);
             }*/
            sendMessage();
            tbMessage.Text = String.Empty;
            if (activeMusic)
            {
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = "sound.mp3";
                wplayer.controls.play();
            }
        }

        
        private void tbMessage_Enter(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void sendMessage()
        {
            if (activeCall)
            {
                string messageAdd = "<div><span style=\"color:green;\">&lt;" + nick + " " + DateTime.Now.ToString("h:mm:ss tt")+ "&gt;</span> " + messagePrepend + tbMessage.Text + messageAppend + "</div>";
                string messageSend = "<div><span>&lt;" + nick + " " + DateTime.Now.ToString("h:mm:ss tt") + "&gt;</b> " + messagePrepend + tbMessage.Text + messageAppend + "</div>";
                wbMessages.DocumentText += messageAdd;
                writing.Write(messageSend);
            }
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
           
        }



        private void bwConversation_DoWork(object sender, DoWorkEventArgs e)
        {
            string messageRecived;
            while (activeCall && (messageRecived = reading.ReadString()) != "END")
            {
                wbMessages.Invoke(new MethodInvoker(delegate { wbMessages.DocumentText += messageRecived; }));
                if (activeMusic)
                {
                    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                    wplayer.URL = "sound.mp3";
                    wplayer.controls.play();
                }
            }
            client.Close();
            activeCall = false;
            lbCommunique.Invoke(new MethodInvoker(delegate { lbCommunique.Items.Add("Client się rozłączył"); }));
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (activeCall)
                writing.Write("END");
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            do
            {
                nick = Prompt.Show("Podaj nick:", "defaultNick");
            } while (nick == "");
        }

        private void bFontWeight_Click(object sender, EventArgs e)
        {
            if (bFontWeight.BackColor == Color.White) // Bold is inactive
            {
                bFontWeight.BackColor = Color.PaleTurquoise;
            }
            else
            {
                bFontWeight.BackColor = Color.White;
            }
            textStyle();
        }

        private void bFontItalic_Click(object sender, EventArgs e)
        {
            if (bFontItalic.BackColor == Color.White) // Italic is inactive
            {
                bFontItalic.BackColor = Color.PaleTurquoise;
            }
            else
            {
                bFontItalic.BackColor = Color.White;
            }
            textStyle();
        }

        private void textStyle()
        {
            messageAppend = "";
            messagePrepend = "";
            if (bFontFamily.BackColor != Color.White)
            {
                messagePrepend += "<span style=\"font-family: Impact;\">";
            }
            if (bFontWeight.BackColor != Color.White)
            {
                messagePrepend += "<b>";
            }
            if (bFontItalic.BackColor != Color.White)
            {
                messagePrepend += "<i>";
                messageAppend += "</i>";
            }
            if (bFontWeight.BackColor != Color.White)
            {
                messageAppend += "</b>";
            }
            if (bFontFamily.BackColor != Color.White)
            {
                messageAppend += "</span>";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = saveFileDialog1.FileName;
                TextFileTools.writeFile(file, wbMessages.DocumentText.ToString());
                
            }
           // string path = Prompt.Show("Podaj ścieżkę:", "");
           // string fileName = Prompt.Show("Podaj nazwę pliku:", "conversations.html");
            
        }

        private void importConversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    wbMessages.DocumentText = text;
                }
                catch (IOException)
                {
                }
            }
            //string path = Prompt.Show("Podaj ścieżkę:", "");
            //string fileName = Prompt.Show("Podaj nazwę pliku:", "conversations.html");
            //string data = TextFileTools.readFile(text);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.White) // Button is inactive
            {
                button3.BackColor = Color.PaleTurquoise;
                activeMusic = true;
            }
            else
            {
                button3.BackColor = Color.White;
                activeMusic = false;
            }
        }

        private void tbMessage_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMessage();
                tbMessage.Text = String.Empty;
                e.SuppressKeyPress = true;
                       
            }
        }

        private void bFontFamily_Click(object sender, EventArgs e)
        {
            if (bFontFamily.BackColor == Color.White) // Italic is inactive
            {
                bFontFamily.BackColor = Color.PaleTurquoise;
            }
            else
            {
                bFontFamily.BackColor = Color.White;
            }
            textStyle();
        }

        private void bCoralTheme_Click(object sender, EventArgs e)
        {
            if (bCoralTheme.BackColor == Color.White) // Italic is inactive
            {
                bCoralTheme.BackColor = Color.PaleTurquoise;
                mainWindow.ActiveForm.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                bCoralTheme.BackColor = Color.White;
                mainWindow.ActiveForm.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
