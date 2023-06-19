using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FTP_Disable
{
    public class clsSetting
    {
        public class AppSettings
        {
            public string HostName { get; set; }
            public string UserName { get; set; }
            public string privateKeyPath { get; set; }
            public bool isPK { get; set; }
            public string UpdateTime { get; set; }
            public bool isAutoUpdate { get; set; }
            public string password { get; set; }
            public int FTP_Port { get; set; }   

        }
        public static void SaveSettings(AppSettings settings, string filePath)
        {
            var serializer = new XmlSerializer(typeof(AppSettings));
            using (var writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, settings);
            }
        }

        public static AppSettings LoadSettings(string filePath)
        {
            var serializer = new XmlSerializer(typeof(AppSettings));
            using (var reader = new StreamReader(filePath))
            {
                return (AppSettings)serializer.Deserialize(reader);
            }
        }

        public class ParkingLot
        {
            public string url { get; set; }
            public string port { get; set; }
            public string user { get; set; }
            public string pass { get; set; }
            public string database { get; set; }
            public string table { get; set; }
        }
        public class ParkingLots
        {
            [XmlElement("ParkingLot")]
            public List<ParkingLot> Park { get; set; }
        }
        public static ParkingLots LoadDB(string filePath)
        {
            var serializer = new XmlSerializer(typeof(ParkingLots));
            using (var reader = new StreamReader(filePath))
            {
                return (ParkingLots)serializer.Deserialize(reader);
            }
        }

    }
}
