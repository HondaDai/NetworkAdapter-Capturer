using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management; // System.Management 命名空間
using System.Collections; // System.Collections 命名空間
namespace Win32_NetworkAdapterConfiguration
{
    public partial class Form1 : Form
    {
        ArrayList AryLst = new ArrayList(); // ArrayList 類別
        ManagementObject objCls; // ManagementObject 類別 , 表示 WMI 執行個體。
        string strCls = "Win32_NetworkAdapterConfiguration"; // WMI 名稱空間 ( Namespace )
        string strNS = "root\\CIMV2"; // WMI 類別 (Class)
        string strIndex; // 用來記錄網路介面卡 Index
        Public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAdtInfo(); // 呼叫 GetAdtInfo 程序來取得網路介面卡資訊
        }
        private void GetAdtInfo()
        {
            // 指定查詢網路介面卡組態 ( IPEnabled 為 True 的 )
            string strQry = "Select * from Win32_NetworkAdapterConfiguration where IPEnabled=True";
            // ManagementObjectSearcher 類別 , 根據指定的查詢擷取管理物件的集合。
            ManagementObjectSearcher objSc = new ManagementObjectSearcher(strQry);
            // 使用 Foreach 陳述式 存取集合類別中物件 (元素)
            // Get 方法 , 叫用指定的 WMI 查詢 , 並傳回產生的集合。
            foreach (ManagementObject objQry in objSc.Get())
            {
                // 取網路介面卡資訊
                AryLst.Add(objQry["Index"]); // 將 Index 新增至 ArrayList
                ComboBox.Items.Add(objQry["Description"]); // 將 Description 新增至 ComboBox
            }
        }
        // Button1 指定 IP 位址 , 子網路遮罩 , 預設閘道 , DNS 伺服器
        private void button1_Click(object sender, EventArgs e)
        {
            string strIP = "192.168.1.3"; // IP 位址
            string strSubmask = "255.255.255.0"; // 子網路遮罩
            string strGateway = "192.168.1.1"; // 預設閘道
            string strDNS1 = "168.95.1.1"; // 慣用 DNS 伺服器
            string strDNS2 = "168.95.192.1"; // 其他 DNS 伺服器
            // 呼叫 SetNetCfg 程序 , 設定網路介面卡組態
            SetNetCfg(strIP, strSubmask, strGateway, strDNS1, strDNS2);
        }
        public void SetNetCfg(string strIP, string strSubmask, string strGateway, string strDNS1, string strDNS2)
        {
            // 建立 ManagementObject 物件 ( Scope , Path , options )
            objCls = new ManagementObject(strNS, strCls + ".INDEX=" + strIndex, null);
            ManagementBaseObject objInPara; // 宣告管理物件類別的基本類別
            objInPara = objCls.GetMethodParameters("EnableStatic");
            objInPara["IPAddress"] = new string[] { strIP }; // 設定 "IP" 屬性
            objInPara["SubnetMask"] = new string[] { strSubmask }; // 設定 "子網路遮罩" 屬性
            objCls.InvokeMethod("EnableStatic", objInPara, null);
            objInPara = objCls.GetMethodParameters("SetGateways");
            objInPara["DefaultIPGateway"] = new string[] { strGateway }; // 設定 "Gateway" 屬性
            objCls.InvokeMethod("SetGateways", objInPara, null);
            objInPara = objCls.GetMethodParameters("SetDNSServerSearchOrder");
            objInPara["DNSServerSearchOrder"] = new string[] { strDNS1, strDNS2 }; // 設定 "DNS" 屬性
            objCls.InvokeMethod("SetDNSServerSearchOrder", objInPara, null);
            // GetMethodParameters 方法 : 用來取得 SetDNSServerSearchOrder 參數清單。
            // InvokeMethod 方法 : 在物件上叫用方法。
        }
        // Button2 使用 DHCP 自動取得 IP
        private void button2_Click(object sender, EventArgs e)
        {
            SetAuto(); // 呼叫 SetAuto 程序 , 設定網路介面卡組態
        }
        public void SetAuto()
        {
            // 建立 ManagementObject 物件 ( Scope , Path , options )
            objCls = new ManagementObject(strNS, strCls + ".INDEX=" + strIndex, null);
            // InvokeMethod 方法 : 在物件上叫用方法。
            objCls.InvokeMethod("EnableDHCP", null); // 設定自動取得 IP
            objCls.InvokeMethod("ReleaseDHCPLease", null); // 釋放 IP
            objCls.InvokeMethod("RenewDHCPLease", null); // 重新取得 IP
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得使用者選取的網路介面卡 Index
            strIndex = (ComboBox.SelectedIndex + 1).ToString();
        }
    }
}
