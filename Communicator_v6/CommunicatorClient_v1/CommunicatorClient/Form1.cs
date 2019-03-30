using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CommunicatorClient
{
    public partial class mainWindow : Form
    {

        private TcpClient client = null;
        BinaryReader reading = null;
        BinaryWriter writing = null;
        private bool activeCall = false;
        private bool activeMusic = false;
        private string nick = "";

        private string messagePrepend = "";
        private string messageAppend = "";

        public mainWindow()
        {
            InitializeComponent();
        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            bwConnection.RunWorkerAsync();
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            string host = tbAddress.Text;
            int port = Convert.ToUInt16(nudPort.Value);
            try
            {
                client = new TcpClient(host, port);
                NetworkStream ns = client.GetStream();
                reading = new BinaryReader(ns);
                writing = new BinaryWriter(ns);
                writing.Write("password");
                activeCall = true;
                lbCommunique.Invoke(new MethodInvoker(delegate { lbCommunique.Items.Add("Nawiązano połączenie z " + host + " na porcie: " + port); }));
                bConnect.Invoke(new MethodInvoker(delegate { bConnect.Enabled = false; }));
                bwConversation.RunWorkerAsync();
            }
            catch(Exception ex)
            {
                activeCall = false;
                lbCommunique.Invoke(new MethodInvoker(delegate { lbCommunique.Items.Add("Błąd: Nie udało się nawiązać połączenia"); }));
            }
        }

        private void bwConversation_DoWork(object sender, DoWorkEventArgs e)
        {
            string messageRecived;
            while(activeCall && (messageRecived = reading.ReadString())!="END")
            {
                wbMessages.Invoke(new MethodInvoker(delegate { wbMessages.DocumentText += messageRecived; }));
            }
            writing.Write("END");
            client.Close();
            activeCall = false;
            lbCommunique.Invoke(new MethodInvoker(delegate { lbCommunique.Items.Add("Połączenie z serwerem zostało przerwane"); }));
            bConnect.Invoke(new MethodInvoker(delegate { bConnect.Enabled = true; }));
        }

        private void bSendMessage_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(activeCall)
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

        private void tbMessage_Enter(object sender, EventArgs e)
        {
            sendMessage();
        }

        private void sendMessage()
        {
            if (activeCall)
            {
                string messageAdd = "<div><span style=\"color:green;\">&lt;" + nick+" "+ DateTime.Now.ToString("h:mm:ss tt") + "&gt;</span> " + messagePrepend + tbMessage.Text + messageAppend + "</div>";
                string messageSend = "<div><span>&lt;" + nick +" "+ DateTime.Now.ToString("h:mm:ss tt") + "&gt;</b> " + messagePrepend + tbMessage.Text + messageAppend + "</div>";
                wbMessages.DocumentText += messageAdd;
                writing.Write(messageSend);
            }
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
            if(bFontItalic.BackColor != Color.White)
            {
                messagePrepend += "<i>";
                messageAppend += "</i>";
            }
            if(bFontWeight.BackColor != Color.White)
            {
                messageAppend += "</b>";
            }
            if (bFontFamily.BackColor != Color.White)
            {
                messageAppend += "</span>";
            }
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                sendMessage();
                tbMessage.Text = String.Empty;
                e.SuppressKeyPress = true;
                if (activeMusic)
                {
                    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                    wplayer.URL = "sound.mp3";
                    wplayer.controls.play();
                }
            }
        }

        private void exportConversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Prompt.Show("Podaj ścieżkę:", "");
            string fileName = Prompt.Show("Podaj nazwę pliku:", "conversations.html");
            TextFileTools.writeFile(path, fileName, wbMessages.DocumentText.ToString());
        }

        private void importConversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = Prompt.Show("Podaj ścieżkę:", "");
            string fileName = Prompt.Show("Podaj nazwę pliku:", "conversations.html");
            string data = TextFileTools.readFile(path, fileName);
            wbMessages.DocumentText = data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.White) // Italic is inactive
            {
                button1.BackColor = Color.PaleTurquoise;
                mainWindow.ActiveForm.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                button1.BackColor = Color.White;
                mainWindow.ActiveForm.BackColor = System.Drawing.Color.White;
            }

        }
    }
}
