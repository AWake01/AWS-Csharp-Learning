using System;
using System.Collections;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class ChatClient
    {
        public ChatClient(TcpClient client)    //Constructor for client
        {
            _client = client;

            _clientIP = client.Client.RemoteEndPoint.ToString();    //Get client ip address
            ALLClients.Add(_clientIP, this);    //Add client to hashtable using ip as key

            //Start reading data form client in a seperate thread
            data = new byte[_client.ReceiveBufferSize];
            client.GetStream().BeginRead(data, 0, Convert.ToInt32(_client.ReceiveBufferSize), RecieveMessage, null);
        }

        public static Hashtable ALLClients = new Hashtable();   //Contains a list of all clients

        //Client information
        private TcpClient _client;
        private string _clientIP;
        private string _ClientNick;

        private byte[] data;    //Used for s/r data

        private bool ReciveNick = true;     //Is nickname being sent?

        //Method to recieve message from server
        public void RecieveMessage(IAsyncResult ar)


        {
            //Read from client
            int bytesRead;
            try
            {
                lock (_client.GetStream())  //Lock prevents other threads from accessing networkStream object
                {
                    bytesRead = _client.GetStream().EndRead(ar);
                }

                //Client has disconnected
                if (bytesRead < 1)
                {
                    ALLClients.Remove(_clientIP);
                    Broardcast(_ClientNick + " has left the chat.");
                    return;
                }
                else
                {
                    string messageRecieved = Encoding.ASCII.GetString(data, 0, bytesRead);  //Get sent message

                    //Client is sending nickname
                    if (ReciveNick)
                    {
                        _ClientNick = messageRecieved;

                        Broardcast(_ClientNick + " has joined the chat.");
                        ReciveNick = false;
                    }
                    else
                    {
                        Broardcast(_ClientNick + "> " + messageRecieved);
                    }
                    //Continue reading from client
                    lock (_client.GetStream())
                    {
                        _client.GetStream().BeginRead(data, 0, Convert.ToInt32(_client.ReceiveBufferSize), RecieveMessage, null);
                    }
                }
            }
            catch (Exception ex)
            {
                ALLClients.Remove(_clientIP);
                Broardcast(_ClientNick + " has left the chat.");
            }
        }

        //Method to send messages to server
        public void SendMessage(string message)
        {
            try
            {
                //Send the text
                NetworkStream ns;
                lock (_client.GetStream())
                {
                    ns = _client.GetStream();
                }

                byte[] bytesToSend = Encoding.ASCII.GetBytes(message);
                ns.Write(bytesToSend, 0, bytesToSend.Length);
                ns.Flush();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //Method to broardcast messsage to all users
        public void Broardcast(string message)
        {
            Console.WriteLine(message);//log it localy

            foreach (DictionaryEntry c in ALLClients)   //Broardcast message to all users
            {
                ((ChatClient)(c.Value)).SendMessage(message + Environment.NewLine);
            }
        }
    }
}