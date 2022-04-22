using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace ConsoleApp1
{
    class Client_CS
    {
        const int portNo = 25000;
        const string ip = "127.0.0.1"; 

        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(ip, portNo); //Connect to the server

            //Use a network streem to send/receive data
            NetworkStream ns = tcpClient.GetStream();
            byte[] data = Encoding.ASCII.GetBytes("Hello");

            ns.Write(data, 0, data.Length);     //Send the data
        }
    }
}
