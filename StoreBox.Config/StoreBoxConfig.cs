using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreBox.Config
{
    [Serializable]
    public class StoreBoxConfig
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public string AssetSn { get; set; }
        public string DataCard { get; set; }
        public string IpAddress { get; set; }
        public int Port { get; set; }
        public string PhyLinkType { get; set; }
        public int ControlCabinetLocation { get; set; }
        public Peripheral[] Peripherals { get; set; }
        public CabinetContainer[] CabinetContainers { get; set; }
    }


    public class Peripheral
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string AssetSn { get; set; }
        public int Type { get; set; }
        public string Version { get; set; }
        public string Memo { get; set; }
    }

    public class CabinetContainer
    {
        public string Code { get; set; }
        public string Index { get; set; }
        public int Type { get; set; }
        public string Version { get; set; }
        public string AssetSn { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
