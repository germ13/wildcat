using System.Net;
using System.Net.Sockets;

namespace Wildcat.Logic.SHCA.Engineering.GasMeters
{
    public class SocketWithName
    {
        public string meterName;
        public Socket socket;
        public IPEndPoint IpEndPoint;
        public MeterReadItem meterReadItem;
        public bool IsOpen = false;

        public SocketWithName(IPEndPoint ipEndPoint, Socket socket, string meterName, MeterReadItem mri)
        {
            this.socket = socket;
            this.IpEndPoint = ipEndPoint;
            this.meterName = meterName;
            this.meterReadItem = mri;
        }
    }
}