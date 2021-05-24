using System;
using System.IO.Ports;
using System.Net.Mime;
using System.Text;
using System.Threading;

namespace DataFromSerial {
    public class ReadData {
        private static readonly string _portName = "/dev/cu.usbserial-14630";
        private static readonly int _baudRate = 9600;

        public static void Main() {
            SerialPort serialPort = new SerialPort(_portName, _baudRate);
            serialPort.Open();
            while (serialPort.ReadLine() != "") {
                DateTime dateTime = DateTime.Now;
                Console.WriteLine(dateTime + "\t" + serialPort.ReadLine());
            }
        }
    }
}