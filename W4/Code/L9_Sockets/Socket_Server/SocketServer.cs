using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Socket_Server
{
    class SocketServer
    {
        static void Main(string[] args)
        {          
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);      //Create an object of socket class
            IPAddress ipaddr = IPAddress.Any;       //Creata an object for listening on any ip address
            IPEndPoint ipep = new IPEndPoint(ipaddr, 25000);     //Define ip endp point

            try
            {
                listenerSocket.Bind(ipep);      //Bind socket to ip endpoint
                listenerSocket.Listen(5);       //Define how many cleints are able to wait for a connection
                Socket client = listenerSocket.Accept();        //Accept is a synchrouous method (Blocking method) will not move forward until operation completed -- Very Bad Method 

                Console.WriteLine("Client connected: " + client.ToString() + " - Ip End Point: " + client.RemoteEndPoint.ToString());

                byte[] buff = new byte[128];    //Define a buffer as byte array of 128 byte length
                int numberOfRecivedBytes = 0;   //Define number of bytes recived

                while (true) 
                {
                    numberOfRecivedBytes = client.Receive(buff);
                    Console.WriteLine("Number of recieve bytes: " + numberOfRecivedBytes);
                    string recievedText = Encoding.ASCII.GetString(buff, 0, numberOfRecivedBytes);      //Convert buff to ASCHII
                    Console.WriteLine("Data sent by client is : " + recievedText);

                    client.Send(buff);      //Send return message

                    if(recievedText == "x")
                    {
                        break;
                    }

                    Array.Clear(buff, 0, buff.Length);      //Clear buffer
                    numberOfRecivedBytes = 0;
                }
            }
            catch (Exception exc)       //Catch exceptions
            {
                Console.WriteLine(exc.ToString());
            }
            finally     //Cleanup
            {
                Console.ReadLine();
            }
        }
    }
}
