using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Runtime.InteropServices;


namespace SystemMonitor
{
    public partial class Form1 : MetroForm
    {
        private float cpu;
        private float ram;

        private ulong installedMemory;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
        private class MEMORYSTATUSEX
        {

            public uint dwLength;
            public uint dwMemoryLenght;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;

            public MEMORYSTATUSEX()
            {
                this.dwLength=(uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }

        }
    }
}
