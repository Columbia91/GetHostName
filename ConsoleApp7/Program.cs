using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine("Host name: " + hostName);
            IPHostEntry ipList = Dns.GetHostEntry(hostName);
                //Dns.GetHostByName(hostName);

            foreach (var ip in ipList.AddressList)
            {
                Console.WriteLine(ip);
            }

            Console.WriteLine("Введите имя хоста: ");

            // получение ай пи адресов по имени хоста
            hostName = Console.ReadLine();
            ipList = Dns.GetHostEntry(hostName);
            
            foreach (var ip in ipList.AddressList)
            {
                Console.WriteLine(ip);
            }

            // получение по имени хоста ip адресов
            var ipList2 = Dns.GetHostEntry(ipList.AddressList[0]);
            foreach (var ip in ipList2.Aliases)
            {
                Console.WriteLine(ip);
            }
            Console.ReadLine();
        }
    }
}
