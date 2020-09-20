using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ISenseCS
{
    [DefaultPropertyAttribute("ModuleSetting")]
    public class _ModuleSetting
    {
        [CategoryAttribute("Module"),
        DefaultValueAttribute("EP01")]
        public string Flag { get; set; }
        [CategoryAttribute("Module"),
        DefaultValueAttribute("SensorNode")]
        public string Name { get; set; }
        [CategoryAttribute("Module"),
        DefaultValueAttribute("20202020")]
        public string VersionNumber { get; set; }
        [CategoryAttribute("Module"),
        DefaultValueAttribute("20202020")]
        public string SerialNumber { get; set; }
        [CategoryAttribute("Module"),
        DefaultValueAttribute("Grididea.com.tw")]
        public string Vender { get; set; }
        [CategoryAttribute("Module"),
        DefaultValueAttribute("User")]
        public string UserDefinedString { get; set; }
    }
    public class LanSetting {
        [CategoryAttribute("Lan Setting"),
        DefaultValueAttribute("192.168.0.240")]
        public string IP { get; set; }
        [CategoryAttribute("Lan Setting"),
        DefaultValueAttribute("255.255.255.0")]
        public string NetMask { get; set; }
        [CategoryAttribute("Lan Setting"),
        DefaultValueAttribute("192.168.0.1")]
        public string Gateway { get; set; }
    }
    public class WLAN_Setting {
        [CategoryAttribute("WLAN Setting"),
        DefaultValueAttribute("AP")]
        public string Mode { get; set; }
        [CategoryAttribute("WLAN Setting"),
        DefaultValueAttribute("AP")]
        public string AP_SSID_PREFIX { get; set; }
        [CategoryAttribute("WLAN Setting"),
        DefaultValueAttribute("AP")]
        public string AP_PASSWORD { get; set; }
        [CategoryAttribute("WLAN Setting"),
        DefaultValueAttribute("AP")]
        public string STA_SSID { get; set; }
        [CategoryAttribute("WLAN Setting"),
        DefaultValueAttribute("AP")]
        public string STA_PASSWORD { get; set; }
        [CategoryAttribute("WLAN Setting"),
        DefaultValueAttribute("AP")]
        public string ConnectionTImeout { get; set; }
        [CategoryAttribute("WLAN Setting")]
        [DefaultValueAttribute("AP")]
        [DisplayName("SEC Type")]
        public string sec { get; set; }

    }
    public class NodeSetting
    {
        [CategoryAttribute("Node Setting")]
        [DefaultValueAttribute("VNODE")]
        [DisplayName("OperationMode")]
        public string opMode { get; set; }

        [CategoryAttribute("Node Setting")]
        [DefaultValueAttribute("6")]
        [DisplayName("MAC in Name")]
        public string macInName { get; set; }

        [CategoryAttribute("Node Setting")]
        [DefaultValueAttribute("BT")]
        [DisplayName("Communication Type")]
        public string commType { get; set; }

        [CategoryAttribute("Node Setting")]
        [DefaultValueAttribute("ADXL")]
        [DisplayName("Active Sensor")]
        public string actSensor { get; set; }
    }
    public class ADXL_Setting
    {
        [CategoryAttribute("ADXL Setting")]
        [DefaultValueAttribute("2G")]
        [DisplayName("Full Scale(G)")]
        public string adfs { get; set; }

        [CategoryAttribute("ADXL Setting")]
        [DefaultValueAttribute("250")]
        [DisplayName("Rate")]
        public string adrate { get; set; }

        [CategoryAttribute("ADXL Setting")]
        [DefaultValueAttribute("HPF")]
        [DisplayName("High Pass Filter")]
        public string adhpfs { get; set; }
    }
    public class IMUSeting
    { 
        [CategoryAttribute("IMU Setting")]
        [DefaultValueAttribute("2")]
        [DisplayName("Full Scale(G)")]
        public string imufs { get; set; }

        [CategoryAttribute("IMU Setting")]
        [DefaultValueAttribute("2000")]
        [DisplayName("Full Scale(DPS)")]
        public string imufsg { get; set; }

        [CategoryAttribute("IMU Setting")]
        [DefaultValueAttribute("400")]
        [DisplayName("Rate")]
        public string imurate { get; set; }


    }



}
