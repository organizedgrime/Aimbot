using System;
using System.Windows.Forms;
using System.Diagnostics;
using MemoryManagerLib;
namespace Aimbot
{
    public partial class Aimbot : Form
    {
        Process[] ProcessList;
        Boolean processAttached = false;

        PlayerInfo MainPlayer = new PlayerInfo(0x50F4F4, new int[] { }, new int[] { 0xF8, 0x40, 0x44, 0x34, 0x3C, 0x38 });
        PlayerInfo Enemy;
        MemoryManager Mem;

        public Aimbot()
        {
            InitializeComponent();
        }

        private void processTimer_Tick(object sender, EventArgs e)
        {
            if(processAttached)
            {
                PlayerData pData, eData;

                // Display MainPlayer information
                MainPlayer.loadData(Mem);
                pData = MainPlayer.dataHolder;
                MainPlayerHLabel.Text = "Health: " + pData.Health;
                MainPlayerXLabel.Text = "X: " + pData.xPos;
                MainPlayerYLabel.Text = "Y: " + pData.yPos;
                MainPlayerZLabel.Text = "Z: " + pData.zPos;

                // Display Enemy information
                Enemy.loadData(Mem);
                eData = Enemy.dataHolder;
                EnemyHLabel.Text = "Health: " + eData.Health;
                EnemyXLabel.Text = "X: " + eData.xPos;
                EnemyYLabel.Text = "Y: " + eData.yPos;
                EnemyZLabel.Text = "Z: " + eData.zPos;

                // Check for each checkbox and mod accordingly

                // Check if aimbot enabled
                if(aimbotCheckbox.Checked)
                {
                    // Check to make sure both are alive
                    if (eData.Health > 0 && pData.Health > 0)
                    {
                        float xdif = eData.xPos - pData.xPos,
                              ydif = eData.yPos - pData.yPos,
                              zdif = eData.zPos - pData.zPos;

                        // Calculate the angle needed to change, convert to degrees
                        float yaw =    (float)(Math.Atan2(eData.yPos - pData.yPos, eData.distanceTo(pData)) * 180 / Math.PI);
                        float pitch = -(float)(Math.Atan2(eData.xPos - pData.xPos, eData.zPos - pData.zPos) * 180 / Math.PI + 180);

                        // Store the calculated values into memory
                        Mem.WriteFloat(MainPlayer.pointerAddress + MainPlayer.offsets[1], pitch);
                        Mem.WriteFloat(MainPlayer.pointerAddress + MainPlayer.offsets[2], yaw);
                    }
                }

                // Check if health lock enabled
                if(healthCheckbox.Checked)
                {
                    // Make sure that the player is alive when we start
                    if(pData.Health > 0)
                    {
                        Mem.WriteInt(MainPlayer.pointerAddress + MainPlayer.offsets[0], 1000);
                    }
                }

            }
        }
        private void processChoiceCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                ProcessList[0] = Process.GetProcessById(ProcessList[processChoiceCombo.SelectedIndex].Id);
                Mem = new MemoryManager(ProcessList[0].Id);
                processTimer.Start();
                processAttached = true;

                // Initialize enemy info
                Enemy = new PlayerInfo(ProcessList[0].MainModule.BaseAddress.ToInt32() + 0x10F4F8, new int[] { 0x4 }, new int[] { 0xF8, 0x40, 0x44, 0x34, 0x3c, 0x38 });

                // Find the pointers from their bases/offsets in the program
                MainPlayer.findPointer(Mem);
                Enemy.findPointer(Mem);
            }
            catch(Exception ex) {
                MessageBox.Show("Error attaching to process: " + ex.GetBaseException());
            }
        }

        private void processChoiceCombo_Click(object sender, EventArgs e)
        {
            processChoiceCombo.Items.Clear();
            ProcessList = Process.GetProcesses();

            for(int i = 0; i < ProcessList.Length; i++)
            {
                processChoiceCombo.Items.Add(ProcessList[i].ProcessName + " - " + ProcessList[i].Id);
            }
        }
    }
}
