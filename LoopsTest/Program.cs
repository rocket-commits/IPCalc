using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LoopsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int ipOctet = 25;
            int maskOctet = 192;
            //id
            int output = ipOctet & maskOctet;
            string realOctetBin = Convert.ToString(output, toBase: 2);
            string finalResult = realOctetBin.PadLeft(8, '0');
            //broadcast
            int output2 = ipOctet | ~maskOctet;
            var broadcast = BitConverter.GetBytes(output2);
            string bc1 = Convert.ToString(Convert.ToInt32(broadcast[0]), toBase: 2);
            string finalResult2 = bc1.PadLeft(8, '0');
            Console.WriteLine($"ID IP Int {output}");
            Console.WriteLine($"IP IP Bin {finalResult}");
            Console.WriteLine($"Broadcast Int {broadcast[0]}");
            Console.WriteLine($"Broadcast Bin {finalResult2}");

            //string one = "1";
            //string concat = null;
            //string octet;
            //string full;
            //string full2;
            //string full3;
            //string full4;
            //string fulldec;
            //int decNum;
            //for (int i = 1; i < 9; i++)
            //{
            //    concat = concat + one;
            //    octet = concat.PadRight(8, '0');
            //    full = octet + ".00000000.00000000.00000000";
            //    decNum = Convert.ToInt32(octet, 2);
            //    fulldec = $"{decNum}.0.0.0";
            //    Console.Write($"/{i} ");
            //    Console.Write($"{fulldec} ");
            //    Console.WriteLine(full);
            //}
            //one = "1";
            //concat = null;
            //octet = null;
            //for (int i = 9; i < 17; i++)
            //{
            //    concat = concat + one;
            //    octet = concat.PadRight(8, '0');
            //    full2 = "11111111." + octet + ".00000000.00000000";
            //    decNum = Convert.ToInt32(octet, 2);
            //    fulldec = $"255.{decNum}.0.0";
            //    Console.Write($"/{i} ");
            //    Console.Write($"{fulldec} ");
            //    Console.WriteLine(full2);
            //}
            //one = "1";
            //concat = null;
            //octet = null;
            //for (int i = 17; i < 25; i++)
            //{
            //    concat = concat + one;
            //    octet = concat.PadRight(8, '0');
            //    full3 = "11111111.11111111." + octet + ".00000000";
            //    decNum = Convert.ToInt32(octet, 2);
            //    fulldec = $"225.255.{decNum}.0";
            //    Console.Write($"/{i} ");
            //    Console.Write($"{fulldec} ");
            //    Console.WriteLine(full3);
            //}
            //one = "1";
            //concat = null;
            //octet = null;
            //for (int i = 25; i < 33; i++)
            //{
            //    concat = concat + one;
            //    octet = concat.PadRight(8, '0');
            //    full4 = "11111111.11111111.11111111." + octet;
            //    decNum = Convert.ToInt32(octet, 2);
            //    fulldec = $"225.255.255.{decNum}";
            //    Console.Write($"/{i} ");
            //    Console.Write($"{fulldec} ");
            //    Console.WriteLine(full4);
            //}
            Console.ReadLine();
        }
    }
}
