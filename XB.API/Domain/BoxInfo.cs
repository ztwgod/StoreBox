using Newtonsoft.Json;
using System;

namespace XB.API.Domain
{
    /// <summary>
    /// ��������
    /// </summary>
    public class BoxInfo
    {
        /// <summary>
        /// ����CODE
        /// ��ȫϵͳΨһ����ʽ��[����Code][�������У���λ��]������3101150002032001003��
        /// </summary>
        [JsonProperty("boxCode")]
        public String BoxCode { get; set; }

        /// <summary>
        /// �������
        /// ��������λ���֣�������λ���㣬��1��ʼ���磺003��
        /// </summary>
        [JsonProperty("boxIndex")]
        public String BoxIndex { get; set; }

        /// <summary>
        /// �ʲ����
        /// </summary>
        [JsonProperty("assetSn")]
        public String AssetSn { get; set; }

        /// <summary>
        /// ���͡����
        /// ��1������,2����,3����,4��С,5����С��
        /// </summary>
        [JsonProperty("boxType")]
        public int BoxType { get; set; }

        /// <summary>
        /// ���״̬
        /// ��1,����;2,ռ��;3,ռ�ó�ʱ;4,������ռ�ó��ڣ���
        /// </summary>
        [JsonProperty("boxLoadStatus")]
        public int BoxLoadStatus { get; set; }

        /// <summary>
        /// ����״̬��
        /// 1�����С�2��ռ�á�3��ռ�ó�ʱ��4��������ռ�ó��ڣ���5��������6�����ϡ�7�����á�8��Ԥ����9��������10��δ�رա�11�����ƻ���12��ά��
        /// </summary>
        [JsonProperty("boxRunStatus")]
        public int BoxRunStatus { get; set; }
    }
}