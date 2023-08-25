using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mem Mem = new Mem();

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = Mem.GetProcIdFromName("rpcs3");
            if (PID > 0)
            {
                Mem.OpenProcess(PID);
                connectionLabel.Text = "Connected!";
                connectionLabel.ForeColor = Color.Green;
                pidLabel.Text = PID.ToString();
            }
            else
            {
                connectionLabel.Text = "N/A";
                connectionLabel.ForeColor = Color.Red;
                pidLabel.Text = "N/A";
                pidLabel.ForeColor = Color.Red;
            }
        }

        private void NormalBlade_CheckedChanged(object sender, EventArgs e)
        {
            Mem.WriteMemory("0x300A5EA30", "byte", "0x0", "", null, false); // Normal Blade
        }

        private void CeremonialBlade_CheckedChanged(object sender, EventArgs e)
        {
            Mem.WriteMemory("0x300A5EA30", "byte", "0x1", "", null, false); // Ceremonial Blade
        }

        private void ChampionsBlade_CheckedChanged(object sender, EventArgs e)
        {
            Mem.WriteMemory("0x300A5EA30", "byte", "0x2", "", null, false); // Champions Blade
        }
    }
}
