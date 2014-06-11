using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XB.API.Domain
{
    /// <summary>
    /// ��������POCO��
    /// </summary>
    public class StorageStationInfo
    {
        public StorageStationInfo()
        {
           // Peripherals = new List<Peripheral>();
           // CabinetContainers = new List<CabinetContainer>();
        }

        /// <summary>
        /// ��������
        /// </summary>
        [JsonProperty("storageStationType")]
        public String StorageStationType { get; set; }

        /// <summary>
        /// ����汾
        /// </summary>
        [JsonProperty("storageStationVersion")]
        public String StorageStationVersion { get; set; }

        /// <summary>
        /// �ʲ����
        /// </summary>
        [JsonProperty("assetSn")]
        public String AssetSn { get; set; }

        /// <summary>
        /// ����״̬
        /// [1,����;2,�޿���;3,���ɸ�;4,ϵͳæ;5,���ϻָ�;6,ά����;7,����;8,����;9,����]
        /// </summary>
        [JsonProperty("storageStationStatus")]
        public int StorageStationStatus { get; set; }

        /// <summary>
        /// ���ݿ���
        /// </summary>
        [JsonProperty("dataCard")]
        public String DataCard { get; set; }

        /// <summary>
        /// �����ӦIP��ַ
        /// ����IP��ַ�򴫵ݣ�Ŀǰ������Ԫ�������ޣɣж��壩
        /// </summary>
        [JsonProperty("ipAddress")]
        public String IpAddress { get; set; }

        /// <summary>
        /// �˿�
        /// </summary>
        [JsonProperty("port")]
        public String Port { get; set; }

        /// <summary>
        /// PHY��·����
        /// ��GPRS��WCDMA��WIFI��GE/FE��
        /// </summary>
        [JsonProperty("phyLinkType")]
        public int PhyLinkType { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// γ��
        /// </summary>
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        [JsonProperty("availableBoxNum")]
        public int AvailableBoxNum { get; set; }

        /// <summary>
        /// ��װʱ��
        /// date format: yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("installDate")]
        public String InstallDate { get; set; }

        /// <summary>
        /// �����������λ��
        /// [1,2,3]
        /// </summary>
        [JsonProperty("controlCabinetLocation")]
        public int ControlCabinetLocation { get; set; }

        /// <summary>
        /// ��Χ�豸�б�
        /// </summary>
        [JsonProperty("peripherals")]
        public Peripherals Peripherals { get; set; }
        // public IList<Peripheral> Peripherals { get; set; }

        /// <summary>
        /// �������
        /// </summary>
        [JsonProperty("cabinetContainers")]
        public CabinetContainers CabinetContainers { get; set; }
        //[JsonProperty("cabinetContainers")]
        //public IList<CabinetContainer> CabinetContainers { get; set; } 
    }

    public class Peripherals
    {
        public Peripherals(IList<Peripheral> peripheralList)
        {
            this.IPeripheral = peripheralList;
        }

        [JsonProperty("IPeripheral")]
        public IList<Peripheral> IPeripheral { get; set; }
    }

    public class CabinetContainers
    {
        public CabinetContainers(IList<CabinetContainer> cabinetContainers)
        {
            this.ICabinetContainer = cabinetContainers;
        }

        [JsonProperty("ICabinetContainer")]
        public IList<CabinetContainer> ICabinetContainer { get; set; }
    }
}