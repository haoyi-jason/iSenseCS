using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO.Ports;
using System.Net.Sockets;
using System.Net;

namespace ISenseCS
{
    class CommandInterface
    {
        public delegate void HandleData(byte[] val);

        public event HandleData DataReceived;

        SerialPort _port;
        Socket _socket;
        TcpClient _client;
        _connectionType connType;

        public CommandInterface()
        {
            _port = new SerialPort();
            _client = new TcpClient();
        }
        public string _connectionString
        {
            get { return _connectionString; }
            set
            {
                _connectionString = value;
                connType = _connectionType.None;
                Regex rx = new Regex(@"(COM\d+):?(\d+)?", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                Regex rx2 = new Regex(@"\d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}:\d{1,5}$");
                MatchCollection match = rx.Matches(_connectionString);
                if (match.Count > 0)
                {
                    connType = _connectionType.Serial;
                }

                MatchCollection m2 = rx2.Matches(_connectionString);
                if (m2.Count > 0)
                {
                    if(connType != _connectionType.None)
                    {
                        connType = _connectionType.None;
                    }
                    else
                    {
                        connType = _connectionType.Lan;
                    }
                }
            }
        }

        public bool Connect2Device()
        {
            bool ret = false;
            if(connType == _connectionType.Serial)
            {
                _port.PortName = _connectionString;
                _port.BaudRate = 115200;
                _port.Parity = Parity.None;
                _port.StopBits = StopBits.One;
                _port.Handshake = Handshake.None;
                try
                {
                    _port.Open();
                    _port.DataReceived += _port_DataReceived;
                    ret = true;
                }catch(Exception e)
                {
                    _port.Close();
                }

            }
            else if(connType == _connectionType.Lan)
            {
                string remote = _connectionString.Split(':')[0];
                string port = _connectionString.Split(':')[1];

                IPAddress addr;
                try
                {
                    addr = System.Net.IPAddress.Parse(remote);
                    int p = int.Parse(port);
                    if (p <= 0) p = 5001;
                    _client.Connect(addr, p);
                    if (_client.Connected)
                    {
                        
                        ret = true;
                    }
                }catch(FormatException fe)
                {
                    Console.WriteLine("IP format error" + fe.Message);
                }
            }
            return ret;
        }

        private void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort p = (SerialPort)sender;
            int sz = p.BytesToRead;
            if (sz != 0)
            {
                byte[] b = new byte[sz];
                p.Read(b, 0, sz);
                if(DataReceived != null)
                    DataReceived(b);
            }
        }
    }
    public enum _connectionType
    {
        None,
        Serial,
        Lan
    }
}
