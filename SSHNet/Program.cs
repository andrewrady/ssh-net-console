// See https://aka.ms/new-console-template for more information

using Renci.SshNet;

Console.WriteLine("SFTP Server Connection Test");
const string host = "";
const int port = 22;
const string password = "";
const string userName = "";
using var client = new SftpClient(host, port, userName, password);
try
{
   client.Connect();
   Console.WriteLine(client.IsConnected);
   Console.WriteLine(client.WorkingDirectory);
}
catch (Exception ex)
{
   Console.WriteLine(ex);
}