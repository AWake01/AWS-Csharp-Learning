using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinClient
{
    public partial class ClientChatForm : Form
    {
        const int portNo = 25000;
        const string strIP = "192.168.1.199";
        TcpClient client;
        byte[] data;

        public ClientChatForm()
        {
            InitializeComponent();
        }

        private void txtNick_TextChanged(object sender, EventArgs e)
        {

        }

        //Method to connect to server and switch button text to sign out
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (btnSignIn.Text == "Sign In")
            {
                try
                {
                    //Connect to server
                    client = new TcpClient();
                    client.Connect(strIP, portNo);
                    data = new byte[client.ReceiveBufferSize];

                    //Read from server
                    SendMessage(txtNick.Text);
                    client.GetStream().BeginRead(data, 0, Convert.ToInt32(client.ReceiveBufferSize), RecieveMessage, null);
                    btnSignIn.Text = "Sign Out";
                    btnSend.Enabled = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                //Disconnect from server
                Disconnect();
                btnSignIn.Text = "Sign In";
                btnSend.Enabled = false;
            }
        }

        //Method for send button
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage(txtMessage.Text);
        }

        //Method to send message to server
        public void SendMessage(string message)
        {
            try
            {
                //Send a message to the server
                NetworkStream ns = client.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(message);

                //Send the text
                ns.Write(data, 0, data.Length);
                ns.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void RecieveMessage(IAsyncResult ar)
        {
            try
            {
                int bytesRead;

                //Read the data from the server
                bytesRead = client.GetStream().EndRead(ar);
                if (bytesRead < 1)  //Return if message is empty
                {
                    return;
                }
                else
                {
                    //invoke the deleagate to display the recieved data
                    object[] para = {Encoding.ASCII.GetString(data, 0, bytesRead)};
                    this.Invoke(new delUpdateHistory(UpdateHistory), para);
                }

                //Continue reading
                client.GetStream().BeginRead(data, 0, Convert.ToInt32(client.ReceiveBufferSize), RecieveMessage, null);
            }
            catch (Exception ex)
            {

                //Ignore the error; fired when a user signs off
            }
        }

        //Delegate and subroutine to update the history textbox--- 
        /*The delegate is a reference type data type that defines the method signature.
        You can define variables of delegate, just like other data type, that can refer to any method with the same signature as the delegate.*/
        public delegate void delUpdateHistory(string str);
        public void UpdateHistory(string str)
        {
            txtMessageHistory.AppendText(str);
        }

        //Method to disconnect from server
        public void Disconnect()
        {
            try
            {
                //Disconnect from server
                client.GetStream().Close();
                client.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        //On close, disconnect
        private void ClientChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }      
    }
}
