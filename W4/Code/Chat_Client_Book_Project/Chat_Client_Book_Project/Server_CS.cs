using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Chat_Client_Book_Project
{
    class Server_CS
    {
        const int portNo = 25000;
        const string strIP = "127.0.0.1"; 

        static void Main(string[] args)
        {
            IPAddress localAdd = IPAddress.Parse(strIP);

            //listen at local address
            TcpListener listener = new TcpListener(localAdd, portNo);
            listener.Start();

            TcpClient tcpClient = listener.AcceptTcpClient();   //Accepts a pending connection request

            //Use a network streem to send and receive data
            NetworkStream ns = tcpClient.GetStream();
            byte[] data = new byte[tcpClient.ReceiveBufferSize];

            //Read incomming stream. Read() is a blocking call
            int numBytesRead = ns.Read(data, 0, Convert.ToInt32(tcpClient.ReceiveBufferSize));

            Console.WriteLine("Received :" + Encoding.ASCII.GetString(data, 0, numBytesRead));    //Display data received

            Console.ReadLine(); 
        }
    }
}
