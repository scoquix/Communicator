//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Net.Sockets;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace CommunicatorServer
//{
//    class bw
//    {
//        private BackgroundWorker backgroundWorker;
//        private TcpClient client = null;
//        BinaryReader reading = null;
//        BinaryWriter writing = null;

//        bw()
//        {
//            backgroundWorker = new BackgroundWorker();
//        }

//        public void startWorker()
//        {
//            backgroundWorker.RunWorkerAsync();
//        }

//        private void BackgroundWorker_DoWork()
//        {
//            bool connectionListen = true;
//            while (connectionListen)
//            {
//                try
//                {

//                    client = server.AcceptTcpClient();

//                    IPEndPoint IP = (IPEndPoint)client.Client.RemoteEndPoint;
//                    //lbCommunique.Invoke(new MethodInvoker(delegate { lbCommunique.Items.Add("[" + IP.ToString() + "] :Nawiązano połączenie"); }));
//                    NetworkStream ns = client.GetStream();
//                    reading = new BinaryReader(ns);
//                    writing = new BinaryWriter(ns);
//                    if (reading.ReadString() == "password")
//                    {
//                        activeCall = true;
//                        bwConversation.RunWorkerAsync();
//                    }
//                    else
//                    {
//                        client.Close();
//                        client = null;
//                        activeCall = false;
//                    }
//                    connectionListen = false;

//                }
//                catch { }
//            }
//        }

//    }
//}
