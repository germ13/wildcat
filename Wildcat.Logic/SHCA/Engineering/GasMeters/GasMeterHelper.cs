using System;
using System.Collections.Generic;
//using System.IO;
using System.Net;
using System.Net.Sockets;
//using System.Text;
//using System.Threading;
using Wildcat.Entities.PCC.Wildcat;

namespace Wildcat.Logic.SHCA.Engineering.GasMeters
{
    public class GasMeterHelper
    {
        const int PORT_NUMBER = 10001;
        //string CHANGE_SERIAL_TO_IP_BAUDRATE_TO_1200 = "0211200";
        //string CHANGE_SERIAL_TO_IP_BAUDRATE_TO_9600 = "0219600";
        //byte[] SERIAL_TO_IP_OK_RETURN = new byte[] { 79, 75 }; // 79 is O, and 75 is K. OK
        //byte[] SERIAL_TO_IP_ERROR_RETURN = new byte[] { 69, 114, 114, 111, 114 }; // 69 is for E, 114 is for r, 111 is for o. Error

        //public static int ReadSerialToIPBaudRate(string IPAddress)
        //{
        //    int BR = 0;




        //    return BR;
        //}

        //public static int ReadMeterBaudRate(SocketWithName socketWithName)
        //{
        //    int BR = 0;
        //    // So far have not been able to find a command that can read modem baud rate set value.
        //    return BR;
        //}

        //public static bool ChangeSerialToIPDevice(string IPAddress, string changeCommand)
        //{
        //    bool changed = false;
        //    // Create a TCPClient object to connect to the IP_To_Serial device.
        //    TcpClient _client = new TcpClient();
        //    _client.Connect(IPAddress, 10000);
        //    Stream stm = _client.GetStream();
        //    // The changeCommand string/command will determine which baud rate change should be set.
        //    // This will be either 1200 or 9600.
        //    byte[] commandByte = Encoding.ASCII.GetBytes(changeCommand);
        //    stm.Write(commandByte, 0, commandByte.Length);
        //    // The returned three byte array will say OK if change was successful.
        //    byte[] commandReturned = new byte[3];
        //    int R = stm.Read(commandReturned, 0, 3);
        //    // If the first byte is 79/'O' and the second is 75/'K' and the third is ASCII carriage return.
        //    // Then the command was successful. 
        //    if (commandReturned[0] == 79 && commandReturned[1] == 75 && commandReturned[2] == 13)
        //    { changed = true; }
        //    else { changed = false; }
        //    return changed;
        //}

        //public static bool ChangeMeterBaudRateValue(SocketWithName socketWithName, byte[] baudRateChangeCommand)
        //{
        //    bool baudRateChanged = false;
        //    Socket requester = socketWithName.socket;
        //    requester.ReceiveTimeout = 10000;
        //    // Connect to the socket.
        //    if (!requester.Connected)
        //    {
        //        requester.Connect(socketWithName.IpEndPoint);
        //    }

        //    // This will hold the returned data from the meter. We will use this to verify if the baud rate change
        //    // succeeded. 
        //    byte[] baudRateChangeReturn = new byte[11];

        //    if (requester.Connected)
        //    {
        //        int sent = 0;
        //        int received = 0;
        //        // Since it may take more than a one try to change the baud rate, let's keep track of it.
        //        bool NOT_Changed = true;
        //        while (NOT_Changed)
        //        {
        //            try
        //            {
        //                sent = requester.Send(baudRateChangeCommand);
        //                received = requester.Receive(baudRateChangeReturn);
        //                // If the returned status is not 'S' (83), repeat it.
        //                if (baudRateChangeReturn[4] != 83)
        //                {
        //                    Thread.Sleep(200);
        //                    continue;
        //                }
        //                if (baudRateChangeReturn[8] == 0)
        //                {
        //                    // If the returned status value is 83, change has taken place, return.
        //                    NOT_Changed = false;
        //                    baudRateChanged = true;
        //                }
        //                else
        //                {
        //                    // If the returned status value is 83, change has taken place, return.
        //                    NOT_Changed = true;
        //                    baudRateChanged = false;
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                //WriteToFile("Could not change meter baud rate.", false);
        //            }
        //        }
        //    }

        //    return baudRateChanged;
        //}

        public static List<SocketWithName> GetSocketCollection(List<GasMeter> meters)
        {
            List<SocketWithName> coll_SocketsWithIP = new List<SocketWithName>();
            {
                foreach (GasMeter gm in meters)
                {
                    SocketWithName sip = CreateASocket(gm);
                    coll_SocketsWithIP.Add(sip);
                }
            }

            return coll_SocketsWithIP;
        }

        //public static List<SS_SerialPort> GetSerialPortCollection(string names, List<GasMeter> meters)
        //{
        //    List<SS_SerialPort> coll_SerilPorts = new List<SS_SerialPort>();
        //    if (names == "All" || string.IsNullOrEmpty(names))
        //    {
        //        foreach (GasMeter gm in meters)
        //        {
        //            SS_SerialPort serialPort = CreateASerialPort(gm);
        //        }
        //    }

        //    return coll_SerilPorts;
        //}

        private static SocketWithName CreateASocket(GasMeter gm)
        {
            SocketWithName sip = null;

            if (gm != null)
            {
                IPEndPoint MeterIP = new IPEndPoint(System.Net.IPAddress.Parse(gm.MeterIp), PORT_NUMBER);
                Socket requester = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                sip = new SocketWithName(MeterIP, requester, gm.MeterName, new MeterReadItem(gm.MeterName, "message"));
                sip.IsOpen = true;
                sip.meterName = gm.MeterName;
            }
            return sip;
        }

        //private static SS_SerialPort CreateASerialPort(GasMeter gm)
        //{
        //    SS_SerialPort ssSerialPort = null;

        //    if (gm != null)
        //    {
        //        //ssSerialPort.
        //    }


        //    return ssSerialPort;
        //}

        private static ushort compute_crc(byte[] bufptr, int len)
        {
            ushort chr_bit = 0;
            ushort crc_bit = 0;
            ushort checkSumResult = 0;

            byte chr = (byte)'0';
            ushort bit_cnt = 0;
            int _counter = 0;

            if (len > 0)
            {
                do
                {
                    chr = bufptr[_counter++];
                    for (bit_cnt = 0; bit_cnt < 8; bit_cnt++)
                    {
                        chr_bit = (ushort)(chr & 0x01);
                        crc_bit = (ushort)(checkSumResult & 0x01);
                        checkSumResult >>= 1;
                        chr >>= 1;
                        if (0 != (chr_bit ^ crc_bit))
                        {
                            checkSumResult ^= 0x8408;
                        }
                    }
                }
                while (--len > 0);
            }
            return (checkSumResult);
        }

        internal static byte[] GetCommandWithCRC(byte[] partCommand)
        {
            byte[] command = null;
            ushort crc = GasMeterHelper.compute_crc(partCommand, 9);
            byte[] crcByte = BitConverter.GetBytes(crc);
            command = new byte[11];
            System.Buffer.BlockCopy(partCommand, 0, command, 0, partCommand.Length);
            System.Buffer.BlockCopy(crcByte, 0, command, 9, crcByte.Length);
            return command;
        }

        //// Convert Centigrade to Fahrenheit 
        //internal static decimal CtoF_Conversion(double C)
        //{
        //    return Math.Round((decimal)(((9.0 / 5.0) * C) + 32), 1);
        //}

        //private static object lockObject = new object();
        //internal static void WriteToFile(string data, bool isInProduction)
        //{
        //    // Errors text here contains routine info for each meter download status. 
        //    // If necessary, it can be written to the Application log and viewed by EventViewer. 
        //    lock (lockObject)
        //    {
        //        string path = String.Empty;
        //        //if (isInProduction)
        //        //{
        //        //    path = Path.Combine(Utils.GetWinTempDir(), "Errors.txt");
        //        //}
        //        //else
        //        //{
        //        //    path = @"E:\Doc - Dev\Gas Meter\Errors\Errors.txt";
        //        //}
        //        path = Path.Combine(@"C:\Temp\", "Errors.txt");
        //        File.AppendAllText(path, data);
        //    }
        //}

    }

}
