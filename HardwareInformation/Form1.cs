using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HardwareInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string key = "b14ca5898a4e4133bbce2ea2315a1916";

        private string ProcessorID = "";
        private string EncryptedProcessorID = "";
        private string DiskSerial = "";
        private string EncryptedDiskSerial = "";
        private string Mac= "";
        private string EncryptedMac = "";
        private string BiosSerial = "";
        private string EncryptedBiosSerial = "";
        private string licenseCode = "HC2R2H4R8FVH48FHIEBDCIHGDE23Y74YFYH2YH74HCHUHBDEGF2731";
        private string License = "";
        private string EncryptedLicense = "";


        private string ActivationCode = "";

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void ProcId_Click(object sender, EventArgs e)
        {
            ProcessorID = HardwareInfo.GetProcessorId();
            lblPid.Text = ProcessorID;
        }

        private void HDDSNo_Click(object sender, EventArgs e)
        {
            lblHDD.Text = HardwareInfo.GetHDDSerialNo();
        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            lblMac.Text = HardwareInfo.GetMACAddress();
        }

        private void btnBios_Click(object sender, EventArgs e)
        {
            lblBios.Text = HardwareInfo.GetBIOSserNo();
        }

        private void btnGenerateLicense_Click(object sender, EventArgs e)
        {
            ActivationCode = string.Concat(lblPid.Text, lblHDD.Text, lblMac.Text, lblBios.Text, licenseCode);
            txtActivation.Text = ActivationCode;     // Append text here. 
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            EncryptedProcessorID = Encryption.EncryptString(key, ProcessorID);
            EncryptedDiskSerial = Encryption.EncryptString(key, DiskSerial);
            EncryptedMac = Encryption.EncryptString(key, Mac);
            EncryptedBiosSerial = Encryption.EncryptString(key, BiosSerial);
            EncryptedLicense = Encryption.EncryptString(key, licenseCode);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            ProcessorID = Encryption.DecryptString(key, EncryptedProcessorID);
            DiskSerial = Encryption.DecryptString(key, EncryptedDiskSerial);
            Mac = Encryption.DecryptString(key, EncryptedMac);
            BiosSerial = Encryption.DecryptString(key, EncryptedBiosSerial);
            License = Encryption.DecryptString(key, EncryptedLicense);
        }
    }
}
