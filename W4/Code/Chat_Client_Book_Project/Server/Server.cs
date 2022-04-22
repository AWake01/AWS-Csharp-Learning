using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace Server
{
    class Server
    {
        const int portNo = 25000;
        const string strIP = "192.168.1.199";

        static void Main(string[] args)
        {
            //Define TcpListener
            IPAddress localAdd = IPAddress.Parse(strIP);

            TcpListener listener = new TcpListener(localAdd, portNo);
            listener.Start();
            while(true)
            {
                ChatClient user = new ChatClient(listener.AcceptTcpClient());
            }
        }
    }
}
