using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace L9_Sockets
{
    class SocketClient
    {
        static void Main(string[] args)
        {
            Socket client = null;
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipaddr = null;

            try
            {
                Console.WriteLine("*** Welcome To Socket Client Starter");
                Console.WriteLine("Please Type A Valid Server Address And Press Enter: ");
                string strIPAddress = Console.ReadLine();
                Console.WriteLine("Please Supply A Valid Port Number 0 - 65535 And Press Enter: ");
                string strPortInput = Console.ReadLine();
                int nPortInput = 0;

                Console.WriteLine(string.Format("IPAddress: {0} - Port: {1}", ipaddr, nPortInput));

                if (string.IsNullOrEmpty(strIPAddress)) strIPAddress = "127.0.0.1";    //Default to loopback address
                if (string.IsNullOrEmpty(strPortInput)) strPortInput = "25000";        //Default to port 25000

                if (!IPAddress.TryParse(strIPAddress, out ipaddr))  //Vallidate IP address
                {
                    Console.WriteLine("Invalid server IP supplied.");
                    return;
                }

                if(!int.TryParse(strPortInput.Trim(), out nPortInput))  //Validate port number is int
                {
                    Console.WriteLine("Invalid port number supplied, return.");
                    return;
                }

                if(nPortInput <= 0 || nPortInput > 65535)   //Validate port number is in valid range
                {
                    Console.WriteLine("port number must be between 0 and 65535");
                    return;
                }

                Console.WriteLine(string.Format("IPAddress: {0} - Port: {1}", ipaddr, nPortInput));

                client.Connect(ipaddr, nPortInput);     //Connect to client

                Console.WriteLine("Connected to the server, type text and press enter to send it to the server, type <EXIT> to close.");
                string inputCommand = string.Empty;

                while (true)    //Get user input continuously
                {
                    inputCommand = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(inputCommand))
                    {
                        continue;
                    }

                    if (inputCommand.Equals("<EXIT>"))  //Check for exit command
                    {
                        break;
                    }

                    //Send message to client
                    byte[] buffSend = Encoding.ASCII.GetBytes(inputCommand);
                    client.Send(buffSend);

                    //Receive response from server
                    byte[] buffRecieved = new byte[128];
                    int nRecy = client.Receive(buffRecieved);

                    Console.WriteLine("Data received: {0}", Encoding.ASCII.GetString(buffRecieved, 0, nRecy));
                }
            }
            catch (Exception excp)  //Catch exceptions
            {
                Console.WriteLine(excp.ToString());
            }
            finally     //Cleanup
            {
                if (client != null)
                {
                    if (client.Connected)
                    {
                        client.Shutdown(SocketShutdown.Both);   //Disable socket r/w
                    }

                    client.Close();     //Close socket connection and release resources
                    client.Dispose();   //Releases all socket instance resources
                }
            }

            Console.WriteLine("Press a key to exit...");
            Console.ReadLine();
        }
    }
}
